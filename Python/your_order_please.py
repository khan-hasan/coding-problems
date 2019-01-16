'''
https://www.codewars.com/kata/your-order-please/train/python

Difficulty: 6 kyu

Your task is to sort a given string. Each word in the string will contain a single number. This number is the position the word should have in the result.

Note: Numbers can be from 1 to 9. So 1 will be the first word (not 0).

If the input string is empty, return an empty string. The words in the input String will only contain valid consecutive numbers.

Examples
"is2 Thi1s T4est 3a"  -->  "Thi1s is2 3a T4est"
"4of Fo1r pe6ople g3ood th5e the2"  -->  "Fo1r the2 g3ood 4of th5e pe6ople"
""  -->  ""

FUNDAMENTALS, STRINGS
'''

def order(sentence):
    if not sentence:
        return ''
    words = sentence.split(' ')
    ordered_words = []

    for i in range(0, len(words) + 1):
        for word in words:
            if str(i) in word:
                ordered_words.append(word)

    ordered_sentence = ' '.join(ordered_words)
    return ordered_sentence

###################################################
###################################################
###################################################

'''
Test.assert_equals(order("is2 Thi1s T4est 3a"), "Thi1s is2 3a T4est")
Test.assert_equals(order("4of Fo1r pe6ople g3ood th5e the2"), "Fo1r the2 g3ood 4of th5e pe6ople")
Test.assert_equals(order(""), "")
'''