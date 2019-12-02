using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalInterviewPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 12, -13, 15, 227 };
            Console.WriteLine(sumOfOdds(numbers));
            int[] largeNumbers = { 203949578, 919993847, 1394967160 };
            Console.WriteLine(bigSum(largeNumbers));
            Console.WriteLine("Please Enter a Word to be reversed.");
            string userInput = Console.ReadLine();
            Console.WriteLine(reverseMe(userInput));
            Console.WriteLine("I have removed the letters that were repeated in your string for you. " + removeDuplicates(userInput));
            Console.Read();
        }

        private static long bigSum(int[] numbers)
        {
            return numbers.Sum(x => (long)x);
        }

        private static string removeDuplicates(string userInput)
        {
            return string.Join("", userInput.ToLower().Distinct());
        }

        private static int sumOfOdds(int[] numbers)
        {
            return numbers.Where(x => x % 2 != 0).Sum();
        }

        private static string reverseMe(string userInput)
        {
            return string.Join("", userInput.ToArray().Reverse());
        }
    }
}