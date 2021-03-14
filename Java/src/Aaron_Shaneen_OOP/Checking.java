/*
 * Aaron Shaneen
 * Assignment 11 Checking
 * Simulates a checking account with deposits, withdraws, purchases, and transfers
 */

package Aaron_Shaneen_OOP;

import java.io.*;

public class Checking extends Account implements CreditCard
{
    ObjectOutputStream FileOut = new ObjectOutputStream(); // Probably not the right place but I
    ObjectInputStream FileIn = new ObjectInputStream();    // couldn't get it to work elsewhere
    
    public Checking(double StartAmount)                                
    {
        super(StartAmount);
    }
    
    @Override
    public double Deposit(double CheckingDeposit) throws IllegalArgumentException                     
    {
        if(CheckingDeposit <= 0)                                       
        {
            throw new IllegalArgumentException("You cannot deposit a negative amount");
        }
        
        else
        {
            this.amount += CheckingDeposit;
            return CheckingDeposit;                                 
        }
    } // end Deposit    
    
    @Override
    public double Withdraw(double CheckingWithdraw) throws IllegalArgumentException, NotEnoughFundsException
    {
        if(CheckingWithdraw <= 0)
        {
            throw new IllegalArgumentException("You cannot withdraw a negative amount.");
        }
        
        if(CheckingWithdraw > this.amount)    
        {                                                              
            throw new NotEnoughFundsException("You cannot withdraw more than your balance.");                               
        }
        
        else
        {
            this.amount -= CheckingWithdraw;
            return CheckingWithdraw;                    
        }
    } // end Withdraw
    
    @Override
    public boolean Purchase(double PurchaseAmount)              
    {
        if(PurchaseAmount <= 0)
        {
            return false;
        }
        
        if(PurchaseAmount > this.amount)        
        {                                                               
            return false;                                              
        }
        
        else
        {
            this.amount -= PurchaseAmount;
            return true;                                               
        }
    } // end Purchase
    
    @Override
    public double Transfer(Account Acct, double CheckingTransfer) throws NotEnoughFundsException
    {
        if(CheckingTransfer > Acct.amount)
        {
            throw new NotEnoughFundsException("You cannot transfer more than your balance.");
        }
        
        else
        {
            Acct.amount -= CheckingTransfer;
            this.amount += CheckingTransfer;
            return CheckingTransfer;
        }
    } // end Transfer
    
    public void Read(Account Acct) throws FileNotFoundException, IOException // copies an object to itself
    {
        Checking = FileIn(Acct); // only thing I couldn't figure out
    } // end Read
    
    public void Save(Account Acct) throws FileNotFoundException, IOException // writes itself out to an object
    {
        FileOut.writeObject(Acct);
    } // end Save
} // end Checking