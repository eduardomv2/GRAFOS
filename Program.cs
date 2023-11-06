using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplicación de Grafo No Dirigido");
            Console.Write("Ingrese el número de nodos: ");
            int numNodos = int.Parse(Console.ReadLine());

            Grafo grafo = new Grafo(numNodos);

            while (true)
            {
                Console.WriteLine("\nSeleccione una opción:");
                Console.WriteLine("1. Agregar Arista");
                Console.WriteLine("2. Mostrar Grafo");
                Console.WriteLine("3. Salir");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el nodo de origen: ");
                        int nodoOrigen = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el nodo de destino: ");
                        int nodoDestino = int.Parse(Console.ReadLine());
                        grafo.AgregarArista(nodoOrigen, nodoDestino);
                        break;
                    case 2:
                        Console.WriteLine("Grafo:");
                        grafo.MostrarGrafo();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
        }
    }

