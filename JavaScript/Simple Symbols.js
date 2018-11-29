// Difficulty: Easy
// Tags: string manipulation, regular expression
// https://coderbyte.com/editor/Simple%20Symbols:JavaScript
// Using the JavaScript language, have the function SimpleSymbols(str) take the str parameter being passed and determine if it is an acceptable sequence by either returning the string true or false. The str parameter will be composed of + and = symbols with several letters between them (ie. ++d+===+c++==a) and for the string to be true each letter must be surrounded by a + symbol. So the string to the left would be false. The string will not be empty and will have at least one letter. 
// returns true if all letters in String parameter str are immediately preceeded by and immediately followed by +
function SimpleSymbols(str) {
	// array containing booleans representing whether each individual letter in str is surrounded by +
	var bools = [];
	// loop over every character in str
	for (var i = 0; i < str.length; i++) {
		// if character in str is a letter
		if (str[i].toLowerCase().charCodeAt(0) >= 97 && str[i].toLowerCase().charCodeAt(0) <= 122) {
			// if character in str is a letter and it's surrounded by '+'s, push true to bools
			// else push false to bools
			if (str[i - 1] === '+' && str [i + 1] === '+') {
				bools.push(true);
			} else {
				bools.push(false);
			}
		}
	}
	// loop over bools and return "true" if it contains all true booleans and "false" otherwise
	for (var j = 0; j < bools.length; j++) {
		if (bools[j] === false) {
			return "false";
		}
	}
	return "true";
}
// keep this function call here 
SimpleSymbols("++d+===+c++==a");