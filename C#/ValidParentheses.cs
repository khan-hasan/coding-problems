/*
https://www.codewars.com/kata/valid-parentheses/train/csharp

Difficulty: 5 kyu

Write a function called ValidParentheses() that takes a string of parentheses, and determines if the order of the parentheses is valid. The function should return true if the string is valid, and false if it's invalid.

Examples
"()"              =>  true
")(()))"          =>  false
"("               =>  false
"(())((()())())"  =>  true
Constraints
0 <= input.length <= 100

Along with opening (() and closing ()) parenthesis, input may contain any valid ASCII characters. Furthermore, the input string may be empty and/or not contain any parentheses at all. Do not treat other forms of brackets as parentheses (e.g. [], {}, <>).

ALGORITHMS, VALIDATION, UTILITIES
*/

using System.Collections.Generic;

public class Parentheses
{
    public static bool ValidParentheses(string input)
    {
        var inputStr = new List<char>();
        foreach (var letter in input)
        {
            inputStr.Add(letter);
        }
        var modifiedInputStr = string.Join("", inputStr.ToArray());

        while (inputStr.Count > 2)
        {
        }

        if (modifiedInputStr == "()")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

/**************************************************/
/**************************************************/
/**************************************************/

/*
namespace Solution 
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void SampleTest1()
        {
            Assert.AreEqual(true, Parentheses.ValidParentheses( "()" ));
        }
    
        [Test]
        public void SampleTest2()
        {
            Assert.AreEqual(false, Parentheses.ValidParentheses( ")((((" ));
        }

        [Test]
        public void SampleTest3()
        {
            Assert.AreEqual(true, Parentheses.ValidParentheses( "(())((()())())" ));
        }

        [Test]
        public void SampleTest4()
        {
            Assert.AreEqual(false, Parentheses.ValidParentheses( "jajskf" ));
        }
    }
}
*/