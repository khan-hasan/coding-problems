/*
A program, “Distribution100,” that takes integer command-line arguments. The first argument would be the count of the remaining arguments that are between 1 and 100 (inclusive of 1 and 100). It then prints out the count of numbers entered that are less than or equal to 50 and the count of numbers that are greater than 50 from those remaining arguments. [MO2.1, MO2.2]

A sample run would be as follows.

> java Distribution100 15 5 82 2 1 74 19 47 64 39 77 25 99 100 1 10 
9 numbers entered are less than or equal to 50. 
6 numbers entered are greater than 50.
*/
public class Distribution100 {
    public static void main(String[] args) {
        // Declare counter variables to count numbers greater than or less than 50. Initialize them both to 0.
        int greater = 0,
                less = 0;

        // Loop over each command-line inputted number, convert it from String to Integer, and increment counter variables.
        for (int i = 0; i < args.length; i++) {
            if (Integer.parseInt(args[i]) >= 50) {
                greater += 1;
            }
            else {
                less += 1;
            }
        }

        // Print count of numbers less than or equal to 50.
        System.out.println(String.valueOf(less) + " numbers entered are less than or equal to 50.");
        // Print count of numbers greater than 50.
        System.out.println(String.valueOf(greater) + " numbers entered are greater than 50.");
    }
}
