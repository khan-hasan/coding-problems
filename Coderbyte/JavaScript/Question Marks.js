// Difficulty: Easy
// Tags: string manipulation, searching, hash table
// https://coderbyte.com/editor/Questions%20Marks:JavaScript
// Using the JavaScript language, have the function QuestionsMarks(str) take the str string parameter, which will contain single digit numbers, letters, and question marks, and check if there are exactly 3 question marks between every pair of two numbers that add up to 10. If so, then your program should return the string true, otherwise it should return the string false. If there aren't any two numbers that add up to 10 in the string, then your program should return false as well. For example: if str is "arrb6???4xxbl5???eee5" then your program should return true because there are exactly 3 question marks between 6 and 4, and 3 question marks between 5 and 5 at the end of the string.
// Hint: It may help to first find all the pairs of numbers that add up to 10, and then check what's between them.

// takes string parameter str and returns "true" if there are exactly 3 '?'s between every pair of two single-digit numbers that add to 10.
function QuestionsMarks(str) {
	// if str contains no digits or '?'s, return false
	if (/\d/g.test(str) === false || /\?/g.test(str) === false) {
		return false;
	}
	// array which contains as elements all substrings in str that begin with a digit and end with a digit
	var substrings = str.match(/\d\D+\d/g);
	// loop over substrings array and remove from it each individual substring that begins and ends with a pair of digits which do not sum to 10
	for (var j = 0; j < substrings.length; j++) {
		if (Number(substrings[j][0]) + Number(substrings[j][substrings[j].length - 1]) != 10) {
			substrings.splice(j, 1);
		}
	}
	// array that will contain one boolean for each substring in the substrings array. true if substring contains exactly 3 '?'s, false otherwise
	var bools = [];
	// loop over each substring in substrings
	for (var i = 0; i < substrings.length; i++) {
		// if the first and last digit of each substring in the substrings array add to 10, then check that only 3 '?'s exist between those digits. If so, add true to bools.
		if (substrings[i].match(/\?/g).length === 3) {
			bools.push(true);
		}
	}
	// returns true if every boolean in bools is true and false otherwise
	if (bools.length === substrings.length && bools.length > 0) {
		return true;
	} else {
		return false;
	}
}

// test case 1
console.log("test case 1:\nexpected: true\nactual: " + QuestionsMarks("arrb6???4xxbl5???eee5") + '\n\n');

// test case 2
console.log("test case 2:\nexpected: false\nactual: " + QuestionsMarks("aaa6?9") + '\n\n');

// test case 3
console.log("test case 3:\nexpected: false\nactual: " + QuestionsMarks("aaaaaaarrrrr??????") + '\n\n');

// test case 4
console.log("test case 4:\nexpected: false\nactual: " + QuestionsMarks("9???1???9??1???9") + '\n\n');

// test case 5
console.log("test case 5:\nexpected: false\nactual: " + QuestionsMarks("4?5?4?aamm9") + '\n\n');

// test case 6
console.log("test case 6:\nexpected: false\nactual: " + QuestionsMarks("5??aaaaaaaaaaaaaaaaaaa?5?5") + '\n\n');

// test case 7
console.log("test case 7:\nexpected: false\nactual: " + QuestionsMarks("mbbv???????????4??????ddsdsdcc9?") + '\n\n');

// test case 8
console.log("test case 8:\nexpected: true\nactual: " + QuestionsMarks("acc?7??sss?3rr1??????5") + '\n\n');

// test case 9
console.log("test case 9:\nexpected: true\nactual: " + QuestionsMarks("5??aaaaaaaaaaaaaaaaaaa?5?a??5"));