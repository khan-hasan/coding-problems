/*
https://www.codewars.com/kata/simple-fun-number-23-square-digits-sequence/train/csharp

Difficulty: 6 kyu

Task:
Consider a sequence of numbers a0, a1, ..., an, in which an element is equal to the sum of squared digits of the previous element. The sequence ends once an element that has already been in the sequence appears again.

Given the first element a0, find the length of the sequence.

Example:
For a0 = 16, the output should be 9

Here's how elements of the sequence are constructed:

a0 = 16

a1 = 12 + 62 = 37

a2 = 32 + 72 = 58

a3 = 52 + 82 = 89

a4 = 82 + 92 = 145

a5 = 12 + 42 + 52 = 42

a6 = 42 + 22 = 20

a7 = 22 + 02 = 4

a8 = 42 = 16, which has already occurred before (a0)

Thus, there are 9 elements in the sequence.

For a0 = 103, the output should be 4

The sequence goes as follows: 103 -> 10 -> 1 -> 1, 4 elements altogether.

Input/Output:
[input] integer a0

First element of a sequence, positive integer.

Constraints: 1 ≤ a0 ≤ 650.

[output] an integer
*/

namespace myjinxin
{
    using System;
    using System.Collections.Generic;
    
    public class Kata
    {
        public int SquareDigitsSequence(int a0)
        {
            // current sum of a0's squared digits
            int sumOfSquaredDigits = 0;
            foreach (char digit in a0.ToString())
            {
                System.Console.WriteLine(Convert.ToInt32(Math.Pow(digit, 2)));
                sumOfSquaredDigits += Convert.ToInt32(Math.Pow(digit, 2));
            }
            // int sumOfSquaredDigits = Math.Pow(a0.ToString().Split("")[0], 2) + Math.Pow(a0.ToString().Split("")[1], 2);
            System.Console.WriteLine(sumOfSquaredDigits);

            // list containing sequence of all previous sums of a0's successively square digits
            List<int> previousSums = new List<int>();

            // add the sum of a0's squared digits to sumOfSquaredDigits
            previousSums.Add(sumOfSquaredDigits);

            // get the sum of the squared digits of the last number in previous Sums and save in tempSum
            var tempSum = 0;

            // take the last number in previousSums list, and add the sum of its square digits to the end list
            // stop looping when previousSums contains the sum already
            do
            {
                // tempSum = Math.Pow(previousSums[previousSums.Count].ToString().Split()[0], 2) + Math.Pow(previousSums[previousSums.Count].ToString().Split()[1], 2);

                // add tempSum to previousSums list
                previousSums.Add(tempSum);
            // check if previousSums contains tempSum already
            } while (previousSums.Contains(tempSum) == false);

            // return the size of previousSums list
            return previousSums.Count;
        }
    }
}

/**************************************************/
/**************************************************/
/**************************************************/

/*
namespace myjinxin
{
    using NUnit.Framework;
    using System;
    
    [TestFixture]
    public class myjinxin
    {
        
        [Test]
        public void BasicTests(){
            var kata=new Kata();
            
            Assert.AreEqual(9,  kata.SquareDigitsSequence(16));
            
            Assert.AreEqual(4,  kata.SquareDigitsSequence(103));
            
            Assert.AreEqual(2,  kata.SquareDigitsSequence(1));
                        
        }        
    }
}
*/