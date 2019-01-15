'''
https://www.codewars.com/kata/square-every-digit/train/python

Difficulty: 7 kyu

Welcome. In this kata, you are asked to square every digit of a number.

For example, if we run 9119 through the function, 811181 will come out, because 9^2 is 81 and 1^2 is 1.

Note: The function accepts an integer and returns an integer

FUNDAMENTALS, MATHEMATICS, ALGORITHMS, NUMBERS
'''

def square_digits(num):
    n = str(num)
    squared_num = ""

    for numb in n:
        squared_num += str(int(numb)**2)
    
    return int(squared_num)

###################################################
###################################################
###################################################

'''
# test.assert_equals(square_digits(9119), 811181)
'''