////////// 1 //////////
// Coderbyte
// Difficulty: Easy
// Tags: string manipulation
// https://coderbyte.com/editor/Letter%20Changes:JavaScript
// Using the JavaScript language, have the function LetterChanges(str) take the str parameter being passed and modify it using the following algorithm. Replace every letter in the string with the letter following it in the alphabet (ie. c becomes d, z becomes a). Then capitalize every vowel in this new string (a, e, i, o, u) and finally return this modified string.
// changes all letters in string parameter str to the the following letter in the alphabet. then capitalizes all vowels in new, modified str and returns it
function LetterChanges(str) {
	// array composed of each individual letter in str 
	var arr = str.split('');
	// final modified array to be returned by this function
		// loop over the every element in arr
		for (var i = 0; i < arr.length; i++) {
			// if the current element in arr is a letter other than z or Z, change it to the following letter in the alphabet
			// else if current element in arr is z or Z, change it to a or A respectively
			// then capitalize all vowels
			if ((arr[i].charCodeAt(0) >= 97 && arr[i].charCodeAt(0) < 122) || (arr[i].charCodeAt(0) >= 65 && arr[i].charCodeAt(0) < 90)) {
				arr[i] = String.fromCharCode(arr[i].charCodeAt(0) + 1);
			} else if (arr[i] === 'Z') {
				arr[i] = 'A';
			} else if (arr[i] === 'z') {
				arr[i] = 'a';
			}
			// if current element in arr is now a vowel, capitalize it
			if (arr[i] === 'a' || arr[i] === 'e' || arr[i] === 'i' || arr[i] === 'o' || arr[i] === 'u') {
				arr[i] = arr[i].toUpperCase();
			}
		}
	// convert arr to a single string without default , separator and return it
	return arr.join("");
}
// keep this function call here 
LetterChanges("this is a string full of nonsense.");
/////////////////////////





////////// 2 //////////
// Coderbyte
// Difficulty: Easy
// Tags: string manipulation
// https://coderbyte.com/editor/Letter%20Capitalize:JavaScript
// Using the JavaScript language, have the function LetterCapitalize(str) take the str parameter being passed and capitalize the first letter of each word. Words will be separated by only one space.
// returns string parameter str with first letter of each word in str capitalized
function LetterCapitalize(str) {
	// converts str to array arr composed of each individual word in str
	var arr = str.split(' ');
	// array containing all words in str with first letter capitalized
	var modifiedArr = [];
	// loops over each element (word) in arr
	for (var i = 0; i < arr.length + 1; i++) {
		// if word is a single character, capitalize it, and add it to modifiedArr with a trailing whitespace
		// else, loops over each charater of each element (word) in arr
		// following line for debugging //
		console.log('Entered outer for loop.');
		if (arr[i].length === 1) {
			// following line for debugging //
			console.log('entered if condition inside outer for loop.');
			modifiedArr.push(arr[i].toUpperCase() + ' ');
		} else {
			for (var j = 0; j < arr[i].length; j++) {
				// if letter is first letter in word, capitalizes it, and adds it to modifiedArr
				// else if letter is last letter in word, adds to to modifiedArr along with a trailing whitespace
				// else letter is not first or last letter in word, adds it to modifiedArr without capitalization or trailing whitespace
				// following line for debugging //
				console.log('i = ' + i + "\n" + 'j = ' + j + "\n" + 'arr[' + i + '][' + j + '] = ' + arr[i][j]);
				if (j === 0) {
					modifiedArr.push(arr[i][0].toUpperCase());
				} else if (j === arr[i].length - 1) {
					// if letter is final letter in final word, break
					if (i === arr.length && j === arr[i].length) {
						// following line for debugging //
						console.log('about to break');
						break;
					}
					// following line for debugging //
					console.log('inside else if condition.');
					// following line for debugging //
					console.log("The following is getting pushed to modifiedArr: " + arr[i][j] + '\n');
					modifiedArr.push(arr[i][j] + ' ');
					// following line for debugging //
					console.log("modifiedArr = " + modifiedArr);
				} else {
					// following line for debugging //
					console.log('inside last else condition in function.');
					modifiedArr.push(arr[i][j]);
				}
			}
		}

	}
	// convert modifiedArr to a string and return it
	return modifiedArr.join('');
}
// keep this function call here 
LetterCapitalize('this is a string full of nonsense.');
/////////////////////////





////////// 3 //////////
// Coderbyte
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
		// if character in str is a letter and its surrounded by +, set bool to true
		if (((str[i]charCodeAt(0) >= 97 && str[i].charCodeAt(0) =< 122) || (str[i].charCodeAt(0) >= 65 && str[i].charCodeAt(0) =< 90))) {

		}
	}
}
// keep this function call here 
SimpleSymbols(readline());   
/////////////////////////