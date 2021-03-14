/*
 * Aaron Shaneen
 * Assignment 7 Driver
 * Drives Assignment 7 Exercise classes Fraction(CustomEx1), Town(Ex5), and StudentId(Ex12)
 */

package Aaron_Shaneen_OOP;

import java.util.Scanner;

public class Assignment7Driver
{
    
    public static void main(String[] args)
    {
        CustomEx1();
        
        System.out.println("\n");
        
        Exercise5();
        
        System.out.println("\n");
        
        Exercise12();
        
    } // end main

// Custom Exercise 1 (w/ Fraction class) - Performs the four major math functions on fractions
        
    public static void CustomEx1()
    {
        Assignment7Fraction Fraction1 = new Assignment7Fraction();
        Assignment7Fraction Fraction2 = new Assignment7Fraction();
        Assignment7Fraction Result = new Assignment7Fraction();           // to store results, leaving original fractions unchanged

        Fraction1.SetNum(1);                        // setting numerator and denominator for Fraction 1
        Fraction1.SetDen(2);

        Fraction2.SetNum(3);                        // setting numerator and denominator for Fraction 2
        Fraction2.SetDen(4);

        Result = Fraction1.Add(Fraction2);          // performing addition
        Result.Print();

        Result = Fraction1.Subtract(Fraction2);     // performing subtraction
        Result.Print();

        Result = Fraction1.Multiply(Fraction2);     // performing multiplication
        Result.Print();

        Result = Fraction1.Divide(Fraction2);       // performing division
        Result.Print();

    } // end CustomEx1        
        
// Exercise 5 (w/ Town class) - Creates a home from input amount of adults/kids and simulates the birth of twins
        
    public static void Exercise5()
    {
        Assignment7Town NewHome = new Assignment7Town();
        Scanner StdIn = new Scanner(System.in);
        int Adults;                         // passing to Initialize method for amount of adults
        int Kids;                           // passing to Initialize method for amount of kids

        System.out.print("Enter amount of adults: ");
        Adults = StdIn.nextInt();

        System.out.print("Enter amount of kids: ");
        Kids = StdIn.nextInt();

        NewHome.Initialize(Adults, Kids);   // initializing adults and kids to NewHome

        NewHome.SimulateBirth();            // simulating birth of twins

        NewHome.PrintStats();               // printing current stats of object

    } // end Exercise5        
        
// Exercise 12 (w/ StudentId class) - Populates a StudentId with student info
        
    public static void Exercise12()
    {        
        Scanner StdIn = new Scanner(System.in);
        Assignment7StudentId Student;                          // declaring object
        String Name;
        Student = new Assignment7StudentId();                  // initializing object

        System.out.print("Enter student name: ");
        Name = StdIn.nextLine();
        Student.SetName(Name);                      // setting name

        System.out.print("Enter student id: ");
        Student.SetId(StdIn.nextInt());             // setting student id (in one line)

            while(!Student.IsValid())               // checking for valid student id
            {    
                System.out.print("Invalid student id - reenter: ");
                Student.SetId(StdIn.nextInt());
            }

        System.out.println("\n" + Name + ", your new email account is: \n" + Student.GetEmailAccount());

    } // end Exercise12
        
} // end Assignment7Driver