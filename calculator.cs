using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Kalkulator 21.11.4429";
            Console.WriteLine("Pilih Menu Calculator");
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.Write("\n\nInput menu calculator [1234] : "); 
            int x=int.Parse(Console.ReadLine());
          
            
 

            if (x==1)
            {
                Console.Write("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Inputkan nilai b = ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil penambahan" + a + "+" + b + " = " + Penambahan(a, b));
            }

            else if (x == 2)
            {
                Console.Write("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Inputkan nilai b = ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("Hasil pengurangan{0}-{1}={2}", a, b, Pengurangan(a, b));
            }

            else if (x == 3)
            {

                Console.Write("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Inputkan nilai b = ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil Perkalian {0}*{1}={2}", a, b, Perkalian(a, b));
            }

            else if (x == 4)
            {

                Console.Write("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Inputkan nilai b = ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil Pembagian {0}/{1}={2}", a, b, Pembagian(a, b));
            }

            else
            {
                Console.WriteLine("Menu yang anda pilih tidak tersedia");
            }



            Console.WriteLine("\n Tekan Sembarang untuk keluar");
            Console.ReadKey();
           
            


        }



        static int Penambahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a, int b)
        {
            return a- b;
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static int Pembagian(int a, int b)
        {
            return a / b;
        }



    }
}
