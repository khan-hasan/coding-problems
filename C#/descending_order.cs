/*
https://www.codewars.com/kata/descending-order/train/csharp

Difficulty: 7 kyu

Your task is to make a function that can take any non-negative integer as a argument and return it with its digits in descending order. Essentially, rearrange the digits to create the highest possible number.

Examples:
Input: 21445 Output: 54421

Input: 145263 Output: 654321

Input: 1254859723 Output: 9875543221
*/

using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
    public static int DescendingOrder(int num)
    {
        char[] numCharArr = num.ToString().ToCharArray();
        var numIntList = new List<int>();
        string returnStr = "";

        foreach (char numChar in numCharArr)
        {
            numIntList.Add(Int32.Parse(numChar.ToString()));
        }

        do
        {
            returnStr += numIntList.Max().ToString();
            numIntList.Remove(numIntList.Max());

        } while (numIntList.Count > 0);

        return Int32.Parse(returnStr);
    }
}

/**************************************************/
/**************************************************/
/**************************************************/

// using NUnit.Framework;

[TestFixture]
public class Tests
{
  [Test]
  public void Test0()
  {
    Assert.AreEqual(1223455789, Kata.DescendingOrder(1254859723));
  }  
}