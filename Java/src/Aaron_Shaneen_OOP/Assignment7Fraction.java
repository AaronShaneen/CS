/*
 * Aaron Shaneen
 * Assignment 7 Custom Exercise 1
 * Performs four basic math functions to fractions
 */

package Aaron_Shaneen_OOP;

// Custom Exercise 1 (w/ Fraction class) - Performs the four major math functions on fractions

public class Assignment7Fraction
{
    private int Numerator;                      // hidden instance variable
    private int Denominator;                    // hidden instance variable
    
    public void SetNum(int Num)                 // setter for numerator
    {
        this.Numerator = Num;
    }
    
    public int GetNum()                         // getter for numerator
    {
        return this.Numerator;
    }
    
    public void SetDen(int Den)                 // setter for denominator
    {
        this.Denominator = Den;
    }
    
    public int GetDen()                         // getter for denominator
    {
        return this.Denominator;
    }
    
    public Assignment7Fraction Add(Assignment7Fraction Frac2)         // performs addition with cross multiplication
    {
        Assignment7Fraction Frac3 = new Assignment7Fraction();
        
        Frac3.SetNum((this.Numerator * Frac2.Denominator) + (Frac2.Numerator * this.Denominator));
        Frac3.SetDen(this.Denominator * Frac2.Denominator);
        
        return Frac3;
    }   
    
    public Assignment7Fraction Subtract(Assignment7Fraction Frac2)    // performs subtraction with cross multiplication
    {
        Assignment7Fraction Frac3 = new Assignment7Fraction();
        
        Frac3.SetNum((this.Numerator * Frac2.Denominator) - (Frac2.Numerator * this.Denominator));
        Frac3.SetDen(this.Denominator * Frac2.Denominator);
        
        return Frac3;
    }   
    
    public Assignment7Fraction Multiply(Assignment7Fraction Frac2)    // performs multiplication
    {
        Assignment7Fraction Frac3 = new Assignment7Fraction();
        
        Frac3.SetNum(this.Numerator * Frac2.Numerator);
        Frac3.SetDen(this.Denominator * Frac2.Denominator);
        
        return Frac3;
    }   
    
    public Assignment7Fraction Divide(Assignment7Fraction Frac2)      // performs division
    {
        Assignment7Fraction Frac3 = new Assignment7Fraction();
        
        Frac3.SetNum(this.Numerator * Frac2.Denominator);
        Frac3.SetDen(this.Denominator * Frac2.Numerator);
        
        return Frac3;        
    }   
    
    public void Print()                         // simple print method to show results
    {
        System.out.println(this.Numerator + "/" + this.Denominator + "\n");
    }        

} // end Fraction
