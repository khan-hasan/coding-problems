/*
https://www.codewars.com/kata/string-repeat/train/csharp

Write a function called repeatStr which repeats the given string string exactly n times.

repeatStr(6, "I") // "IIIIII"
repeatStr(5, "Hello") // "HelloHelloHelloHelloHello"
*/

using System.Linq;

namespace Solution
{
  public static class Program
  {
    public static string repeatStr(int n, string s)
    {
      return string.Join("", Enumerable.Repeat(s, n));
    }
  }
}