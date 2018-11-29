// Difficulty: Easy
// Tags: matrix, searching
// https://coderbyte.com/editor/Vowel%20Square:JavaScript
// Using the JavaScript language, have the function VowelSquare(strArr) take the strArr parameter being passed which will be a 2D matrix of some arbitrary size filled with letters from the alphabet, and determine if a 2x2 square composed entirely of vowels exists in the matrix. For example: strArr is ["abcd", "eikr", "oufj"] then this matrix looks like the following:

// a b c d
// e i k r
// o u f j 

// Within this matrix there is a 2x2 square of vowels starting in the second row and first column, namely, ei, ou. If a 2x2 square of vowels is found your program should return the top-left position (row-column) of the square, so for this example your program should return 1-0. If no 2x2 square of vowels exists, then return the string not found. If there are multiple squares of vowels, return the one that is at the most top-left position in the whole matrix. The input matrix will at least be of size 2x2.
// returns string parameter str with first letter of each word in str capitalized
function VowelSquare(strArr) {
	var row1 = strArr[0];
	var row2 = strArr[1];
	var row3 = strArr[2];
	topLeftOfVowelSquare = "";
	// loop over row 1 to find if 2 consecutive vowels occur
	for (var i = 0; i < strArr.length - 2; i++) {
		if ((row1[i] === 'a' || row1[i] === 'e' || row1[i] === 'i' || row1[i] === 'o' || row1[i] === 'u') &&
			(row1[i + 1] === 'a' || row1[i + 1] === 'e' || row1[i + 1] === 'i' || row1[i + 1] === 'o' || row1[i + 1] === 'u') &&
			(row2[i] === 'a' || row2[i] === 'e' || row2[i] === 'i' || row2[i] === 'o' || row2[i] === 'u') &&
			(row2[i + 1] === 'a' || row2[i + 1] === 'e' || row2[i + 1] === 'i' || row2[i + 1] === 'o' || row2[i + 1] === 'u')) {
			topLeftOfVowelSquare += "1";
		}
	}
}

// keep this function call here
VowelSquare(readline());