"""
https://www.codewars.com/kata/twice-linear/train/python

Difficulty: 4 kyu

Consider a sequence u where u is defined as follows:

The number u(0) = 1 is the first one in u.
For each x in u, then y = 2 * x + 1 and z = 3 * x + 1 must be in u too.
There are no other numbers in u.
Ex: u = [1, 3, 4, 7, 9, 10, 13, 15, 19, 21, 22, 27, ...]

1 gives 3 and 4, then 3 gives 7 and 10, 4 gives 9 and 13, then 7 gives 15 and 22 and so on...

Task:
Given parameter n the function dbl_linear (or dblLinear...) returns the element u(n) of the
ordered (with <) sequence u (so, there are no duplicates).

Example:
dbl_linear(10) should return 22

Note:
Focus attention on efficiency

ALGORITHMS, NUMBERS, MATHEMATICS
"""

def dbl_linear(n):
    """
    Return element u(n) of sequence u = 
    [1, 3, 4, 7, 9, 10, 13, 15, 19, 21, 22, 27, ...]
    """

    u = [1]

    for i in range(n):
        for j in [2, 3]:
            next_elem = u[i] * j + 1
            if next_elem not in u:
                u.append(next_elem)

    return(sorted(u)[n])
