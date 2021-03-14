/*
 * Aaron Shaneen
 * Assignment 8 Driver
 * Drives Assignment 8 Custom Exercise Dice
 */

package Aaron_Shaneen_OOP;

public class Assignment8DiceDriver
{
    public static void main(String[] args)
    {
        Dice die = new Dice(3);
        System.out.println("You rolled a " + die.Roll());
        die.PrintStatistics();
        
        System.out.println("You rolled a " + die.Roll(4));
        die.PrintStatistics();
        
        die.SetDice(10);
        System.out.println("You rolled a " + die.Roll(2));
        die.PrintStatistics();
        
        die.SetDice(3, 64);
        System.out.println("You rolled a " + die.Roll(1000));
        die.PrintStatistics();
        
        die.SetDice(10);
        System.out.println("You rolled a " + die.Roll(10));
        die.PrintStatistics();
        
        
        die = new Dice(10, 20);
        System.out.println("You rolled a " + die.Roll());
        die.PrintStatistics();
        
        die.SetDice(2);
        System.out.println("You rolled a " + die.Roll(100));
        die.PrintStatistics();

    } // end main
} // end Assignment8Driver
