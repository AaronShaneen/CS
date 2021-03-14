/*
 * Aaron Shaneen
 * Assignment 5
 * Runs programs for Custom Ex 1, Ex 2, and Ch 8 Ex 2 (named Ex3)
 */

package Aaron_Shaneen;

import java.util.Scanner;

public class Assignment5
{

    public static void main(String[] args)
    {
        Exercise1();
    }

// Custom Ex 1 - Based on user input prints a solid or bordered square 
    
    public static void Exercise1()
    {

        Scanner UserInput = new Scanner(System.in);

        int Width;
        int Height;
        
        System.out.print("Please enter a width for the side of a square: ");
        Width = UserInput.nextInt();

            while (Width <= 0)
            {
                System.out.print("Invalid length. Please enter a valid length: ");
                Width = UserInput.nextInt();
            }
        
        Height = Width;     // Height = Width in a square, used as for loop conditions below
        
        int Area = (int) Math.pow(Width, 2);
        System.out.println("Area= " + Area);

        System.out.print("Press b for a bordered square or s for a solid square: ");
        String Design = UserInput.next();

            while (!Design.equalsIgnoreCase("b") && !Design.equalsIgnoreCase("s"))
            {
                System.out.print("Invalid Answer. Please press b for a bordered square or s for a solid square: ");
                Design = UserInput.next();
            }

        if (Design.equalsIgnoreCase("s"))   // builds a solid square
        {
            System.out.print("Enter a character to use to build the square: ");
            String Char1 = UserInput.next();
                
            int ValidChar = Char1.length();

                while (ValidChar != 1)
                {
                    System.out.print("Invalid Character. Please enter a valid character: ");
                    Char1 = UserInput.next();
                    ValidChar = Char1.length();
                }
            
            for (int Row = 1; Row <= Height; Row++)
            {
                for (int Col = 1; Col <= Width; Col++)
                {
                    System.out.print(Char1);
                }       
                System.out.println();
            }
        } // end if solid loop
        
        if (Design.equalsIgnoreCase("b"))   // builds a bordered square
        {
            System.out.print("Enter a chracter to use to build the border: ");
            String Char1 = UserInput.next();

            int ValidChar1 = Char1.length();

                while (ValidChar1 != 1)
                {
                    System.out.print("Invalid Character. Please enter a valid character: ");
                    Char1 = UserInput.next();
                    ValidChar1 = Char1.length();
                }
            
            System.out.print("Enter a character to use to build the square: ");
            String Char2 = UserInput.next();
                
            int ValidChar2 = Char2.length();

                while (ValidChar2 != 1)
                {
                    System.out.print("Invalid Character. Please enter a valid character: ");
                    Char2 = UserInput.next();
                    ValidChar2 = Char2.length();
                }
        
            for (int Col = 1; Col <= Width; Col++)
            {
                System.out.print(Char1);
            }       
                
            System.out.println();
                            
            for (int Row = 1; Row < Height - 1; Row++)
            {                    
                System.out.print(Char1);
                
                    for (int Col = 1; Col < Width - 1; Col++)
                    {
                        System.out.print(Char2);
                    }    
                                    
                System.out.println(Char1);
            }
            
            for (int Col = 1; Col <= Width; Col++)
            {
                System.out.print(Char1);
            }       
            
            System.out.println();
                    
        } // end if border loop
    } // End Exercise1 function

// Custom Ex 2 - Runs an equation on a given integer
    
    public static double Exercise2(double SomeNum)
    {

        Scanner UserInput = new Scanner(System.in);
        
        System.out.print("Please enter an integer: ");
        SomeNum = UserInput.nextDouble();
        
        double Sin = Math.sin(SomeNum);
        double Tan = Math.tan(SomeNum);
        double Result;
        
        Result = Math.abs(Math.pow(Sin, 2) / (Tan));
        
        if (Result == 0)
        {
            System.out.println("Result = 0");
        }    
        else if (Result >= 0 && Result <= 0.33)
        {
            Math.log(Result);
            return Result;
        }
        else if (Result > 0.33 && Result <= 0.66)
        {
            Math.log10(Result);
            return Result;
        }
        else
        {
            Math.pow(Result, 2);
            return Result;
        }    
    
        return Result;
    } // End Exercise2 function                

// Text Ex 2 - Formatting of given program

    /*
     * Environment.java
     * Dean & Dean
     * This program models the world's environment
     */
    
    public class Exercise3
    {

        private double sustainableProduction;             // instance variables
        private double initialResources;
        private double currentResources;
        private double yieldFactor = 2.0;

        public void setSustainableProduction(double production)
        {
            this.sustainableProduction = production;
        }

        public void setInitialResources(double resources) // Set pre-industrial mineral and fossil resources
        {
            this.initialResources = resources;
        }

        public void setCurrentResources(double resources) // Initialize remaining mineral and foxxil resources
        {
            this.currentResources = resources;
        }

        public double getCurrentResources()               // Fetch remaining mineral and fossil resources
        {
            return this.currentResources;
        }

        /* 
         * Compute annual combination of renewable
         * and non-renewable environmental production
         */
        
        public double produce(double populationFraction, double extractionExpense)
        {
            double extraction;

            extraction = this.yieldFactor * extractionExpense * (this.currentResources / this.initialResources);

            this.currentResources -= extraction;

            return extraction + populationFraction * this.sustainableProduction;
        }
    } // End Exercise3 function

} // end Assignment5 class