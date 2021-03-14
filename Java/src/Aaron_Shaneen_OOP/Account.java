/*
 * Daniel Beus
 * Assignment 9/10 Account parent
 * Used to create Savings, Checking, IRA classes
 */

package Aaron_Shaneen_OOP;

import java.io.Serializable;

public abstract class Account implements Readable, Writable, Serializable
{
    protected static int accounts;

    protected double amount;
    protected int acctNumber;
    
    public double GetAmount() { return amount; }
    public double GetAccount() { return acctNumber; }
    
    public Account(double amount)
    {
        this.acctNumber = 1000 + ++accounts;
        this.amount = amount;
    }

    public abstract double Deposit(double amount) throws IllegalArgumentException;
    public abstract double Withdraw(double amount) throws NotEnoughFundsException, IllegalArgumentException;
    public abstract double Transfer(Account acct, double amount) throws NotEnoughFundsException, IllegalArgumentException;
    
    protected void Clone(Object acct)
    {
        if(acct == this)
            return;
        if(!(acct instanceof Account))
            return;
        
        Account temp = (Account) acct;
        this.acctNumber = temp.acctNumber;
        this.amount = temp.amount;
    }

    @Override
    public final String toString()
    {
        return this.getClass().getName() + "\n"
                + "\tAccount Number: " + acctNumber + "\n"
                + "\tAmount: " + amount;
    }
}