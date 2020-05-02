"""
https://leetcode.com/problems/add-binary/

Easy

Given two binary strings, return their sum (also a binary string).

The input strings are both non-empty and contains only characters 1 or 0.

Example 1:

Input: a = "11", b = "1"
Output: "100"
Example 2:

Input: a = "1010", b = "1011"
Output: "10101"
 

Constraints:

Each string consists only of '0' or '1' characters.
1 <= a.length, b.length <= 10^4
Each string is either "0" or doesn't contain any leading zero.
"""


class Solution:
    def addBinary(self, a: str, b: str) -> str:

        carry = 0
        result = ''

        for i in range(-1, -max(len(a), len(b)) - 1, -1):

            try:
                a_bit = int(a[i])
            except IndexError:
                a_bit = 0

            try:
                b_bit = int(b[i])
            except IndexError:
                b_bit = 0


            sum_bits = a_bit + b_bit + carry
            if sum_bits == 0:
                result = '0' + result
                carry = 0
            elif sum_bits == 1:
                result = '1' + result
                carry = 0
            elif sum_bits == 2:
                result = '0' + result
                carry = 1
            elif sum_bits == 3:
                result = '1' + result
                carry = 1

        if carry:
            result = '1' + result

        return result
