using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas1__6_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;

            Console.WriteLine("Menghitung perkalian 5: ");

            for (int i = 1; i <= 10; i++)
            {
                total = total * i;
                Console.WriteLine($"{5 * i}");

            }
        }
    }
}
