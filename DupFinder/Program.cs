using System;
using System.Collections.Generic;

namespace DupFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            args = new string[5] { "123", "123", "12", "43", "43" };
            if (args.Length > 0)
            {
                if (args[0] == "--help" || args[0] == "-help")
                {
                    Console.WriteLine("Help: \nВсе значения должны быть разделены пробелами.\nПример: 123 123 | 12 43 43");
                    return;
                }
            }
            else
                return;
            List<String> list = new List<string>();
            list.Add(args[0]);
            Console.Write(args[0] + " ");
            int j2;
            for (int i = 1; i < args.Length; i++)
            {
                j2 = list.Count;
                for (int j = 0; j < j2; j++)
                {
                    if (args[i] != list[j])
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        list.Add(args[i]);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    }
                }
                Console.Write(args[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
