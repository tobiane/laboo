using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int prioridad;
            string nombre;
            Console.WriteLine("Cuantas tareas ingresara?:");
            int CantTareas = int.Parse(Console.ReadLine());
            List<Tareas> Lista = new List<Tareas>();
            for (int i = 1; i <= CantTareas; i++)
            {
                Console.WriteLine("Cual es la prioridad de la:" + i + "?");
                prioridad = int.Parse(Console.ReadLine());
                Console.WriteLine("Cual es el nombre de la:" + i + "?");
                nombre = Console.ReadLine();
                Tareas tarea = new Tareas(prioridad, nombre);
                Lista.Add(tarea);
            }
            Lista = Lista.OrderBy(t => t.Prioridad).ToList();
            Console.WriteLine("Lista de tareas ordenadas por prioridad:");
            foreach (Tareas tarea in Lista)
            {
                Console.WriteLine("Prioridad: " + tarea.Prioridad + " Nombre: " + tarea.Nombre);
            }
            Console.ReadKey();
        }
    }
    public class Tareas
    {
        private string nombre;
        private int prioridad;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Prioridad
        {
            get { return prioridad; }
            set { prioridad = value; }
        }
        public Tareas(int prioridad, string nombre)
        {
            Nombre = nombre;
            Prioridad = prioridad;
        }
    }
}
