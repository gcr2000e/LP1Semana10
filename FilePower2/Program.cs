using System;
using System.IO;

namespace FilePower2
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string filename = args[0];

            Console.WriteLine("Insira texto (linha vazia para terminar):");

            using (StreamWriter writer = new StreamWriter(filename))
            {
                while (true)
                {
                    string input = Console.ReadLine();
                    if (string.IsNullOrEmpty(input))
                        break;

                    writer.WriteLine(input); // Escreve diretamente no ficheiro
                }
            }

            Console.WriteLine($"Texto guardado em \"{filename}\" com sucesso.");
        }
    }
}
