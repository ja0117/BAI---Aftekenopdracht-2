using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Tests
{
    public class TestUtils
    {
        // ------------------------------------------------------------
        // Maakt een lijst op basis van een string.
        // Getallen zijn ints, gescheiden door spaties
        // ------------------------------------------------------------
        public static List<int> IntListFromString(string str)
        {
            List<int> list = new List<int>();

            if (str.Length > 0)
                list = str.Split(" ").Select(Int32.Parse).ToList();
            return list;
        }
        // ------------------------------------------------------------
        // Maakt een lijst op basis van een string.
        // Getallen zijn uints, gescheiden door spaties
        // ------------------------------------------------------------
        public static List<uint> UIntListFromString(string str)
        {
            List<uint> list = new List<uint>();

            if (str.Length > 0)
                list = str.Split(" ").Select(uint.Parse).ToList();
            return list;
        }

        // ------------------------------------------------------------
        // Maakt een string van een willekeurige lijst
        // ------------------------------------------------------------
        public static string EnumToString<T>(IEnumerable<T> lst)
        {
            StringBuilder sb = new StringBuilder();

            if (lst.Count() == 0)
                return "";

            foreach (T x in lst)
            {
                sb.Append(x.ToString());
                sb.Append(" ");
            }
            sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }
    }
}
