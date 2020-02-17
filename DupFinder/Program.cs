using System;
using System.Collections.Generic;

namespace DupFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                if (args[0] == "--help" || args[0] == "-help")
                {
                    Console.WriteLine("Help: \nВсе значения должны быть разделены пробелами. В качестве разделителями между \"строками\" рекомендую использовать <> \nПример: 123 123 <> 12 43 43");
                    return;
                }
            }
            else
                return;
            Console.WriteLine("Output: -----------------------------------------------------------------");
            List<String> list = new List<string>();
            list.Add(args[0]);
            Console.Write(args[0] + " ");
            int j2;
            bool have;
            for (int i = 1; i < args.Length; i++)
            {
                j2 = list.Count;
                have = false;
                for (int j = 0; j < j2; j++)
                {
                    if (args[i] != list[j])
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        have = false;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        have = true;
                        break;
                    }
                    
                }
                if (!have)
                    list.Add(args[i]);
                if (args[i] == "<>")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(args[i] + " ");
                }
                else
                {                    
                    Console.Write(args[i] + " ");
                }

            }
            Console.WriteLine();
        }
    }
}
