'''
https://www.codewars.com/kata/simple-pig-latin/train/python

Difficulty: 5 kyu

Move the first letter of each word to the end of it, then add "ay" to the end of the word. Leave punctuation marks untouched.

Examples
pig_it('Pig latin is cool') # igPay atinlay siay oolcay
pig_it('Hello world !')     # elloHay orldway !

ALGORITHMS
'''

def pig_it(text):
    scrambled_words = ""
    for word in text.split():
        if word in ['!', '?']:
            scrambled_word = word + " "
        elif len(word) == 1:
            scrambled_word = word + "ay "
        else:
            scrambled_word = word[1:] + word[0] + "ay "
        scrambled_words += scrambled_word
    return scrambled_words[:-1]

###################################################
###################################################
###################################################

'''
Test.assert_equals(pig_it('Pig latin is cool'),'igPay atinlay siay oolcay')
Test.assert_equals(pig_it('This is my string'),'hisTay siay ymay tringsay')
'''