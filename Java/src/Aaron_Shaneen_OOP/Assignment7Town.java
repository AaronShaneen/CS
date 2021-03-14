/*
 * Aaron Shaneen
 * Assignment 7 Exercise 5
 * Initiates, simulates, and prints the growing demographics of a town
 */

package Aaron_Shaneen_OOP;

// Exercise 5 (w/ Town class) - Creates a home from input amount of adults/kids and simulates the birth of twins

public class Assignment7Town
{
    private int NumOfAdults;                        // hidden instance variable                                        
    private int NumOfKids;                          // hidden instance variable
    
    public void Initialize(int Adults, int Kids)    // Initializes numbers of adults/kids
    {
        this.NumOfAdults = Adults;
        this.NumOfKids = Kids;
    }
    
    public void SimulateBirth()                     // Siumlates the birth of twins
    {
        NumOfKids += 2;
    }
    
    public void PrintStats()                        // Prints current stats of a Town object
    {
        System.out.print("\n" + "Number of adults: " + NumOfAdults + "\n" + "Number of kids: " + NumOfKids);
    }        
    
} // end Town