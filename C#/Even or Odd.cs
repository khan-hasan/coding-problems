/*
 * https:\//www.codewars.com/kata/even-or-odd/train/csharp
 * 
 * Create a function (or write a script in Shell) that takes an integer as an argument and returns "Even" for even numbers or "Odd" for odd numbers.
 */

//contains fundamental classes and base clases
using System;

//provides a way to keep one set of names separate from another - class names declared do not conflict with same class names in another namespace
namespace Solution
{
    public class SolutionClass
    {
        public static string EvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }
        }
    }
}