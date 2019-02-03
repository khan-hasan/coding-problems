/*
A program, “RelativelyPrimeArray,” that takes an integer command-line argument “n” and creates an (n+1)-by-(n+1) Boolean array “rpa” such that rpa[i][j] (for i,j>0) is true if i and j are relatively prime (have no common factors), and is false otherwise. It should then output as is shown by the sample run below. If the indexes i,j (for i,j>0) are equal, it should output a single space. If the indexes are not equal, then it should output a "T" character if the array element specified by the indexes is true or an "F" character if it is false. [MO2.1, MO2.2]

A sample run would be as follows. 

> java RelativelyPrimeArray 9 
   1 2 3 4 5 6 7 8 9 
1    T T T T T T T T 
2 T    T F T F T F T 
3 T T    T T F T T F 
4 T F T    T F T F T 
5 T T T T    T T T T 
6 T F F F T    T F F 
7 T T T T T T    T T 
8 T F T F T F T    T 
9 T T F T T F T T
*/
public class relativelyPrimeArray {
    public static void main(String[] args) {
        // Convert command-line argument to int, and assign its value to int n.
        int n = Integer.parseInt(args[0]);

        // Create an empty (n+1)-by-(n+1) boolean array rpa.
        boolean[][] rpa = new boolean[n + 1][n + 1];

        // Loop over rpa, and fill elements with true if i and j are relatively prime, and false otherwise.
        // Leave first column and first row of rpa as false.
        for (int i = 1; i < rpa.length; i++) {
            for (int j = 1; j < rpa[i].length; j++) {
                rpa[i][j] = relativelyPrime(i, j);
            }
        }

        // String used when printing rpa to correct the formatting of the row and column number labels.
        String formatSpace;
        if (n < 10) {
            formatSpace = " ";
        } else {
            formatSpace = "\t";
        }

        // Loop over rpa, and print its elements.
        for (int i = 0; i < rpa.length; i++) {
            for (int j = 0; j < rpa[i].length; j++) {
                // Print a whitespace in top left corner of rpa.
                if (i == 0 && j == 0) {
                    System.out.print(formatSpace);
                }
                // Print column numbers across row 1.
                else if (i == 0) {
                    System.out.print(j + formatSpace);
                }
                // Print row numbers across column 1.
                else if (j == 0) {
                    System.out.print(i + formatSpace);
                }
                // Print a empty diagonal of whitespaces in rpa from top left to bottom right.
                else if (i == j) {
                    System.out.print(formatSpace);
                }
                // Print "T" if rpa element is true.
                else if (rpa[i][j]) {
                    System.out.print("T" + formatSpace);
                }
                // Print "F" if rpa element is false.
                else {
                    System.out.print("F" + formatSpace);
                }
            }
            // Print next row of rpa on next line.
            System.out.println();
        }
    }

    // Calculate greatest common factor of two numbers.
    private static int gcd(int a, int b) {
        int t;
        while (b != 0) {
            t = a;
            a = b;
            b = t % b;
        }
        return a;
    }

    // Determine if two numbers are relatively prime.
    private static boolean relativelyPrime(int a, int b) {
        return gcd(a, b) == 1;
    }
}
