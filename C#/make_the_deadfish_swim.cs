/*
https://www.codewars.com/kata/make-the-deadfish-swim/train/csharp

Difficulty: 6 kyu

Write a simple parser that will parse and run Deadfish.

Deadfish has 4 commands, each 1 character long:

i increments the value (initially 0)
d decrements the value
s squares the value
o outputs the value into the return array
Invalid characters should be ignored.

Deadfish.Parse("iiisdoso") => new int[] {8, 64};
*/

using System;
using System.Collections;
using System.Collections.Generic;

public class Deadfish
{
    public static int[] Parse(string data)
    {
        int value = 0;
        List<int> output = new List<int>();

        for (int i = 0; i < data.Length; i++)
        {
            if (data[i] == 'i')
            {
                value += 1;
            }
            else if (data[i] == 'd')
            {
                value -= 1;
            }
            else if (data[i] == 's')
            {
                value *= value;
            }
            else
            {
                output.Add(value);
            }
        }
        return output.ToArray();
    }
}

/**************************************************/
/**************************************************/
/**************************************************/

/*
namespace Solution {
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class SolutionTest
    {
        private static object[] sampleTestCases = new object[]
        {
            new object[] {"iiisdoso", new int[] {8, 64}},
            new object[] {"iiisdosodddddiso", new int[] {8, 64, 3600}},
        };

        [Test, TestCaseSource("sampleTestCases")]
        public void SampleTest(string data, int[] expected)
        {
            Assert.AreEqual(expected, Deadfish.Parse(data));
        }
    }
}
*/