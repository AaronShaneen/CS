/*
 * Aaron Shaneen
 * Assignment 11 IRA
 * Simulates an IRA account with deposits, withdraws (and a penalty for withdrawing), and transfers
 */

package Aaron_Shaneen_OOP;

import java.io.*;

public class IRA extends Account
{
    ObjectOutputStream FileOut = new ObjectOutputStream(); // Probably not the right place but I
    ObjectInputStream FileIn = new ObjectInputStream();    // couldn't get it to work elsewhere
    
    public IRA(double StartAmount)      
    {
        super(StartAmount);
    }
    
    @Override
    public double Deposit(double IRADeposit) throws IllegalArgumentException                
    {
        if(IRADeposit <= 0)
        {
            throw new IllegalArgumentException("You cannot deposit a negative amount");
        }
        if(IRADeposit > 500)              
        {                                                    
            throw new IllegalArgumentException("You must deposit less than 500 dollars.");
        }
        
        else
        {
            this.amount += IRADeposit;
            return IRADeposit;             
        }
    } // end Deposit
    
    @Override
    public double Withdraw(double IRAWithdraw) throws IllegalArgumentException, NotEnoughFundsException              
    {
        if(IRAWithdraw <= 0)
        {
            throw new IllegalArgumentException("You cannot withdraw a negative amount.");
        }
        
        if(IRAWithdraw > this.amount)    
        {                                                    
            throw new NotEnoughFundsException("You cannot withdraw more than your balance.");                         
        }
        
        else
        {
            this.amount -= IRAWithdraw;
            double interest = this.amount * 0.01;         
            this.amount += interest;                         
            return IRAWithdraw;                   
        }
    } // end Withdraw
    
    @Override
    public double Transfer(Account Acct, double IRATransfer) throws NotEnoughFundsException
    {
        if(IRATransfer > Acct.amount)
        {
            throw new NotEnoughFundsException("You cannot transfer more than your balance.");
        }
        
        else
        {
            Acct.amount -= IRATransfer;
            this.amount += IRATransfer;
            return IRATransfer;
        }
    } // end Transfer
    
    public void Read(Account Acct) throws FileNotFoundException, IOException // copies an object to itself
    {
        IRA = FileIn(Acct); // only thing I couldn't figure out
    } // end Read
    
    public void Save(Account Acct) throws FileNotFoundException, IOException // writes itself out to an object
    {
        FileOut.writeObject(Acct);
    } // end Save
} // end IRA