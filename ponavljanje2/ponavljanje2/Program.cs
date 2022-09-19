using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ponavljanje2
{
    internal class Program
    {
        private static string a;
        static void Main(string[] args)
        {

            Console.WriteLine("Upišite znakove: ");

            a = Console.ReadLine();

            string a1;
            a1 = a.Replace(" ", "_");
            Console.WriteLine(a1);

            Console.ReadKey();

        }
    }
}
