namespace Lab9
{
    internal class Utils
    {
        private static Random _random = new();
        private static string[] _names = {
            "Radiator",
            "Alternator",
            "Battery",
            "Starter",
            "Muffler",
            "Carburetor",
            "Sparkplug",
            "Thermostat",
            "Sensor",
            "Solenoid",
            "Shockabsorber",
            "Radiatorcap",
            "Transmission",
            "Clutch",
            "Flywheel",
            "Bearing",
            "Injector",
            "Manifold",
            "Distributor",
            "Camshaft"
        };
        public static string getRandomPartName()
        {
            return _names[_random.Next(_names.Length)];
        }
    }
}
