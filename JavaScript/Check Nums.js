// Difficulty: Easy
// Tags: math fundamentals
// https://coderbyte.com/editor/Check%20Nums:JavaScript
// Using the JavaScript language, have the function CheckNums(num1,num2) take both parameters being passed and return the string true if num2 is greater than num1, otherwise return the string false. If the parameter values are equal to each other then return the string -1.

// returns "true" if num2 > num1, "-1" if num2 = num1, "false" otherwise
function CheckNums(num1,num2) {
	if (num2 > num1) {
		return "true";
	} else if (num2 === num1) {
		return "-1";
	} else {
		return "false";
	}
}

// keep this function call here 
console.log(CheckNums(3, 122));