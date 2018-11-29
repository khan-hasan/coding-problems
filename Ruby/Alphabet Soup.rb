# Difficulty: Easy
# Tags: string manipulation, sorting
# https://coderbyte.com/editor/Alphabet%20Soup:Ruby
# Using the Ruby language, have the function AlphabetSoup(str) take the str string parameter being passed and return the string with the letters in alphabetical order (ie. hello becomes ehllo). Assume numbers and punctuation symbols will not be included in the string.

# takes string parameter str, rearranges all letters in alphabetical order, and returns new rearranged str
def AlphabetSoup(str)
	# splits str into an array of the characters making up str, sorts that arr, and then converts it to a single string
	str.chars.sort.join('')
end
# keep this function call here    
puts AlphabetSoup("hello")