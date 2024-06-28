using System;
namespace Ejercicio4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número máximo para los números primos:");
            int numMax = int.Parse(Console.ReadLine());
            for (int i = 2; i <= numMax; i++)
            {
                bool Primo = true;
                for (int k = 2; k < i; k++)
                {
                    if (i % k == 0)
                    {
                        Primo = false;
                        break;
                    }
                }
                if (Primo)
                {
                    Console.WriteLine(i + " es un numero primo");
                }
            }
            Console.ReadKey();
        }
    }
}
