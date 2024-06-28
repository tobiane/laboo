using System;


namespace ejercicio10
{
    class Program
    {
        static void Main()
        {
            int opcion, metros, pies;
            Console.WriteLine("Seleccione que conversión quiere hacer:");
            Console.WriteLine("1. Metros a Pies");
            Console.WriteLine("2. Pies a Metros");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese la cantidad de metros:");
                    metros = int.Parse(Console.ReadLine());
                    Console.WriteLine(metros + " metros, son: " + ConvertirMetrosAPies(metros) + " pies");
                    break;
                case 2:
                    Console.WriteLine("Ingrese la cantidad de pies:");
                    pies = int.Parse(Console.ReadLine());
                    Console.WriteLine(pies + " pies, son: " + ConvertirPiesAMetros(pies) + " metros");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
            Console.ReadKey();
        }
        static double ConvertirMetrosAPies(int metros)
        {
            return metros * 3.28084;
        }
        static double ConvertirPiesAMetros(int pies)
        {
            return pies / 3.28084;
        }
    }
}
