/*
https://www.codewars.com/kata/simple-fun-number-79-delete-a-digit/train/csharp

Difficulty: 6 kyu

Task
Given an integer n, find the maximal number you can obtain by deleting exactly one digit of the given number.

Example
For n = 152, the output should be 52;

For n = 1001, the output should be 101.

Input/Output
[input] integer n

Constraints: 10 ≤ n ≤ 1000000.

[output] an integer
PUZZLESGAMES
*/

namespace myjinxin
{
    using System;
    using System.Collections.Generic;

    public class Kata
    {
        public int DeleteDigit(int n)
        {
            // convert n from int to string
            string number = n.ToString();
            // create array or list of string
            List<string> num1 = new List<string> {};
            // loop over each char in n
            for (int i = 0; i < number.Length - 1; i++)
            {
                // create new temp str consisting of all char in str except for char at index
                string tempStr = number.Remove(i, 1);            
                // add each temp str to array or list
                num1.Add(tempStr);
            }
            // create a second array or list of int
            List<int> num2 = new List<int> {};
            // loop over first array / list and convert each string element to int and add it to second array / list
            foreach (string num in num1)
            {
                num2.Add(Int32.Parse(num));   
            }
            // return largest int from second array / list
            return num2.Sort().Reverse()[0];
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
        public void BasicTests()
        {
            var kata=new Kata();

            Assert.AreEqual(52,kata.DeleteDigit(152));
            
            Assert.AreEqual(101,kata.DeleteDigit(1001));
            
            Assert.AreEqual(1,kata.DeleteDigit(10));
        }
    }
}
*/