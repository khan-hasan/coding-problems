/*
https://www.codewars.com/kata/shortest-word/train/csharp

Difficulty: 7 kyu

Simple, given a string of words, return the length of the shortest word(s).

String will never be empty and you do not need to account for different data types.
*/

public class Kata
{
  public static int FindShort(string s)
  {
    string[] words = s.Split(" ");
    string shortest = words[0];

    foreach (string word in words)
    {
        if (word.Length < shortest.Length)
        {
            shortest = word;
        } 
    }
    return shortest.Length;
  }
}

/**************************************************/
/**************************************************/
/**************************************************/

namespace Solution 
{
  using NUnit.Framework;
  using System;  

  [TestFixture]
  public class KataTests
  {
    [Test]
    public void BasicTests()
    {
      Assert.AreEqual(3, Kata.FindShort("bitcoin take over the world maybe who knows perhaps"));
      Assert.AreEqual(3, Kata.FindShort("turns out random test cases are easier than writing out basic ones"));      
    }
  }
}