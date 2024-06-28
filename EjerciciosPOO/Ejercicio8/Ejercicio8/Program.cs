using System;
using System.Collections.Generic;


namespace ejercicio8
{
    public class Libro
    {
        string titulo;
        string autor;
        bool disponible;


        public string Titulo
        {
            get { return titulo; }
        }
        public string Autor
        {
            get { return autor; }
        }
        public bool Disponible
        {
            get { return disponible; }
            set { disponible = value; }
        }




        public Libro(string titulo, string autor)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.disponible = true;
        }
    }


    public class Menu
    {
        string[] items;
        int filaActual = 0;
        List<Libro> libros = new List<Libro>();
        Dictionary<string, string> prestamos = new Dictionary<string, string>();


        public Menu(string[] opciones)
        {
            items = opciones;
            libros.Add(new Libro("Cien años de soledad", "Gabriel García Márquez"));
            libros.Add(new Libro("El principito", "Antoine de Saint-Exupéry"));
            libros.Add(new Libro("Harry Potter y la piedra filosofal", "J.K. Rowling"));
        }


        public void Dibujar(int columna, int fila)
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


        public void MoverArriba()
        {
            if (filaActual > 0)
            {
                filaActual--;
            }
        }


        public void MoverAbajo()
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




        public void ListarLibros()
        {
            Console.Clear();
            foreach (Libro libro in libros)
            {
                Console.WriteLine("Titulo: " + libro.Titulo + " Autor: " + libro.Autor + " Disponibilidad: " + libro.Disponible);
            }

            Console.ReadKey();
        }


        public string BuscarLibro(string titulobuscado)
        {

            bool encontrado = false;
            foreach (Libro libro in libros)
            {
                if (libro.Titulo.Equals(titulobuscado))
                {
                    Console.WriteLine("Libro econtrado");
                    encontrado = true;
                    Console.WriteLine("Presione cualquier tecla para continuar");
                    Console.ReadKey();
                }
            }


            if (!encontrado)
            {
                Console.WriteLine("Libro no encontrado en la biblioteca.");
                Console.WriteLine("Presione cualquier tecla para continuar");
                Console.ReadKey();
                return null;
            }


            return null;

        }


        public string PrestarLibro(string tituloprestado, string persona)
        {


            bool encontrado = false;
            foreach (Libro libro in libros)
            {
                if (libro.Titulo.Equals(tituloprestado) && libro.Disponible == true)
                {
                    libro.Disponible = false;
                    encontrado = true;
                    Console.WriteLine("Libro " + libro.Titulo + " prestado.");
                    prestamos.Add(libro.Titulo, persona);
                    Console.WriteLine("Presione cualquier tecla para continuar");
                    Console.ReadKey();
                    break;
                }
            }


            if (!encontrado)
            {
                Console.WriteLine("El libro no está disponible para préstamo o no existe.");
                return null;


            }




            return null;
        }


        public void DevolverLibro(string librodevuelto)
        {



            if (prestamos.ContainsKey(librodevuelto))
            {
                string nombreCliente = prestamos[librodevuelto];
                foreach (Libro libro in libros)
                {
                    if (libro.Titulo.Equals(librodevuelto, StringComparison.OrdinalIgnoreCase))
                    {
                        libro.Disponible = true;
                        Console.WriteLine($"Libro \"{libro.Titulo}\" devuelto por {nombreCliente}.");
                        prestamos.Remove(librodevuelto);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("No hay registros de préstamo para este libro.");
            }


            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
        }
    }


    internal class Program
    {
        public static void Main(string[] args)
        {
            string titulobuscado, tituloprestado, titulodevolver, persona;
            Menu menu1;
            string[] opciones =
            {
                " Listar libros ",
                " Buscar libro ",
                " Prestar libro ",
                " Devolver libro ",
                "     Salir       "
            };
            menu1 = new Menu(opciones);
            menu1.Dibujar(2, 2);


            while (true)
            {
                ConsoleKeyInfo tecla = Console.ReadKey(true);


                switch (tecla.Key)
                {
                    case ConsoleKey.UpArrow:
                        Console.Clear();
                        menu1.MoverArriba();
                        menu1.Dibujar(2, 2);
                        break;
                    case ConsoleKey.DownArrow:
                        Console.Clear();
                        menu1.MoverAbajo();
                        menu1.Dibujar(2, 2);
                        break;
                    case ConsoleKey.Enter:
                        string seleccion = opciones[menu1.filaactual];
                        switch (seleccion)
                        {
                            case " Listar libros ":
                                Console.WriteLine("Lista de Libros:");
                                menu1.ListarLibros();
                                Console.WriteLine("Presione cualquier tecla para continuar");
                                break;
                            case " Buscar libro ":
                                Console.Clear();
                                Console.WriteLine("Ingrese el título del libro a buscar:");
                                titulobuscado = Console.ReadLine();
                                menu1.BuscarLibro(titulobuscado);

                                break;
                            case " Prestar libro ":
                                Console.Clear();
                                Console.WriteLine("ingrese que libro quiere prestar");
                                tituloprestado = Console.ReadLine();
                                Console.WriteLine("A quien se lo quiere prestar?");
                                persona = Console.ReadLine();
                                menu1.PrestarLibro(tituloprestado, persona);
                                break;
                            case " Devolver libro ":
                                Console.Clear();
                                Console.WriteLine("ingrese que libro quiere devolver");
                                titulodevolver = Console.ReadLine();
                                menu1.DevolverLibro(titulodevolver);
                                break;
                            case "     Salir       ":
                                Environment.Exit(0);
                                break;
                        }
                        Console.Clear();
                        menu1.Dibujar(2, 2);
                        break;
                }
            }
        }
    }
}

