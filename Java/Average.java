/*
A program, “Average,” that reads in lines from standard input with each line containing a name and three integers and then uses “printf()” to print a table with a column of the names, the integers, and the average of the three integers accurate to two decimal places. The user will specify the number of names as a command-line argument and then type in that number of names (along with three integers for each name). [MO2.1, MO2.2]

A sample run would be as follows. 

> java Average 4 
Joe 3 5 2 
Tim 4 1 5 
Jane 6 3 2 
Jack 8 3 5
<Ctrl-D>  

Joe 3 5 2 3.33 
Tim 4 1 5 3.33 
Jane 6 3 2 3.67 
Jack 8 3 5 5.33
*/
import java.util.Scanner;

public class Average {
    public static void main(String[] args) {
        // Declare int n and assign it the command-line argument, which will specify the number of names to be entered by the user.
        int n = Integer.parseInt(args[0]);

        // String array which stores lines from user input.
        String[] userInput = new String[n];

        // Prompt user for input.
        System.out.println("Type a line containing a name and three integers, all separated by a space.\nThen press ENTER at the end of each input line:");

        // Use Scanner class to retrieve each line of user input, and save in userInput.
        for (int i = 0; i < n; i++) {
            Scanner in = new Scanner(System.in);

            // Save user input in userInput.
            userInput[i] = in.nextLine();
        }

        // Loop over userInput, and print a single line containing name, inputted integers, and average of those integers for each string element in userInput.
        for (int i = 0; i < userInput.length; i++) {
            String[] line = userInput[i].split(" ");

            // Calculate the average of the inputted integers.
            Float average = (Integer.parseInt(line[1]) + Integer.parseInt(line[2]) + Integer.parseInt(line[3])) / 3f;
            System.out.printf("%s %d %d %d %.2f%n", line[0], Integer.parseInt(line[1]), Integer.parseInt(line[2]), Integer.parseInt(line[3]), average);
        }
    }
}
