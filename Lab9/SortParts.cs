namespace Lab9
{
    internal class SortParts
    {
        public delegate bool CompareDelegate(SparePart left, SparePart right);

        /// <summary>
        /// Sorting the list
        /// </summary>
        public static void Sort(Storage storage, CompareDelegate compareParts)
        {
            for (int i = 0; i < storage.SpareParts.Count() - 1; i++)
            {
                for (int j = 0; j < storage.SpareParts.Count() - 1; j++)
                {
                    if (compareParts(storage.SpareParts[j], storage.SpareParts[j + 1]))
                    {
                        (storage.SpareParts[j], storage.SpareParts[j + 1]) = (storage.SpareParts[j + 1], storage.SpareParts[j]);
                    }
                }
            }
        }


        public static bool CompareByAscendingName(SparePart left, SparePart right)
        {
            return string.Compare(left.Name, right.Name, StringComparison.Ordinal) > 0;
        }
        public static bool CompareByDescendingName(SparePart left, SparePart right)
        {
            return !CompareByAscendingName(left, right);
        }


        public static bool CompareByAscendingId(SparePart left, SparePart right)
        {
            return left.Id > right.Id;
        }
        public static bool CompareByDescendingId(SparePart left, SparePart right)
        {
            return !CompareByAscendingId(left, right);
        }


        public static bool CompareByAscendingCost(SparePart left, SparePart right)
        {
            return left.Cost > right.Cost;
        }
        public static bool CompareByDescendingCost(SparePart left, SparePart right)
        {
            return !CompareByAscendingCost(left, right);
        }


        public static bool CompareByAscendingWeight(SparePart left, SparePart right)
        {
            return left.Weight > right.Weight;
        }
        public static bool CompareByDescendingWeight(SparePart left, SparePart right)
        {
            return !CompareByAscendingWeight(left, right);
        }
    }
}
