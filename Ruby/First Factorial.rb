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