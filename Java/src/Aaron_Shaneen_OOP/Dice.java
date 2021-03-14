/*
 * Aaron Shaneen 
 * Assignment 8 Custom Exercise Dice 
 * Constructs a Dice object, sets the number of dice and faces per dice,  
 * simulates rolling all dice, and prints how many times each face appears 
 */

package Aaron_Shaneen_OOP;

import java.util.Random;

public class Dice
{
    Random RNG = new Random();  // random number generator
    private int Dice;           // to store number of faces
    private int TotNumDice;     // total number of dice being rolled
    private int RollResult;     // to store sum of all dice being rolled x times
    private int[] Occurence;    // an array to record occurences of faces
    
    public Dice(int NumDice)    // constructor with a default of 6 faces             
    {
        this(NumDice, 6);
    }
    
    public Dice(int NumDice, int NumFaces)    // constructor with input number of dice/faces
    {
        this.SetDice(NumDice, NumFaces);
    }
    
    public void SetDice(int NumDice)    // setter for number of dice with default of 6 faces each    
    {
        this.SetDice(NumDice, 6);
    }
    
    public void SetDice(int NumDice, int NumFaces)    // setter for input number of dice/faces
    {
        TotNumDice = NumDice;
        Dice = NumFaces;
        Occurence = new int[NumFaces];    // array is filled in Roll method
    }
    
    public int Roll()    // rolls dice a default amount of once and records occurences                                 
    {
        int Craps;    // to transfer number rolled to RollResult and Occurences
        
        for(int i = 1; i <= TotNumDice; i++)    // simulates rolling all dice once
        {
            Craps = RNG.nextInt(Dice);
            RollResult += Craps;    // accumulating sum of all rolls
            Occurence[Craps]++;     // recording each number rolled
        }
        return RollResult;
    } // end Roll
    
    public int Roll(int NumRolls)    // rolls dice an input amount of times and stores occurences          
    {
        int Craps;    // to transfer number rolled to RollResult and Occurences
        
        for(int i = 1; i <= NumRolls; i++)    // looping amount of rolls
        {
            for(int j = 1; j <= TotNumDice; j++)    // looping amount of dice
            {    
                Craps = RNG.nextInt(Dice);
                RollResult += Craps;    // accumulating sum of all rolls
                Occurence[Craps]++;     // recording each number rolled
            }
        }    
        return RollResult;
    } // end Roll
    
    public void PrintStatistics()    // prints the amount of occurences that each face was rolled                     
    {
        System.out.print("Occurences" + "\n");
        
            for(int i = 0, j = 0; i <= Occurence.length && j <= Occurence.length; i++, j++)
            {
                System.out.println(j + ":" + Occurence[i]);
            }
    } // end PrintStats
    
} // end Assignment 8 Dice