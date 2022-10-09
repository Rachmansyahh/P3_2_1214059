using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_2_1214059
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool finished = false;

            do
            {
                Console.WriteLine("Menghitung Luas & Keliling Persegi Panjang");
                Console.WriteLine("1. Hitung Luas");
                Console.WriteLine("2. Hitung Keliling ");

                int pilih;
                Console.WriteLine("Menu Pilihan : ");

                double panjang, lebar, hasil;
                hasil = 0;

                pilih = int.Parse(Console.ReadLine());

                if (pilih < 1 || pilih > 2)
                {
                    Console.WriteLine("Pilihan Tidak Ada ! ! !");
                }

                switch (pilih)
                {
                    case 1:
                        Console.WriteLine(" == Luas Persegi Panjang ==");
                        Console.Write("panjang : ");
                        panjang = double.Parse(Console.ReadLine());
                        Console.Write("Lebar : ");
                        lebar = double.Parse(Console.ReadLine());
                        hasil = panjang * lebar;
                        Console.WriteLine("Luas Persegi Panjang =  {0} cm", hasil);
                        break;

                    case 2:
                        Console.WriteLine("== Keliling Persegi Panjang == ");
                        Console.Write("Panjang  : ");
                        panjang = double.Parse(Console.ReadLine());
                        Console.Write("Lebar : ");
                        lebar = double.Parse(Console.ReadLine());
                        hasil = (2 * panjang) + (2 * lebar);
                        Console.WriteLine("Luas Persgi Panjang Adalah =  {0} cm", hasil);
                        break;
                }

                Console.WriteLine("Apakah akan menghitung kembali? (Y/T)?");
                char c = char.Parse(Console.ReadLine());

                if (c == 'y')
                {
                    finished = false;
                }
                else
                {
                    finished = true;
                }
                Console.Clear();
            } while (!finished);
        }
    }
}
