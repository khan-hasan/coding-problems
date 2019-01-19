/*
https://www.codewars.com/kata/iq-test/csharp

Difficulty: 6 kyu

Bob is preparing to pass IQ test. The most frequent task in this test is to find out which one of the given numbers differs from the others. Bob observed that one number usually differs from the others in evenness. Help Bob — to check his answers, he needs a program that among the given numbers finds one that is different in evenness, and return a position of this number.

! Keep in mind that your task is to help Bob solve a real IQ test, which means indexes of the elements start from 1 (not 0)

##Examples :

IQ.Test("2 4 7 8 10") => 3 // Third number is odd, while the rest of the numbers are even

IQ.Test("1 2 1 1") => 2 // Second number is even, while the rest of the numbers are odd
FUNDAMENTALS
*/

using System;
using System.Linq;

public class IQ
{
    public static int Test(string numbers)
    { 
        var nums = numbers.Split(" ");
        var positive = 0;
        var negative = 0;     

        foreach (var num in nums)
        {
            if (Int32.Parse(num) % 2 == 0)
                positive += 1;
            else
                negative += 1;
        }

        if (positive > negative)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                if (Int32.Parse(nums[i]) % 2 != 0)
                    return i + 1;
            }
        }
        else
        {
            for (var i = 0; i < nums.Length; i++)
            {
                if (Int32.Parse(nums[i]) % 2 == 0)
                    return i + 1;
            }
        }
        return 0;
    }
}

/**************************************************/
/**************************************************/
/**************************************************/

/*
using NUnit.Framework;
using System;

[TestFixture]
public class IQTests
{ 
    [Test]
    public void Test1()
    {
        Assert.AreEqual(3, IQ.Test("2 4 7 8 10"));
    }

    [Test]
    public void Test2()
    {
        Assert.AreEqual(1, IQ.Test("1 2 2"));
    }
}
*/