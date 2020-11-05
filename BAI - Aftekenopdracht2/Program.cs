using System;
using System.Collections.Generic;


namespace BAI
{
    public partial class BAI_Afteken2
    {
        public static bool Vooruit(uint b)
        {
            switch (b >> 7 & 0b1) {
                case (0b0):
                    return false;
                case (0b1):
                    return true;
                default:
                    return false;
            }
        }
        public static uint Vermogen(uint b)
        {
            // 0 = 0b00 1 = 0b01 2 = 0b10 3 = 0b11 
            switch (b >> 5 & 0b11) {
                case (0b00):
                    return 0;
                case (0b01):
                    return 33;
                case (0b10):
                    return 67;
                case (0b11):
                    return 100;
                default:
                    return 0;
            }
        }
        public static bool Wagon(uint b)
        {
            uint result = ((b >> 4) & 1);
            if (result == 1) {
                return true;
            }
            return false;
        }
        public static bool Licht(uint b)
        {
            switch (b >> 3 & 1) {
                case (0b0):
                    return false;
                case (0b1):
                    return true;
                default:
                    return false;
            }
        }
        public static uint ID(uint b)
        {
            //var test =  (b & 0b111);
            return (b & 0b111);
        }

        public static HashSet<uint> Alle(List<uint> inputStroom)
        {
            HashSet<uint> set = new HashSet<uint>();
            foreach (uint item in inputStroom) {
                set.Add(item);
            }
            return set;
        }
        public static HashSet<uint> ZonderLicht(List<uint> inputStroom)
        {
            HashSet<uint> set = new HashSet<uint>();
            foreach (uint item in inputStroom) {
                if (!Licht(item)) {
                    set.Add(item);
                }
            }
            return set;
        }
        public static HashSet<uint> MetWagon(List<uint> inputStroom)
        {
            HashSet<uint> set = new HashSet<uint>();
            foreach (uint item in inputStroom) {
                if (Wagon(item)) {
                    set.Add(item);
                }
            }
            return set;
        }
        public static HashSet<uint> SelecteerID(List<uint> inputStroom, uint lower, uint upper)
        {
            HashSet<uint> set = new HashSet<uint>();
            foreach (uint item in inputStroom) {
                if (ID(item) >= lower && ID(item) <= upper) {
                    set.Add(item);
                }
            }
            return set;
        }

        public static HashSet<uint> Opg3a(List<uint> inputStroom)
        {
            HashSet<uint> setZonderLicht = ZonderLicht(inputStroom);
            HashSet<uint> setSelecteerID = SelecteerID(inputStroom, 0, 2);

            // Adds items from setSelecteerID in setZonderLicht
            setZonderLicht.IntersectWith(setSelecteerID);

            return setZonderLicht;
        }

        public static HashSet<uint> Opg3b(List<uint> inputStroom)
        {
            HashSet<uint> setAlle = Alle(inputStroom);
            HashSet<uint> set3A = Opg3a(inputStroom);

            // Haal alle getallen met een match uit HashSet setAlle, dus lager dan 3 en WEL licht
            setAlle.ExceptWith(set3A);

            return setAlle;
        }

        public static void ToonInfo(uint b)
        {
            Console.WriteLine($"ID {ID(b)}, Licht {Licht(b)}, Wagon {Wagon(b)}, Vermogen {Vermogen(b)}, Vooruit {Vooruit(b)}");
        }

        public static List<uint> GetInputStroom()
        {
            List<uint> inputStream = new List<uint>();
            for (uint i = 0; i < 256; i++)
            {
                inputStream.Add(i);
            }
            return inputStream;
        }

        public static void PrintSet(HashSet<uint> x)
        {
            Console.Write("{");
            foreach (uint i in x)
                Console.Write($" {i}");
            Console.WriteLine($" }} ({x.Count} elementen)");
        }


        static void Main(string[] args)
        {
            Console.WriteLine("=== Opgave 1 ===");
            ToonInfo(210);
            Console.WriteLine();

            List<uint> inputStroom = GetInputStroom();

            Console.WriteLine("=== Opgave 2 ===");
            HashSet<uint> alle = Alle(inputStroom);
            PrintSet(alle);
            HashSet<uint> zonderLicht = ZonderLicht(inputStroom);
            PrintSet(zonderLicht);
            HashSet<uint> metWagon = MetWagon(inputStroom);
            PrintSet(metWagon);
            HashSet<uint> groter6 = SelecteerID(inputStroom, 6, 7);
            PrintSet(groter6);
            Console.WriteLine();

            Console.WriteLine("=== Opgave 3a ===");
            HashSet<uint> opg3a = Opg3a(inputStroom);
            PrintSet(opg3a);
            foreach (uint b in opg3a)
            {
                ToonInfo(b);
            }
            Console.WriteLine();

            Console.WriteLine("=== Opgave 3b ===");
            HashSet<uint> opg3b = Opg3b(inputStroom);
            PrintSet(opg3b);
            foreach (uint b in opg3b)
            {
                ToonInfo(b);
            }
            Console.WriteLine();
        }
    }
}
