/*
 * Aaron Shaneen
 * Practice
 */

package Practice;
    import java.util.Scanner;
        public class BasicPractice {
            public static void main(String[] args) {

/* 
 * Boolean (Comparison) operators
 * == -> two things are equal
 * != -> two things are NOT equal
 * > -> the thing on the left is bigger than the thing right
 * < -> the thing on the left is smaller than the thing right
 * >= -> the thing on the left is bigger than or equal to the thing right
 * <= -> the thing on the left is smaller than or equal to the thing right
 */
            
/*boolean isTrue = true;
        
    int i = 42;
    int j = 73;
    char input = 'y';
        
    boolean isC = input != 'c';
    boolean isMoreThan50 = i > 50;*/
   
/* 
 * Logical Operators
 * && -> And
 * || -> Or
 */
        
/*if (i < 50)
{
    int d = i + j;
    System.out.println("Your number is " + d);
}
else if (i == 50)
{
    System.out.println("Your number is 50");
}
else if(i < 25)
{
    System.out.println("Less than 25");
}
else if (i > 50 && i < 70 && i == 65)
{
    asdlfkjasdf       
}
else if (i > 70 || i < 0 || i == 45 || i == 23)
{
    lkjasfl;asd       
}
else if(i > 45 && (i < 30 || i > 0))
{
    as;flkjadsd
}
else
{

if(j > 50)
    System.out.println("Your number is " + j);
else
    System.out.println("Your number is" + i);*/


/*char cont = 'y';

switch(cont)
{
    case 'Y':
        System.out.println("Please use lowercase letter");
    case 'y':
        int d = i * 2;
            System.out.println("Your number is" + d);
        break;
        default:
            System.out.println("You chose to exit.");
        break;
}*/
        
/* 
 * Loop structures
 * for loops
 * while
 * do-while
 * int u = 5;
 * int y = u++;
 */        

/*for( int l = 0, m = 9; l < 50; l++)
{
    System.out.println(l);
}
        
String userInput;
Scanner fromConsole = new Scanner(System.in);
userInput = fromConsole.next();
while(userInput.equals("y"))
{
    System.out.println(u);
    System.out.println("Press 'y' to continue");
    userInput = fromConsole.next();
}
        
do
{
    System.out.println(u);
    System.out.println("Press 'y' to continue");
    userInput = fromConsole.next();
} while(userInput.equals("y"));*/
      
/*int width = 5, height = 15;

double result2 = Square(width, height);
}*/

/*String str = new String("Hello World");
Scanner scnr = new Scanner(System.in);
{        
    double result = Math.pow(100, 2);
    Print(str);
    String str2 = "Foo Bar";
    Print(str2);
    int width = 5,
    height = 15;
        
double result2 = Square(width, height);
        
    String strResult = str.concat(str2);
    str.indexOf("o W");
    Print(strResult);
}*/
    
/*  
 * Functions
 *  1. Return type
 *  2. Name
 *  3. Parameters
 *  Name and Parameters form the function signature.
 */
 
/*public static double Square(int width, int height)
{
    int area = width * height;
    return area;
}
    
public static void Print(String printValue)
{
    System.out.println(printValue);
}*/

// Arrays **********************************************************************                
                
        /*String[] names = new String[SIZE];
        String[] namesCopy = new String[SIZE];
        
        String str = new String("Hello World");
        String str2 = str;
        str2 = str2.concat("!");
        str2 = new String("Foo Bar");

        // initialize each item to be a string.
        // otherwise, it can just break if we try to access them
        for (int k = 0; k < SIZE; k++) {
            names[k] = new String();
        }

        // Get a name for each location in the array
        for (int i = 0; i < SIZE; i++) {
            names[i] = GetName(scan);
        }
        
        System.out.println("Names arr: ");
        PrintArray(names);
        
        // Copy one array into the other
        System.arraycopy(names, 0, namesCopy, 0, SIZE);
        //namesCopy = names;    // This doesn't work the way you'd think

        
        // Change the value of the string in the first element of namesCopy
        namesCopy[0] = namesCopy[0].concat("Hello");
        System.out.println("NamesCopy arr: ");
        // Print out everything in the array
        PrintArray(namesCopy);
        
        System.out.println("Names arr again: ");
        // Print out everything in the array
        PrintArray(names);
        
        String five = "Hello";
        someFunc(five);
        System.out.println(five);
    }

    // Ask user for a name and return it
    public static String GetName(Scanner scan) {
        String name;
        System.out.print("Please enter someone's name (-1 to quit): ");
        name = scan.next();
        return name;
    }
    
    // Print the passed in array
    public static void PrintArray(String[] arr)
    {
        for (int i = 0; i < arr.length; i++) {
            System.out.println(arr[i]);
        }
    }
    
    public static String someFunc(String i)
    {
        i = new String("5");
        return i;
    
    int SIZE = 10;
        String[] names = new String[SIZE];
        
        int[][] table = new int[3][SIZE];
        table[0][0] = 5;
        table[2][3] = 10;
        
        int[][] staggeredArray = new int[3][];
        
        staggeredArray[0] = new int[3];
        staggeredArray[1] = new int[5];
        staggeredArray[2] = new int[2];
        
        int[][][] cube = new int[5][][];*/
                
}
}