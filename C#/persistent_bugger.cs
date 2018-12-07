/*
https://www.codewars.com/kata/persistent-bugger/train/csharp

Difficulty: 6 kyu

Write a function, persistence, that takes in a positive parameter num and returns its multiplicative persistence, which is the number of times you must multiply the digits in num until you reach a single digit.

For example:

 persistence(39) == 3 // because 3*9 = 27, 2*7 = 14, 1*4=4
                      // and 4 has only one digit

 persistence(999) == 4 // because 9*9*9 = 729, 7*2*9 = 126,
                       // 1*2*6 = 12, and finally 1*2 = 2

 persistence(4) == 0 // because 4 is already a one-digit number
*/

using System;
using System.Collections.Generic;
using System.Linq;

public class Persist 
{
	public static int Persistence(long n)
	{
        List<char> numbers = new List<char>();
        int oldProduct = 1;
        int newProduct = 1;
        List<char> productList = new List<char>();

        foreach (char num in n.ToString())
        {
            Console.WriteLine("We are in the foreach loop. num = " + num.ToString());
            numbers.Add(num);
            Console.WriteLine("numbers = " + String.Join("", numbers.ToArray()));
            oldProduct *= Int32.Parse(num.ToString());
            Console.WriteLine("oldProduct = " + oldProduct.ToString());
        }
        int counter = 1;

        while (oldProduct > 9)
        {
            Console.WriteLine("\nWe are in the while loop. oldProduct = " + oldProduct.ToString());
            newProduct = oldProduct;
            oldProduct = 1;
            foreach (char number in newProduct.ToString())
            {
                Console.WriteLine(">>> We are in the inner foreach loop. number = " + number.ToString());
                productList.Add(number);
                oldProduct *= Int32.Parse(number.ToString());
                // Console.WriteLine(">>> newProduct = " + newProduct.ToString());
                Console.WriteLine(">>> newProduct = " + newProduct.ToString());
                Console.WriteLine(">>> oldProduct = " + oldProduct.ToString());
                // oldProduct = newProduct;
            }
            counter += 1;
            Console.WriteLine("counter = " + counter.ToString());
        }
        return counter;
	}
}

/**************************************************/
/**************************************************/
/**************************************************/

/*
using System;
using NUnit.Framework;

[TestFixture]
public class PersistTests {

[Test]
  public void Test1() {
    Console.WriteLine("****** Basic Tests");    
    Assert.AreEqual(3, Persist.Persistence(39));
    Assert.AreEqual(0, Persist.Persistence(4));
    Assert.AreEqual(2, Persist.Persistence(25));
    Assert.AreEqual(4, Persist.Persistence(999));
  }
}
*/