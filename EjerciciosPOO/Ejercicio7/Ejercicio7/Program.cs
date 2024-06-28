using System;
using System.Collections.Generic;
using System.Linq;


namespace Ejercicio7
{
    internal class Program
    {
        public static int numeros;
        public static char[] numlist;
        public static int cantnum;
        public static int numax = 0;
        public static int numin = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("cuantos numeros quiere ingresar");
            cantnum = int.Parse(Console.ReadLine());
            int[] numlist = new int[cantnum];


            for (int i = 0; i < cantnum; i++)
            {
                Console.WriteLine("ingrese el numero" + i + 1);
                numlist[i] = int.Parse(Console.ReadLine());
            }
            numin = numlist[0];
            for (int i = 0; i < numlist.Length; i++)
            {
                if (numax < numlist[i])
                {
                    numax = numlist[i];
                }
                if (numin > numlist[i])
                {
                    numin = numlist[i];
                }
            }
            Console.WriteLine("el numero menor es " + numin);
            Console.WriteLine("el numero mayor es " + numax);
            Console.ReadKey();
        }
    }
}

