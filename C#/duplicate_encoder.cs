/*
https://www.codewars.com/kata/duplicate-encoder/train/csharp

Difficulty: 6 kyu

The goal of this exercise is to convert a string to a new string where each character in the new string is '(' if that character appears only once in the original string, or ')' if that character appears more than once in the original string. Ignore capitalization when determining if a character is a duplicate.

Examples:

"din" => "((("

"recede" => "()()()"

"Success" => ")())())"

"(( @" => "))(("


Notes:

Assertion messages may be unclear about what they display in some languages. If you read "...It Should encode XXX", the "XXX" is actually the expected result, not the input! (these languages are locked so that's not possible to correct it).
*/

using System;
using System.Collections;
using System.Collections.Generic;
public class Kata
{
    public static string DuplicateEncode(string word)
    {
        // add each letter in word to letters List
        List<char> letters = new List<char>();
        foreach (char letter in word)
        {
            letters.Add(Char.ToLower(letter));
        }

        // Hashtable mapping each character to the number of times it occurs in word
        Hashtable letterFreq = new Hashtable();

        // loop over letters
        foreach (char letter in letters)
        {
            // create a new (character, frequency) key, value pair for each letter in letters         
            // if the key already exists, increment the frequency
            if (letterFreq.ContainsKey(letter))
            {
                int letFreq = (int)letterFreq[letter];
                letterFreq[letter] = letFreq + 1;
            }
            else
            {
                letterFreq.Add(letter, (int)1);
            }
        }

        // encodedLetters
        List<char> encodedLetters = new List<char>();

        // loop over letters
        foreach (char letter in letters)
        {
            // check letterFreq for frequency of each letter
            // if frequency is 1, replace that letter in letters with '('
            // else replace letter with ')'
            if ((int)letterFreq[letter] == 1)
            {
                encodedLetters.Add('(');
            }
            else
            {
                encodedLetters.Add(')');
            }
        }
        return string.Join("", encodedLetters.ToArray());
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
    public class KataTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("(((", Kata.DuplicateEncode("din"));
            Assert.AreEqual("()()()", Kata.DuplicateEncode("recede"));
            Assert.AreEqual(")())())", Kata.DuplicateEncode("Success"), "should ignore case");
            Assert.AreEqual("))((", Kata.DuplicateEncode("(( @"));
        }
    }
}
*/