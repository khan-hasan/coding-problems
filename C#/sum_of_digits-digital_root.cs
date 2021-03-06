/*
https://www.codewars.com/kata/sum-of-digits-slash-digital-root

Difficulty: 6 kyu

In this kata, you must create a digital root function.

A digital root is the recursive sum of all the digits in a number. Given n, take the sum of the digits of n. If that value has two digits, continue reducing in this way until a single-digit number is produced. This is only applicable to the natural numbers.

Here's how it works:

digital_root(16)
=> 1 + 6
=> 7

digital_root(942)
=> 9 + 4 + 2
=> 15 ...
=> 1 + 5
=> 6

digital_root(132189)
=> 1 + 3 + 2 + 1 + 8 + 9
=> 24 ...
=> 2 + 4
=> 6

digital_root(493193)
=> 4 + 9 + 3 + 1 + 9 + 3
=> 29 ...
=> 2 + 9
=> 11 ...
=> 1 + 1
=> 2
ALGORITHMS, MATHEMATICS, NUMBERS, ARITHMETIC
*/

using System;
using System.Collections.Generic;

public class Number
{
    public int DigitalRoot(long n)
    {
        List<int> digits = new List<int>();

        int sum = 0;

        foreach (char num in n.ToString())
        {
            sum += Int32.Parse(num.ToString());
            digits.Add(Int32.Parse(num.ToString()));
        }

        do
        {
            sum = 0;
            
            foreach (int digit in digits)
            {
                sum += digit;
            }
            digits.Clear();

            foreach (char num in sum.ToString())
            {
                digits.Add(Int32.Parse(num.ToString()));
            }
        } while (digits.Count > 1);
        return sum;  
    }
}

/**************************************************/
/**************************************************/
/**************************************************/

/*
using NUnit.Framework;

[TestFixture]
public class NumberTest
{
  private Number num;
  
  [SetUp]
  public void SetUp() 
  {
    num = new Number();
  }

  [TearDown]
  public void TearDown()
  {
    num = null;
  }

  [Test]
  public void Tests()
  {
    Assert.AreEqual(7, num.DigitalRoot(16));       
    Assert.AreEqual(6, num.DigitalRoot(456)); 
  }
}
*/