// Difficulty: Easy
// Tags: string manipulation, regular expression
// https://coderbyte.com/editor/Simple%20Symbols:JavaScript
// Using the JavaScript language, have the function SimpleSymbols(str) take the str parameter being passed and determine if it is an acceptable sequence by either returning the string true or false. The str parameter will be composed of + and = symbols with several letters between them (ie. ++d+===+c++==a) and for the string to be true each letter must be surrounded by a + symbol. So the string to the left would be false. The string will not be empty and will have at least one letter. 
// returns true if all letters in String parameter str are immediately preceeded by and immediately followed by +
function SimpleSymbols(str) {
	// boolean to be returned by function
	bool = false;
	// loop over every character in str
	for (var i = 0; i < str.length; ++) {
		// if character in str is a letter and it's surrounded by +, set bool to true
		if (((str[i].charCodeAt(0) >= 97 && str[i].charCodeAt(0) =< 122) || (str[i].charCodeAt(0) >= 65 && str[i].charCodeAt(0) =< 90)) && str[i - 1] === '+' && str [i + 1] === '+') {
		}
	}
}
// keep this function call here 
SimpleSymbols(readline());
/////////////////////////