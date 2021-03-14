/*
 * Aaron Shaneen
 * Assignment 11 Savings
 * Simulates a savings account with depsosits, withdraws, and transfers
 */

package Aaron_Shaneen_OOP;

import java.io.*;

public class Savings extends Account
{
    ObjectOutputStream FileOut = new ObjectOutputStream(); // Probably not the right place but I
    ObjectInputStream FileIn = new ObjectInputStream();    // couldn't get it to work elsewhere
    
    public Savings(double StartAmount)        
    {
        super(StartAmount);
    }
    
    @Override
    public double Deposit(double SavingsDeposit) throws IllegalArgumentException                    
    {
        if(SavingsDeposit <= 0)                                      
        {
            throw new IllegalArgumentException("You cannot deposit a negative amount");
        }
        
        else
        {
            this.amount += SavingsDeposit;
            return SavingsDeposit;                             
        }    
    } // end Deposit
    
    @Override
    public double Withdraw(double SavingsWithdraw) throws IllegalArgumentException, NotEnoughFundsException
    {
        if(SavingsWithdraw <= 0)
        {
            throw new IllegalArgumentException("You cannot withdraw a negative amount.");
        }
        
        if(SavingsWithdraw > this.amount)    
        {                                                             
            throw new NotEnoughFundsException("You cannot withdraw more than your balance.");                 
        }                                                            
        
        else
        {
            this.amount -= SavingsWithdraw;
            return SavingsWithdraw;                  
        }
    } // end Withdraw

    @Override
    public double Transfer(Account Acct, double SavingsTransfer) throws NotEnoughFundsException
    {
        if(SavingsTransfer > Acct.amount)
        {
            throw new NotEnoughFundsException("You cannot transfer more than your balance.");
        }
        
        else
        {
            Acct.amount -= SavingsTransfer;
            this.amount += SavingsTransfer;
            return SavingsTransfer;
        }
    } // end Transfer
    
    public void Read(Account Acct) throws FileNotFoundException, IOException // copies an object to itself
    {
        Savings = FileIn(Acct); // only thing I couldn't figure out
    } // end Read
    
    public void Save(Account Acct) throws FileNotFoundException, IOException // writes itself out to an object
    {
        FileOut.writeObject(Acct);
    } // end Save
} // end Savings