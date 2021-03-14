/*
 * Aaron Shaneen
 * Assignment3
 * Runs Ch4 Exercise programs 3,5,9(8 1st ed.),11(10 1st ed.)
 */

package Aaron_Shaneen;
    import java.util.Scanner;
        public class Assignment3 {
            public static void main(String[] args) {

// Exercise3 (note that Ex5 and below are commented out)

/*int count = 0;
int sum = 0;
int product = 1;

do
{    
    count++;
    sum += count;
    product *= count;
} while (count < 5);

if (count == 5);
{
    System.out.println("Sum = " + sum);
    System.out.println("Product = " + product);
}*/

// Exercise5 (note that Ex8 and below are commented out, please also comment out Ex3 to run Ex5)

/*Scanner stdIn = new Scanner(System.in);
int i, num, product = 1;

System.out.print("Enter a positive even number: ");
num = stdIn.nextInt();

for (i = 2; i <= num; i += 2)
{
    product *= i;
}  

System.out.println("Product = " + product);*/
            
// Exercise8 (note that Ex10 and is commented out, please also comment out Ex3-5 to run Ex8)

Scanner stdIn = new Scanner(System.in);
int score;
int totalScore = 0;
int count = 0;
double average;
boolean more = true;

while (more)
{

    System.out.print("Enter score (-1 to quit): ");
    score = stdIn.nextInt();
    
    if (score >= 0)
    {
        totalScore += score;
        count++;
    }
    
    else 
    {
        more = false;
    }    
}

average = (double) (totalScore / count);
System.out.println("Average score is " + average);

// Exercise10 (please comment out Ex3-8 to run Ex10)

//System.out.println("Which way would the other elf tell me is the way to the gold?");

}
}