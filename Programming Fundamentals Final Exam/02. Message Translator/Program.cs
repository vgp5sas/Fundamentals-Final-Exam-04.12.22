using System;
using System.Text.RegularExpressions;

namespace _02._Message_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberInputs = int.Parse(Console.ReadLine());
            Regex specimen = new Regex(@"(!)(?<command>[A-Z][a-z]{2,})(\1).([[])(?<message>[A-Za-z]{8,})([]])");

            for (int i = 0; i < numberInputs; i++)
            {
                string inputMessage = Console.ReadLine();
                Match valid = specimen.Match(inputMessage);

                if (valid.Success)
                {
                    string line = valid.Groups["message"].Value;

                    Console.Write($"{valid.Groups["command"]}: ");

                    foreach (var characters in line)
                    {
                        int n = characters;

                        Console.Write($"{n} ");
                    }
                    Console.WriteLine();
                }

                else
                {
                    Console.WriteLine("The message is invalid");
                }

            }
        }
    }
}

