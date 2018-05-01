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
	for (var i = 0; i < arr.length; i++) {
		// if word is a single character, capitalize it, and add it to modifiedArr with a trailing whitespace
		// else, loops over each charater of each element (word) in arr
		if (arr[i].length === 1) {
			modifiedArr.push(arr[i].toUpperCase() + ' ');
		} else {
			for (var j = 0; j < arr[i].length; j++) {
				// if letter is first letter in word, capitalizes it, and adds it to modifiedArr
				// else if letter is last letter in word, adds to to modifiedArr along with a trailing whitespace
				// else letter is not first or last letter in word, adds it to modifiedArr without capitalization or trailing whitespace
				if (j === 0) {
					modifiedArr.push(arr[i][0].toUpperCase());
				} else if (j === arr[i].length - 1) {
					// if letter is final letter in final word, break
					if (i === arr.length && j === arr[i].length) {
						break;
					}
					modifiedArr.push(arr[i][j] + ' ');
				} else {
					modifiedArr.push(arr[i][j]);
				}
			}
		}

	}
	// convert modifiedArr to a string, remove last trailing whitespace, and return it
	return modifiedArr.join('').slice(0, -1);
}
// keep this function call here 
LetterCapitalize('this is a string full of nonsense.');
/////////////////////////