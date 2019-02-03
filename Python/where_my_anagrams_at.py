'''
https://www.codewars.com/kata/where-my-anagrams-at/python

Difficulty: 5 kyu

What is an anagram? Well, two words are anagrams of each other if they both contain the same letters. For example:

'abba' & 'baab' == true

'abba' & 'bbaa' == true

'abba' & 'abbba' == false

'abba' & 'abca' == false
Write a function that will find all the anagrams of a word from a list. You will be given two inputs a word and an array with words. You should return an array of all the anagrams or an empty array if there are none. For example:

anagrams('abba', ['aabb', 'abcd', 'bbaa', 'dada']) => ['aabb', 'bbaa']

anagrams('racer', ['crazer', 'carer', 'racar', 'caers', 'racer']) => ['carer', 'racer']

anagrams('laser', ['lazing', 'lazy',  'lacer']) => []

ALGORITHMS, STRINGS
'''


def anagrams(word, words):
    anagram_words = []
    for wrd in words:
        letters = all_letters(word)
        loop_again = True
        while loop_again:
            for letter in wrd:
                if letter not in letters:
                    loop_again = False
                    break
                elif letter in letters:
                    if letters[letter] > 0:
                        letters[letter] -= 1
                    else:
                        loop_again = False
                        break
            if not loop_again:
                break
            if wrd not in anagram_words and len(wrd) == len(word):
                anagram_words.append(wrd)
    return anagram_words


def all_letters(input_word):
    letters_dict = dict()
    for letter in input_word:
        if letter in letters_dict:
            letters_dict[letter] += 1
        else:
            letters_dict[letter] = 1
    return letters_dict


'''
Test.assert_equals(anagrams('abba', ['aabb', 'abcd', 'bbaa', 'dada']), ['aabb', 'bbaa'])
Test.assert_equals(anagrams('racer', ['crazer', 'carer', 'racar', 'caers', 'racer']), ['carer', 'racer'])
'''
