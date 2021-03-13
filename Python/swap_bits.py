"""
A 64-bit integer can be viewed as an array of 64 bits, with the bit at index 0 corresponding to the least significant
bit (LSB), and the bit at index 63 corresponding to the most significant bit (MSB). Implement code that takes as input
a 64-bit integer and swaps the bits at indices i and j.

Elements of Programming Interviews in Python, Primitive Types, Page 29
"""


def check_bit_at_index(x, idx):
    if ~1 | (x>>idx) == ~-1 - 1:
        return 0
    return 1


def swap_bits(x, i, j):
    if check_bit_at_index(x, i) != check_bit_at_index(x, j):
        x ^= 2**i + 2**j

    return x


if __name__ == '__main__':
    assert swap_bits(73, 2, 6) == 13
    assert swap_bits(784, 4, 2) == 772
    assert swap_bits(12757116, 5, 8) == 12757340
