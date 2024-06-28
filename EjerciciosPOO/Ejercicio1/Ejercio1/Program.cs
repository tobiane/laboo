using System;
namespace Ejercicio1
{
    internal class Program
    {
        static public int num;
        static public float promedio;
        static public int total;
        static void Main(string[] args)
        {
            Console.WriteLine("Cantidad de numeros");
            int cant = int.Parse(Console.ReadLine());
            int total = 0;
            for (int i = 0; i < cant; i++)
            {
                Console.WriteLine("Escriba el primer numero");
                int num = int.Parse(Console.ReadLine());
                total = total + num;
            }
            promedio = total / cant;
            Console.WriteLine("el promedio es " + promedio);
            Console.ReadKey();
        }
    }
}
