using System.Data;
using System.Runtime.ExceptionServices;

namespace ObrabotkaNaMasivi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) 
            {
                string[] input = Console.ReadLine().Split();

                switch(input[0])
                {
                    case "Reverse":
                        Array.Reverse(array); break;
                    case "Distinct":
                        array = array.Distinct().ToArray(); break;
                    case "Replace":
                        int index = int.Parse(input[1]);
                        string str = input[2];
                        array[index] = str;
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
