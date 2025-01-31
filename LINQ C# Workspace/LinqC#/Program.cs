using System;
using System.Linq;

namespace Linq_Demo
{
    class Program
    {
        public static void Main()
        {
            int[] age = { 21, 19, 17, 23, 27, 30, 31, 10, 2, 4, 7, 25, };
            // var a = from i in age where i > 20 orderby i select i;  -- Ascending Order
            // var a = from i in age where i > 20 orderby i descending select i; // Descending Order
            var b = from i in age where i < 20 orderby i select i;
            foreach (int num in b)
            {
                Console.WriteLine(num);
            }

            string[] names = { "Ali", "Adil", "Osama", "Usman", "Hamza" };
            // var a = from name in names where name.Contains("a") select name;
            var a = from name in names where name.StartsWith("A") select name;
            foreach (string item in a)
            {
                Console.WriteLine(item);
            }
        }
    }
}