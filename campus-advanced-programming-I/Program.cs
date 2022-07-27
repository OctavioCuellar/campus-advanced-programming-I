using System;

namespace campus_advanced_programming_I
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. and 2. List even and odd numbers from a given range
            Delegates.PrintResult printEven = Delegates.EvenNumbers;
            Delegates.PrintResult printOdd = Delegates.OddNumbers;
            printEven();
            printOdd();

            // 3. and 4. A func that orders a given list in ascending and descending order
            List<string> disorderedList = new()
            {
                ("Jaz"),
                ("Zack"),
                ("Mickey"),
                ("Aram"),
                ("Lilian"),
                ("Violeta"),
                ("Juan"),
                ("Pablo"),
                ("Chrstian"),
                ("Carla")
            };

            Console.WriteLine($"\nDisordered list: ");
            foreach (var list in disorderedList)
            {
                Console.WriteLine($"{list}");
            }

            Delegates.ListPrinter<List<string>> listAscPrinter = Delegates.ListOrderByAscsending;
            listAscPrinter.Invoke(disorderedList);

            Delegates.ListPrinter<List<string>> listDescPrinter = Delegates.ListOrderByDescsending;
            listDescPrinter.Invoke(disorderedList);

            // 5. A function that checks if the value is multiple of 3
            int number = 24;
            Predicate<int> multipleOf3 = n => n % 3 == 0;
            bool isMultipleOf3 = multipleOf3(number);
            Console.WriteLine($"\nIs {number} a multiple of 3? Result: {isMultipleOf3}\n");

            // 6. A delegate that writes text in the console that is passed by parameter
            Action<string> printSomeText = (string str) => Console.WriteLine($"Returning some text with {str}");
            printSomeText(disorderedList[0]);
            
            // 7. 8. and 9. A function that gets the maximum value of a given list, the minimum value and the average value
            List<int> numbersList = new() { 10, 25, 34, 42, 7, 117, 48, 28, 24, 11 };
            Console.WriteLine($"\nNumbers list: ");
            foreach (var list in numbersList)
            {
                Console.WriteLine($"{list}");
            }

            Func<List<int>, string> getMaxNumber = (numbersList) => $"The maximum value of the list is {numbersList.Max()}\n";
            Func<List<int>, string> getMinNumber = (numbersList) => $"The minimum value of the list is {numbersList.Min()}\n";
            Func<List<int>, string> getAvgNumber = (numbersList) => $"The average value of the list is {numbersList.Average()}\n";

            Console.WriteLine($"\n{getMaxNumber.Invoke(numbersList)}" +
                              $"\n{getMinNumber.Invoke(numbersList)}" +
                              $"\n{getAvgNumber.Invoke(numbersList)}");

            // 10. A function that calculates the RMS value of a list of numbers, I'll use the previous list
            Func<List<int>, float> getNumbersRMS = (numbersList) => Delegates.RMSFormula(numbersList);
            Console.WriteLine($"The RMS result from the given list is: {getNumbersRMS.Invoke(numbersList)} units\n");

            // 11. Free examples of delegates; Action, Func and Predicate
            Action<string> printFact = (str) => Console.WriteLine($"{str} exists and that's a fact :)\n");
            printFact(disorderedList[4]);

            Func<int, int, int> add = (x, y) => x + y;
            int addResult = add(5, 5);
            Console.WriteLine($"The result of the sum is: {addResult}\n");

            string helloMessage = "hello world";
            Predicate<string> lowerCase = (str) => str.Equals(str.ToLower());
            bool isLowerCase = lowerCase(helloMessage);
            Console.WriteLine($"Is {helloMessage} lower case? result: {isLowerCase}");

            Console.ReadKey();

        }
    }
} 