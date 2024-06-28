using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;


namespace Ejercicio9
{
    internal class Program
    {
        public static int x;
        public static int y;
        public static int distancia;
        static void Main(string[] args)
        {   
            Console.WriteLine("Ingrese su primer eje cartesiano x");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su segundo eje cartesiano x");
            y = int.Parse(Console.ReadLine());
            distancia = Calcular(x, y);
            Console.WriteLine("la distancia entre los puntos es de " + distancia);
            Console.ReadKey();
            int Calcular(int x, int y)
            {
                return Math.Abs(y - x);
            }
        }
    }
}

