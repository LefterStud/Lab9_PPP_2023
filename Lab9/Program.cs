using static Lab9.FilterParts;
using static Lab9.SortParts;
using static System.Formats.Asn1.AsnWriter;

namespace Lab9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jsonPath = "storage.json";
            //Storage tempStorage = new Storage();
            //const int NUMBERS_OF_PARTS = 10;
            //const int MAX_WEIGHT = 1000;
            //const int MAX_COST = 1000000;
            //Random r = new Random();
            //for (int i = 0; i < NUMBERS_OF_PARTS; i++)
            //{
            //    tempStorage.AddPart(new SparePart(Utils.getRandomPartName(), r.Next(0, MAX_COST), r.Next(0, MAX_WEIGHT)));
            //}
            //FileSaveLoad.JsonSave(jsonPath, storage);

            Storage storage = FileSaveLoad.JsonLoad(jsonPath);
            Console.WriteLine("Original array:\n");
            Console.WriteLine(storage);

            //Приклади використання стандартного делегату.
            Sort(storage, CompareByAscendingName);
            Console.WriteLine("-----------------------\nSort by Ascending Name:\n");
            Console.WriteLine(storage);

            Console.WriteLine("-----------------------\nSort by Descending Id:\n");
            Sort(storage, CompareByDescendingId);
            Console.WriteLine(storage);

            Console.WriteLine("-----------------------\nSort by Ascending Cost:\n");
            Sort(storage, CompareByAscendingCost);
            Console.WriteLine(storage);

            Console.WriteLine("-----------------------\nSort by Descending Weight:\n");
            Sort(storage, CompareByDescendingWeight);
            Console.WriteLine(storage);


            //Прикладb використання лямбда виразу в фільтрації
            Console.WriteLine("-----------------------\nSearch by name:\n");
            Storage filteredByName = SearchParts(storage, "ma",
                (part, value) => part.Name.Contains(value, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(filteredByName);

            Console.WriteLine("-----------------------\nSearch by cost:\n");
            Storage filteredByCost = SearchParts(storage, "2",
                (part, value) => part.Cost.ToString().Contains(value, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(filteredByCost);


            //Приклад використання анонімних методів
            Console.WriteLine("-----------------------\nSearch by asc cost:\n");
            CompareDelegate compareByAscCost = delegate (SparePart left, SparePart right)
            {
                return left.Cost > right.Cost;
            };
            Sort(filteredByName, compareByAscCost);
            Console.WriteLine(filteredByName);


        }
    }
}