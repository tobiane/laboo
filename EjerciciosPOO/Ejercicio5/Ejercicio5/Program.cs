using System;
using System.Collections.Generic;
using System.Linq;


namespace Boludeces
{
    internal class Program
    {
        static public string palabra;
        static public string ingresada;
        static public List<char> guessedLetters = new List<char>();
        static public int intentos = 5;


        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una palabra, tiene 5 intentos:");
            palabra = Console.ReadLine();
            char[] letras = palabra.ToCharArray();
            char[] display = new char[letras.Length];
            for (int i = 0; i < display.Length; i++)
            {
                display[i] = '_';
            }
            while (intentos > 0 && display.Contains('_'))
            {
                Console.WriteLine("Ingrese una letra:");
                ingresada = Console.ReadLine();
                if (ingresada.Length != 1)
                {
                    Console.WriteLine("Por favor, ingrese una sola letra.");

                }
                char ing = ingresada[0];
                if (guessedLetters.Contains(ing))
                {
                    Console.WriteLine("Ya ha ingresado esta letra. Pruebe con otra.");
                    continue;
                }
                guessedLetters.Add(ing);
                bool encuentra = false;
                for (int j = 0; j < letras.Length; j++)
                {
                    if (ing == letras[j])
                    {
                        display[j] = ing;
                        encuentra = true;
                    }
                }
                if (encuentra == true)
                {
                    Console.WriteLine("Correcto");
                }
                else
                {
                    intentos--;
                    Console.WriteLine("Incorrecto. Intentos restantes: " + intentos);
                }
                Console.WriteLine("Palabra: " + new string(display));
            }
            if (!display.Contains('_'))
            {
                Console.WriteLine("\n¡Felicidades! Ha adivinado la palabra: " + palabra);
            }
            else
            {
                Console.WriteLine("\nSe han acabado los intentos. La palabra era: " + palabra);
            }
        }
    }
}
