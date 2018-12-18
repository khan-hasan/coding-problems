/*
https://www.codewars.com/kata/roman-numerals-decoder/train/csharp

Difficulty: 6 kyu

Create a function that takes a Roman numeral as its argument and returns its value as a numeric decimal integer. You don't need to validate the form of the Roman numeral.

Modern Roman numerals are written by expressing each decimal digit of the number to be encoded separately, starting with the leftmost digit and skipping any 0s. So 1990 is rendered "MCMXC" (1000 = M, 900 = CM, 90 = XC) and 2008 is rendered "MMVIII" (2000 = MM, 8 = VIII). The Roman numeral for 1666, "MDCLXVI", uses each letter in descending order.

Example:

RomanDecode.Solution("XXI") -- should return 21
Help:

Symbol    Value
I          1
V          5
X          10
L          50
C          100
D          500
M          1,000
Courtesy of rosettacode.org
*/

using System;
using System.Collections;
using System.Collections.Generic;

public class RomanDecode
{
    public static int Solution(string roman)
    {
        // Hashtable representing the numeric value of each roman numeral key
        Hashtable romanKeys = new Hashtable() {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        // If roman is one numeral, return numeric value
        if (roman.Length == 1)
        {
            return (int)romanKeys[roman.ToCharArray()[0]];

        }
        else
        {
            // Array of chars in roman in reverse order
            char[] romanChars = roman.ToCharArray();
            Array.Reverse(romanChars);

            // Numeric value of roman
            int total = 0;

            // Loop over each numeral in romanChars
            for (int i = 0; i < romanChars.Length; i++)
            {
                Console.WriteLine("\nWe are now inside the for loop, and i = " + i.ToString() + ".");

                // If the numeral at the following index is less than the current numeral, subtract them, and add result to total
                if ((int)romanKeys[romanChars[i + 1]] < (int)romanKeys[romanChars[i]])
                {
                    Console.WriteLine("We are inside the if statement.");
                    total =+ ((int)romanKeys[romanChars[i]] - (int)romanKeys[romanChars[i + 1]]);
                    Console.WriteLine("total = " + total.ToString());
                    i += 1;
                }
                else
                {
                    Console.WriteLine("We are inside the else statement.");
                    total += ((int)romanKeys[romanChars[i]]);
                    Console.WriteLine("total = " + total.ToString());
                }
            }
            return total;
        }
        throw new NotImplementedException();
    }
}

/**************************************************/
/**************************************************/
/**************************************************/

/*
using System;
using NUnit.Framework;

[TestFixture]
public class RomanDecodeTests
{
    [TestCase(1, "I")]
	public void Test(int expected, string roman)
	{
		Assert.AreEqual(expected, RomanDecode.Solution(roman));
	}
}
*/