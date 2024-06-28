using System;
namespace Ejercicio3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int numrandom = rnd.Next(0, 100);
            Console.Write("Ingrese el numero que piensa que yo pense: ");
            int adivinanza = int.Parse(Console.ReadLine());
            if (adivinanza == numrandom)
            {
                Console.WriteLine("adivinaste, el numero era " + numrandom);
            }
            else
            {
                Console.WriteLine("no adivinaste, el numero era " + numrandom);
            }
            Console.ReadKey();
        }
    }
}
