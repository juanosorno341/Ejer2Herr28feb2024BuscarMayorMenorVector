using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejer2Herr28feb2024BuscarMayorMenorVector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el indice");
            int indice = int.Parse(Console.ReadLine());
            int[] dat = new int[indice];
            for (int i = 0; i < dat.Length; i++)
            {
                Console.WriteLine("Entra el dato [" + i + "]");
                dat[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < dat.Length; i++)
            {
                Console.WriteLine("\n" + dat[i]);
            }

            Console.WriteLine($"\nEl dato mayor es: {dat.Max()}");
            Console.WriteLine($"El dato menor es: {dat.Min()}");


            Console.ReadLine();
            Console.ReadKey();

        }
    }
}
