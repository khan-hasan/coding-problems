// Difficulty: Easy
// Tags: string manipulation, searching, Google
// https://coderbyte.com/editor/Correct%20Path:JavaScript
// Using the JavaScript language, have the function CorrectPath(str) read the str parameter being passed, which will represent the movements made in a 5x5 grid of cells starting from the top left position. The characters in the input string will be entirely composed of: r, l, u, d, ?. Each of the characters stand for the direction to take within the grid, for example: r = right, l = left, u = up, d = down. Your goal is to determine what characters the question marks should be in order for a path to be created to go from the top left of the grid all the way to the bottom right without touching previously travelled on cells in the grid. For example: if str is "r?d?drdd" then your program should output the final correct string that will allow a path to be formed from the top left of a 5x5 grid to the bottom right. For this input, your program should therefore return the string rrdrdrdd. There will only ever be one correct path and there will always be at least one question mark within the input string.

// move a player on a 5x5 grid from its starting position in the top left to the bottom right
function CorrectPath(str) {
	// an array composed of each individual move the player will take. 'l', 'r', 'u', 'd' represent 'left', 'right, 'up', and 'down'. '?' represents an unknown move.
	var moves = str.split('');
	// each of the following represents the total number of moves in each respective directiona as specified by the moves array
	var up = 0,
			down = 0,
			right = 0,
			left = 0;
	// loop over moves
	for (var i = 0; i < moves.length; i++) {
		switch (moves[i]) {
			case 'u':
					up += 1;
				break;
			case 'd':
					down += 1;
				break;
			case 'l':
					left += 1;
				break;
			case 'r':
					right += 1;
				break;
		}
	}
	// find the net steps taken horizontally and vertically
	left *= -1;
	up *= -1;
	var horizontalMovees = left + right;
	var verticalMoves = up + down;
	/////////////////////////////////////////////////
	/////// left off here /////////
	//////// this is working. dont erase and start over //////////
	//////////////////////////////////////////////////////
	// debugging //
	console.log('horizontalMovees = ' + horizontalMovees + '\nverticalMoves = ' + verticalMoves);
}

// keep this function call here 
CorrectPath("???rrurdr?");