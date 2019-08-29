'''
https://www.codewars.com/kata/snail/train/python

Difficulty: 4 kyu

Snail Sort
Given an n x n array, return the array elements arranged from outermost elements to
the middle element, traveling clockwise.

array = [[1,2,3],
         [4,5,6],
         [7,8,9]]
snail(array) #=> [1,2,3,6,9,8,7,4,5]
For better understanding, please follow the numbers of the next array consecutively:

array = [[1,2,3],
         [8,9,4],
         [7,6,5]]
snail(array) #=> [1,2,3,4,5,6,7,8,9]
This image will illustrate things more clearly:

NOTE: The idea is not sort the elements from the lowest value to the highest; the idea
is to traverse the 2-d array in a clockwise snailshell pattern.

NOTE 2: The 0x0 (empty matrix) is represented as [[]]

ALGORITHMS, ARRAYS
'''

def snail(array):
    """
    Sort an n x n array with elements arranged from outermost elements to the middle element,
    traveling clockwise.

    :param array: a list of lists representing the n x n array
    :type array: list of lists

    :returns: a list with the elements of `array` arranged from outermost elements to the
    middle element, traveling clockwise
    :rtype: list
    """

    array_len = len(array)
    sorted_array = []

    #  Start traversing from the top-right corner of `array`.
    i = 0
    j = array_len - 1

    # Sequence of consecutive places to move after making a clockwise turn
    dist_to_travel = sorted([dist for dist in range(1, array_len)] * 2, reverse=True)

    direction_to_travel = ['D', 'L', 'U', 'R']
    idx = 0

    if not array[0]:
        # If `array` has no elements, return an empty matrix.
        return []

    if len(array[0]) == 1:
        # If array has 1 element, return `array`.
        return [array[0][0]]

    # Traverse the first row in `array`.
    for k in range(array_len):
        sorted_array.append(array[0][k])

    for dist in dist_to_travel:

        # Reset index to beginning if at the end of `direction_to_travel`.
        if idx == 4:
            idx = 0

        # Move `dist` units in the specified `direction_to_travel`.
        for _ in range(dist):

            direction = direction_to_travel[idx]
            if direction == 'D':
                i += 1
            elif direction == 'L':
                j -= 1
            elif direction == 'U':
                i -= 1
            else:
                j += 1

            current_element = array[i][j]
            sorted_array.append(current_element)

        # Make clockwise turn around a corner.
        idx += 1

    return sorted_array
