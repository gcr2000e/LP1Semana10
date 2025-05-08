using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] valores = { 1, 10, -30, 10, -5 };

        List<int> lista = new List<int>();
        foreach (int valor in valores)
            lista.Add(valor);

        Console.Write("List: ");
        foreach (int i in lista)
            Console.Write(i + ", ");
        Console.WriteLine();

        Stack<int> pilha = new Stack<int>();
        foreach (int valor in valores)
            pilha.Push(valor);

        Console.Write("Stack: ");
        foreach (int i in pilha)
            Console.Write(i + ", ");
        Console.WriteLine();

        Queue<int> fila = new Queue<int>();
        foreach (int valor in valores)
            fila.Enqueue(valor);

        Console.Write("Queue: ");
        foreach (int i in fila)
            Console.Write(i + ", ");
        Console.WriteLine();

        HashSet<int> conjunto = new HashSet<int>();
        foreach (int valor in valores)
            conjunto.Add(valor);

        Console.Write("HashSet: ");
        foreach (int i in conjunto)
            Console.Write(i + ", ");
        Console.WriteLine();
    }
}