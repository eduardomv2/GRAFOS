using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Grafo
{
    private int numNodos;
    private List<int>[] listaAdyacencia;

    public Grafo(int numNodos)
    {
        this.numNodos = numNodos;
        listaAdyacencia = new List<int>[numNodos];
        for (int i = 0; i < numNodos; i++)
        {
            listaAdyacencia[i] = new List<int>();
        }
    }

    public void AgregarArista(int nodoOrigen, int nodoDestino)
    {
        listaAdyacencia[nodoOrigen].Add(nodoDestino);
        listaAdyacencia[nodoDestino].Add(nodoOrigen);
    }

    public void MostrarGrafo()
    {
        for (int i = 0; i < numNodos; i++)
        {
            Console.Write($"Nodo {i}: ");
            foreach (int nodo in listaAdyacencia[i])
            {
                Console.Write($"{nodo} ");
            }
            Console.WriteLine();
        }
    }
}
