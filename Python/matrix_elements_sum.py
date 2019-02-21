"""
https://app.codesignal.com/arcade/intro/level-2/xskq4ZxLyqQMCLshr

Difficulty: Easy

After they became famous, the CodeBots all decided to move to a new building and live together. The building is represented by a rectangular matrix of rooms. Each cell in the matrix contains an integer that represents the price of the room. Some rooms are free (their cost is 0), but that's probably because they are haunted, so all the bots are afraid of them. That is why any room that is free or is located anywhere below a free room in the same column is not considered suitable for the bots to live in.

Help the bots calculate the total price of all the rooms that are suitable for them.

Example

For
matrix = [[0, 1, 1, 2],
          [0, 5, 0, 0],
          [2, 0, 3, 3]]
the output should be
matrixElementsSum(matrix) = 9.

Here's the rooms matrix with unsuitable rooms marked with 'x':

[[x, 1, 1, 2],
 [x, 5, x, x],
 [x, x, x, x]]
Thus, the answer is 1 + 5 + 1 + 2 = 9.

For
matrix = [[1, 1, 1, 0],
          [0, 5, 0, 1],
          [2, 1, 3, 10]]
the output should be
matrixElementsSum(matrix) = 9.

Here's the rooms matrix with unsuitable rooms marked with 'x':

[[1, 1, 1, x],
 [x, 5, x, x],
 [x, 1, x, x]]
Note that the free room in the first row make the full column unsuitable for
bots.

Thus, the answer is 1 + 1 + 1 + 5 + 1 = 9.

Input/Output

[execution time limit] 4 seconds (py3)

[input] array.array.integer matrix

A 2-dimensional array of integers representing a rectangular matrix of the
building.

Guaranteed constraints:
1 ≤ matrix.length ≤ 5,
1 ≤ matrix[i].length ≤ 5,
0 ≤ matrix[i][j] ≤ 10.

[output] integer

The total price of all the rooms that are suitable for the CodeBots to live in.

Codewriting
"""


def matrixElementsSum(matrix):
    """
    Get sum of all elements in matrix while
    ignoring all elements beneath 0s.
    """
    matrix_copy = matrix.copy()
    total = 0
    # Loop over rows.
    for row in matrix:
        # Loop over columns.
        for column_index in range(len(row)):
            if row[column_index] == 0:
                # Replace all 0s in matrix under current 0 to 0s.
                for i in range(matrix.index(row), len(matrix)):
                    matrix_copy[i][column_index] = 0
    # Find sum of all remaining numbers in matrix.
    for row_copy in matrix_copy:
        total += sum(row_copy)
    return total


"""matrix = [[0, 1, 1, 2],
          [0, 5, 0, 0],
          [2, 0, 3, 3]]
print(matrixElementsSum(matrix))
"""
