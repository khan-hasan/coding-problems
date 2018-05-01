########## 1 ##########
# Coderbyte
# Difficulty: Easy
# https://coderbyte.com/results/khanhasan:First%20Factorial:Ruby
# Have the function FirstFactorial(num) take the num parameter being passed and return the factorial of it (e.g. if num = 4, return (4 * 3 * 2 * 1)). For the test cases, the range will be between 1 and 18 and the input will always be an integer.
def FirstFactorial(num)
  product = 1
  for x in num..1
    product *= x
  end
  return product
end

# keep this function call here    
puts FirstFactorial(STDIN.gets)
#########################





########## 2 ##########
# Coderbyte
# Difficulty: Easy
# https://coderbyte.com/results/khanhasan:Simple%20Adding:Ruby
# Have the function SimpleAdding(num) add up all the numbers from 1 to num. For example: if the input is 4 then your program should return 10 because 1 + 2 + 3 + 4 = 10. For the test cases, the parameter num will be any number from 1 to 1000.
def SimpleAdding(num)
  sum = 0
  for x in 1..num
    sum += x
  end
  return sum
end
   
# keep this function call here    
puts SimpleAdding(STDIN.gets)
#########################





########## 3 ##########
# Coderbyte
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
#########################





########## 4 ##########
# Coderbyte
# Results for First Reverse
# Difficulty: Easy
# https://coderbyte.com/results/khanhasan:First%20Reverse:Ruby
# Have the function FirstReverse(str) take the str parameter being passed and return the string in reversed order. For example: if the input string is "Hello World and Coders" then your program should return the string sredoC dna dlroW olleH. 
def FirstReverse(str)
  return str.reverse
end
   
# keep this function call here    
puts FirstReverse(STDIN.gets)
#########################