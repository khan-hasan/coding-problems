"""
Right propogate the rightmost set bit in x, e.g., turns 01010000 to 01011111.

Elements of Programming Interviews in Python, Chapter 4 - Primitive Types, Page 29
"""


def right_propogate(x):
    return x | x - 1


if __name__ == '__main__':
    assert right_propogate(80) == 95
