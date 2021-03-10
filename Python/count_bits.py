"""
Write a program to count the number of bits that are set to 1 in a nonnegative integer.

Elements of Programming Interviews in Python, Chapter 4 - Primitive Types, Page 25
"""

def count_bits(x):
    num_bits = 0
    while x:
        num_bits += x & 1
        x >>= 1
    return num_bits


if __name__ == '__main__':
    assert count_bits(13) == 3
    assert count_bits(133) == 3
    assert count_bits(98) == 3
