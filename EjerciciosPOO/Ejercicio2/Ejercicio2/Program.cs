using System;
using System.Collections.Generic;

namespace Ejercicio2
{
    public class Menu
    {
        string[] items;
        int filaActual = 0;
        static float total;
        public Menu(string[] opciones)
        {
            items = opciones;
        }
        public void dibujar(int columna, int fila)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (i == filaActual)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                }
                Console.SetCursorPosition(columna, fila + i);
                Console.WriteLine(items[i]);
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
        public void Moverarriba()
        {
            if (filaActual > 0)
            {
                filaActual--;
            }
        }
        public void Moverabajo()
        {
            if (filaActual < items.Length - 1)
            {
                filaActual++;
            }
        }
        public int filaactual
        {
            get { return filaActual; }
            set { filaActual = value; }
        }
        public void Deposito()
        {
            Console.Clear();
            Console.WriteLine("Ingrese su deposito:");
            float deposito = float.Parse(Console.ReadLine());
            total = total + deposito;
            Console.WriteLine("Deposito hecho.");
            Console.WriteLine("El saldo actual es de " + total);
            Console.WriteLine("Presione cualquier tecla para continuar.");
            Console.ReadKey();
        }
        public void Retirar()
        {
            Console.Clear();
            Console.WriteLine("Ingrese la cantidad a retirar:");
            float retirar = float.Parse(Console.ReadLine());
            if ((total - retirar) < 0)
            {
                Console.WriteLine("No tiene saldo suficiente");
                Console.WriteLine("Su saldo es de " + total);
            }
            else
            {
                total = total - retirar;
                Console.WriteLine("Su nuevo saldo es de " + total);
            }


            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
        }
        public void Ver()
        {
            Console.Clear();
            Console.WriteLine("Su saldo actual es de " + total);
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            Menu menu1;
            string[] opciones =
            {
                "Depositar",
                " Retirar ",
                "   Ver   ",
                "  Salir  "
            };
            menu1 = new Menu(opciones);
            menu1.dibujar(2, 2);
            while (true)
            {
                ConsoleKeyInfo tecla = Console.ReadKey(true);
                switch (tecla.Key)
                {
                    case ConsoleKey.UpArrow:
                        Console.Clear();
                        menu1.Moverarriba();
                        menu1.dibujar(2, 2);
                        break;
                    case ConsoleKey.DownArrow:
                        Console.Clear();
                        menu1.Moverabajo();
                        menu1.dibujar(2, 2);
                        break;
                    case ConsoleKey.Enter:
                        string seleccion = opciones[menu1.filaactual];
                        switch (seleccion)
                        {
                            case "Depositar":
                                menu1.Deposito();
                                break;
                            case " Retirar ":
                                menu1.Retirar();
                                break;
                            case "   Ver   ":
                                menu1.Ver();
                                break;
                            case "  Salir  ":
                                Environment.Exit(0);
                                break;
                        }
                        Console.Clear();
                        menu1.dibujar(2, 2);
                        break;
                }
            }
        }
    }
}
