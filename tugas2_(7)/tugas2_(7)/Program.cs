using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas2__7_
{
    internal class Program
    {
        static double RataRata(double nilai1, double nilai2, double nilai3)
        {
            double hasil = (nilai1 + nilai2 + nilai3) / 3;
            return hasil;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Menghitung Rata-rata nilai");

            Console.Write("Masukkan nilai pertama: ");
            double nilai1 = double.Parse(Console.ReadLine());

            Console.Write("Masukkan nilai kedua: ");
            double nilai2 = double.Parse(Console.ReadLine());

            Console.Write("Masukkan nilai ketiga: ");
            double nilai3 = double.Parse(Console.ReadLine());

            double hasil = RataRata(nilai1, nilai2, nilai3);
            Console.WriteLine("Rata-rata nilai = " + hasil);
        }
    }
}
