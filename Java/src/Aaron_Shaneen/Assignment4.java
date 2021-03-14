/*
 * Aaron Shaneen
 * Assignment 4
 * Runs programs for Ch 5 Exercises Custom 1, 2, 6, and 9
 * Also, in this assignment I'm trying to get used to Pascal
 */

package Aaron_Shaneen;
    import java.util.Scanner;
        public class Assignment4 {
            public static void main(String[] args){

// Exercise Custom Ex 1 - Prints a user input into a pyramid design (please make sure Ex 2-9 are commented out)

Scanner UserInput = new Scanner(System.in);

int PyrHeight;
String PyrSymbol;
int Line;
int Spaces;
int Chars;

System.out.print("Please enter a height for the pyramid between 5-50: ");
PyrHeight = UserInput.nextInt();

    while(PyrHeight < 5 || PyrHeight > 50)
    {    
        System.out.print("Invalid Answer. Please enter a height only between 5-50: ");
        PyrHeight = UserInput.nextInt();
    }

System.out.print("Please enter one character for the pyramid: ");
PyrSymbol = UserInput.next();

int ValidChar = PyrSymbol.length();

    while(ValidChar != 1)
    {
        System.out.print("Invalid Answer. Please enter only one character: ");
        PyrSymbol = UserInput.next();
        ValidChar = PyrSymbol.length();
    }

for(Line = 1; Line <= PyrHeight; Line++)
{
    
    for(Spaces = PyrHeight - 1; Spaces > 0; Spaces--)  
    {
        System.out.print(" ");
    }

    for(Chars = 1; Chars <= 2 * Line - 1; Chars += 2)
    {
        System.out.print(PyrSymbol);
    }
        
System.out.println();
}

// Exercise 2 - Implements Stirling's Formula on a number (please comment out Custom Ex 1)
              
/*int n = 11;
int x = (1 + 1/((12 * n) - 1));
int y = (int)Math.sqrt((2 * n) * Math.PI);
int z = (int)Math.pow((n / Math.E), n);
int StirlingsFormula = x * y * z;

System.out.println("n = 11 : " + StirlingsFormula);*/              

// Exercise 6 - Searches user input in a list of songs (please comment out Ex 2)

/*Scanner StdIn = new Scanner(System.in);

String Songs =
    "1. Green Day - American Idiot/n" +
    "2. Jesus Jones - Right Here, Right Now/n" +
    "3. Indigo Girls - Closer to Fine/n" +
    "4. Peter Tosh - Equal Rights/n";

String SearchText;
int FoundIndex = 0;
int Count = 0;

System.out.print("Enter search text: ");
SearchText = StdIn.nextLine();

while(FoundIndex > -1)
{
    FoundIndex=Songs.indexOf(SearchText,FoundIndex + 1);
    
        if (FoundIndex > -1)
        {
            Count++;
        }
}

System.out.println("Number of occurances of \"" + SearchText + "\": " + Count);*/
              
// Exercise 9 - Provides through an RNG the number of dots on a pair of dice (please comment out Ex 6)
                
/*int MinDice = 2;
int MaxDice = 12;
int Dots = 0;
        
Dots += MinDice + (Math.random() * (MaxDice - MinDice));
 
System.out.println(Dots);*/
                
} // end Assignment4
} // end main