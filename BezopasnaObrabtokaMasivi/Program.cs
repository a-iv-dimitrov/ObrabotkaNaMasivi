using System.Runtime.InteropServices;

namespace BezopasnaObrabtokaMasivi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }

                string[] commandArgs = command.Split();

                switch (commandArgs[0])
                {
                    case "Reverse":
                        Array.Reverse(array);
                        break;
                    case "Distinct":
                        array = array.Distinct().ToArray();
                        break;
                    case "Replace":
                        int index;
                        if (!int.TryParse(commandArgs[1], out index))
                        {
                            Console.WriteLine("Невалиден вход!");
                            continue;
                        }

                        if (index < 0 || index >= array.Length)
                        {
                            Console.WriteLine("Невалиден вход!");
                            continue;
                        }

                        string str = commandArgs[2];
                        array[index] = str;
                        break;
                    default:
                        Console.WriteLine("Невалидна команда!");
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", array));
        }
    }
}
