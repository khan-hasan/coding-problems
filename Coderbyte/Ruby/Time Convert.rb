# Difficulty: Easy
# Tags: string manipulation, math fundamentals
# https://coderbyte.com/editor/Time%20Convert:Ruby
# Using the Ruby language, have the function TimeConvert(num) take the num parameter being passed and return the number of hours and minutes the parameter converts to (ie. if num = 63 then the output should be 1:3). Separate the number of hours and minutes with a colon. 

# converts num parameter to "hours:minutes" and returns it
def TimeConvert(num)
	hours = num / 60
	minutes = num % 60
	return hours.to_s + ":" + minutes.to_s
end

# keep this function call here    
puts TimeConvert(8)