using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filename = args[0];
        Queue<string> linhas = new Queue<string>();

        Console.WriteLine("Insira texto (linha vazia para terminar):");

        while (true)
        {
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
                break;

            linhas.Enqueue(input);
        }

        try
        {
            File.WriteAllLines(filename, linhas);
            Console.WriteLine($"Texto guardado em \"{filename}\" com sucesso.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao escrever no ficheiro: {ex.Message}");
        }
    }
}