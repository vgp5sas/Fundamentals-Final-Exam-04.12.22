using System;
using System.Linq;


namespace _01._Hogwarts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringInput = Console.ReadLine();
            string commandInput = Console.ReadLine();

            while (commandInput != "Abracadabra")
            {
                string[] commands = commandInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                switch (commands[0])
                {
                    case "Abjuration":
                        stringInput = stringInput.ToUpper();
                        Console.WriteLine(stringInput);
                        break;
                    case "Necromancy":
                        stringInput = stringInput.ToLower();
                        Console.WriteLine(stringInput);
                        break;
                    case "Illusion":
                        int position = int.Parse(commands[1]);
                        string replacingLetter = commands[2];
                        if (position >= 0 && position <= stringInput.Length - 1)
                        {
                            stringInput = stringInput.Remove(position, 1);
                            stringInput = stringInput.Insert(position, replacingLetter);
                            Console.WriteLine("Done!");
                        }
                        else
                        {
                            Console.WriteLine("The spell was too weak.");
                        }
                        break;
                    case "Divination":
                        string substring1 = commands[1];
                        string substring2 = commands[2];
                        if (stringInput.Contains(substring1))
                        {
                            stringInput = stringInput.Replace(substring1, substring2);
                            Console.WriteLine(stringInput);
                        }
                        break;
                    case "Alteration":
                        string substring3 = commands[1];
                        if (stringInput.Contains(substring3))
                        {
                            stringInput = stringInput.Replace(substring3, "");
                            Console.WriteLine(stringInput);
                        }
                        break;
                    default:
                        Console.WriteLine("The spell did not work!");
                        break;
                }
                commandInput = Console.ReadLine();
            }
        }
    }
}

