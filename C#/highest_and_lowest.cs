/*
https://www.codewars.com/kata/highest-and-lowest/train/csharp

Difficulty: 7 kyu

In this little assignment you are given a string of space separated numbers, and have to return the highest and lowest number.

Example:

Kata.HighAndLow("1 2 3 4 5"); // return "5 1"
Kata.HighAndLow("1 2 -3 4 5"); // return "5 -3"
Kata.HighAndLow("1 9 3 4 -5"); // return "9 -5"
Notes:

All numbers are valid Int32, no need to validate them.
There will always be at least one number in the input string.
Output string must be two numbers separated by a single space, and highest number is first.
*/

using System;
using System.Linq;
using System.Collections.Generic;

public static class Kata
{
  public static string HighAndLow(string numbers)
  {

    if (numbers.Length == 1)
    {
      return numbers.ToString();
    }

    int highest, lowest;
    string[] numbersArr = numbers.Split(" ");
    
    if (Int32.Parse(numbersArr[0]) > Int32.Parse(numbersArr[1]))
    {
        highest = Int32.Parse(numbersArr[0]);
        lowest = Int32.Parse(numbersArr[1]);
    }
    else
    {
        lowest = Int32.Parse(numbersArr[0]);
        highest = Int32.Parse(numbersArr[1]);
    }

    foreach (string num in numbersArr)
    {
      if (Int32.Parse(num) > highest)
      {
        highest = Int32.Parse(num);
      }
      if (Int32.Parse(num) < lowest)
      {
        lowest = Int32.Parse(num);
      }
    }

    string returnString = highest.ToString() + " " + lowest.ToString();
    return returnString;
  }
}

/**************************************************/
/**************************************************/
/**************************************************/

//using NUnit.Framework;

[TestFixture]
public class Tests
{
  [Test]
  public void Test1()
  {
    Assert.AreEqual("42 -9", Kata.HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
  }
}