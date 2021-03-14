/*
 * Aaron Shaneen
 * Assignment 11 Exception Class
 * Contains exceptions to be thrown with Assignment 10
 */

package Aaron_Shaneen_OOP;

public class NotEnoughFundsException extends Exception
{
    public NotEnoughFundsException() // exception constructor
    {
        super();
    }
    
    public NotEnoughFundsException(String Message) // constructor with a string passed in
    {
        super(Message);
    }
} // end NotEnoughFundsException