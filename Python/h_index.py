"""
The h-index is a metric that measures both the productivity and citation impact of a researcher. Specifically, a
researcher's h-index is the largest number h such that the researcher has published h papers that have each been cited
at least h times. For example, if Carl has published papers A,B,C,D,E,F,G,H,I, which have been cited 1,4,1,4,2,1,3,5,6
times, respectively, then his h-index is 4 (corresponding to the papers B,D,H,I).

Suppose you were asked to design an algorithm that determines a researcher's h-index.

Elements of Programming Interviews in Python, Introduction, Page 1
"""


def find_h_index(arr):
    arr = sorted(arr)
    for i in range(len(arr)):
        h_index = arr[i]
        if i == len(arr) - h_index:
            return h_index


if __name__ == '__main__':
    assert find_h_index([1, 4, 1, 4, 2, 1, 3, 5, 6]) == 4
