/*
https://www.codewars.com/kata/mumbling/train/csharp

This time no story, no theory. The examples below show you how to write function accum:

Examples:

Accumul.Accum("abcd");    // "A-Bb-Ccc-Dddd"
Accumul.Accum("RqaEzty"); // "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
Accumul.Accum("cwAt");    // "C-Ww-Aaa-Tttt"
The parameter of accum is a string which includes only letters from a..z and A..Z.
*/

using System;
using System.Linq;

public class Accumul 
{
    public static String Accum(string s) 
    {
        string returnString = "";
        for (int i = 0; i < s.Length; i++)
        {
            string capitalizedChar = s[i].ToString().ToUpper();
            returnString += capitalizedChar + String.Concat(Enumerable.Repeat(s[i].ToString().ToLower(), i)) + "-"; 

        }
        return returnString.Trim('-');
    }
}

/**************************************************/
/**************************************************/
/**************************************************/

using System;
using NUnit.Framework;

[TestFixture]
public static class AccumulTests 
{

    private static void testing(string actual, string expected) 
    {
        Assert.AreEqual(expected, actual);
    }

[Test]
    public static void test1() 
    {
        testing(Accumul.Accum("ZpglnRxqenU"), "Z-Pp-Ggg-Llll-Nnnnn-Rrrrrr-Xxxxxxx-Qqqqqqqq-Eeeeeeeee-Nnnnnnnnnn-Uuuuuuuuuuu");
        testing(Accumul.Accum("NyffsGeyylB"), "N-Yy-Fff-Ffff-Sssss-Gggggg-Eeeeeee-Yyyyyyyy-Yyyyyyyyy-Llllllllll-Bbbbbbbbbbb");
        testing(Accumul.Accum("MjtkuBovqrU"), "M-Jj-Ttt-Kkkk-Uuuuu-Bbbbbb-Ooooooo-Vvvvvvvv-Qqqqqqqqq-Rrrrrrrrrr-Uuuuuuuuuuu");
        testing(Accumul.Accum("EvidjUnokmM"), "E-Vv-Iii-Dddd-Jjjjj-Uuuuuu-Nnnnnnn-Oooooooo-Kkkkkkkkk-Mmmmmmmmmm-Mmmmmmmmmmm");
        testing(Accumul.Accum("HbideVbxncC"), "H-Bb-Iii-Dddd-Eeeee-Vvvvvv-Bbbbbbb-Xxxxxxxx-Nnnnnnnnn-Cccccccccc-Ccccccccccc");
    }
}