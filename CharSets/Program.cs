using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CharSets
{
    public class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                HashSet<char> charSet = new HashSet<char>();

                foreach (string filename in args)
                {
                    if (!File.Exists(filename))
                    {
                        Console.WriteLine($"Erro: O ficheiro '{filename}' não existe.");
                        return;
                    }

                    using (StreamReader reader = new StreamReader(filename))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (line.Length != 1)
                            {
                                Console.WriteLine($"Erro: O ficheiro '{filename}' contém uma linha com mais que um caracter.");
                                return;
                            }
                            charSet.Add(line[0]);
                        }
                    }
                }

                List<char> sortedChars = charSet.OrderBy(c => c).ToList();
                foreach (char c in sortedChars)
                {
                    Console.WriteLine(c);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado: {ex.Message}");
            }
        }
    }
}
