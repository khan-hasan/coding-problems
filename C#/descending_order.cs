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

public static class Kata
{
  public static int DescendingOrder(int num)
  {
    // Bust a move right here
    return 0;
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
    Assert.AreEqual(0, Kata.DescendingOrder(0));
  }  
}