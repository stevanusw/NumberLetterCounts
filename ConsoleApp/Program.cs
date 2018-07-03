using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Libraries;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberLetterCounts = new NumberLetterCounts();

            for (var i = 1; i <= 1000; i++)
            {
                var numberToLetters = numberLetterCounts.ToString(i);
                var letterCounts = Regex.Replace(numberToLetters, @"[\s-]", "");

                Console.WriteLine(i + " is " + numberToLetters + " has " + letterCounts.Count() + " letters.");
            }
            
            Console.Read();
        }
    }
}
