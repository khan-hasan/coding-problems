# Difficulty: Easy
# Tags: string manipulation, searching
# https://coderbyte.com/editor/Longest%20Word:Ruby
# Using the Ruby language, have the function LongestWord(sen) take the sen parameter being passed and return the largest word in the string. If there are two or more words that are the same length, return the first word from the string with that length. Ignore punctuation and assume sen will not be empty. 
def LongestWord(sen)
  arr = sen.split(' ')
  longest = arr[0]
  arr.each do |word|
    if word.length > longest.length
      longest = word
    end
  end
  return longest
end
   
# keep this function call here    
puts LongestWord(STDIN.gets)