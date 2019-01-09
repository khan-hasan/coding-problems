/*
https://www.codewars.com/kata/find-the-odd-int/train/csharp

Difficulty: 6 kyu

Given an array, find the int that appears an odd number of times.

There will always be only one integer that appears an odd number of times.

FUNDAMENTALS
*/

using System.Collections.Generic;

namespace Solution
{
    class Kata
    {
        public static int find_it(int[] seq) 
        {
            int oddFreqNum = 0;

            Dictionary<int, int> freq = new Dictionary<int, int>();
            foreach (int num in seq)
            {
                if (!freq.ContainsKey(num))
                {
                    freq.Add(num, 1);

                }
                else
                {
                    freq[num] += 1;
                }
            }

            foreach (var keyValuePair in freq)
            {
                if(keyValuePair.Value % 2 != 0)
                {
                    oddFreqNum = keyValuePair.Key;
                    break;
                }
            }
            
            return oddFreqNum;
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
        public void Tests()
        {
            Assert.AreEqual(5 , Kata.find_it ( new[] { 20,1,-1,2,-2,3,3,5,5,1,2,4,20,4,-1,-2,5 }));
        }
    }
}
*/