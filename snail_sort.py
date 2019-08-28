'''
https://www.codewars.com/kata/snail/train/python

Difficulty: 4 kyu

Snail Sort
Given an n x n array, return the array elements arranged from outermost elements to the middle element, traveling clockwise.

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

NOTE: The idea is not sort the elements from the lowest value to the highest; the idea is to traverse the 2-d array in a clockwise snailshell pattern.

NOTE 2: The 0x0 (empty matrix) is represented as [[]]

ALGORITHMS, ARRAYS
'''

def snail(array):
    """
    Sort an n x n array with elements arranged from outermost elements to the middle element, traveling clockwise.

    :param array: a list of lists representing the n x n array
    :type array: list of lists

    :returns: a list with the elements of `array` arranged from outermost elements to the middle element, traveling clockwise
    :rtype: list
    """

    n = len(array)
    sorted_array = []

    # Row index
    i = 0
    # Column index. Start traversing from the top-right corner of `array`.
    j = n - 1

    consec_same_dist = 0

    dist_to_travel = n - 1

    direction_to_travel = ['D', 'L', 'U', 'R']
    idx = 0

    if len(array[0]) == 0:
        # If `array` has no elements, return an empty matrix.
        return [[]]

    elif len(array[0]) == 1:
        # If array has 1 element, return `array`.
        return [array[0][0]]

    # Traverse the first row in `array`.
    for k in range(n):
        sorted_array.append(array[0][k])
    
    import pdb; pdb.set_trace()
    while len(sorted_array) < n**2:

        direction = direction_to_travel[idx]

        for _ in range(dist_to_travel):

            if direction == 'R':
                j += 1
            elif direction == 'D':
                i += 1
            elif direction == 'L':
                j -= 1
            else:
                i -= 1

            next_element = array[i][j]
            sorted_array.append(next_element)
        
        # Cycle through the directions in clockwise order.
        if idx == 3:
            idx = 0
        else:
            idx += 1

        if consec_same_dist == 2:
            consec_same_dist = 0
            dist_to_travel -= 1
        else:
            consec_same_dist += 1
        
    return sorted_array


array = [[1,2,3,1],
         [4,5,6,4],
         [7,8,9,7],
         [7,8,9,7]]

# array = [[1]]
print(snail(array))
print(f'expected =\n[1, 2, 3, 1, 4, 7, 7, 9, 8, 7, 7, 4, 5, 6, 9, 8]')
