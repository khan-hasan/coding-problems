'''
https://app.codesignal.com/arcade/intro/level-4/Xfeo7r9SBSpo3Wico/description

Difficulty: Medium

Given a string, find out if its characters can be rearranged to form a palindrome.

Example

For inputString = "aabb", the output should be
palindromeRearranging(inputString) = true.

We can rearrange "aabb" to make "abba", which is a palindrome.

Input/Output

[execution time limit] 4 seconds (py3)

[input] string inputString

A string consisting of lowercase English letters.

Guaranteed constraints:
1 ≤ inputString.length ≤ 50.

[output] boolean

true if the characters of the inputString can be rearranged to form a palindrome, false otherwise.
'''


def palindromeRearranging(inputString):
    # Frequency of each character in string.
    freq = {}
    for char in inputString:
        if char not in freq.keys():
            freq[char] = 1
        else:
            freq[char] += 1

    # Check if there is more than 1 character in string with odd frequency.
    return len([freq for freq in freq.values() if freq % 2 != 0]) <= 1
