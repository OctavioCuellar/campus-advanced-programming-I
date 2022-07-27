using System;
using System.Collections.Generic;

namespace campus_advanced_programming_I
{
    internal static class Delegates
    {
        public delegate void PrintResult();
        public delegate void ListPrinter<T>(List<string> list);

        internal static void EvenNumbers()
        {
            Console.WriteLine($"Here is a list of even numbers from 0 to 50: \n");
            for (int i = 0; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} is even");
                }
            }
        }

        internal static void OddNumbers()
        {
            Console.WriteLine($"\nHere is a list of odd numbers from 0 to 50: \n");
            for (int i = 0; i <= 50; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine($"{i} is odd");
                }
            }
        }

        internal static void ListOrderByAscsending(List<string> list)
        {
            Console.WriteLine($"\nList in ascending order:");
            list.Sort();
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }
        }

        internal static void ListOrderByDescsending(List<string> list)
        {
            Console.WriteLine($"\nList in descending order:");
            list.Sort();
            list.Reverse();
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }
        }

        internal static float RMSFormula(List<int> list)
        {
            int square = 0;
            float mean, root = 0;

            // Calculate Square
            for (int i = 0; i < list.Count; i++)
            {
                square += (int)Math.Pow(list[i], 2);
            }

            // Calculate Mean
            mean = (square / (float)list.Count);

            // Calculate Root
            root = (float)Math.Sqrt(mean);

            return root;
        }

    }
}
