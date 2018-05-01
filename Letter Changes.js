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