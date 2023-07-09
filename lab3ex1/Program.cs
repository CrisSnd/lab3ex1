using System;


namespace MyApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /* Scrieti o functie care va calcula suma cifrelor unui numar.*/

            Console.WriteLine("Introduceti numarul:");

            int numarIntrodus = int.Parse(Console.ReadLine());

            int sumaNumComp = SumaCifreNumar(numarIntrodus);

            Console.WriteLine($"Suma cifrelor numarului introdus este: {sumaNumComp}.");

        }

        static int SumaCifreNumar(int numarIntrodus)
        {
            int sumNum = 0;

            while (numarIntrodus > 0)

            {
                int extrUltimaCifra = numarIntrodus % 10;
                sumNum = sumNum + extrUltimaCifra;
                numarIntrodus = numarIntrodus / 10;

            }
            return sumNum;
        }
    }
}  

