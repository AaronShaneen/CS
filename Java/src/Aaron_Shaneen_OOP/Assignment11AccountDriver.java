/*
 * Daniel Beus
 * Assignment 10 Driver
 * Drives Assignment 10 Classes Savings, Checking, IRA
 */

package Aaron_Shaneen_OOP;

import java.io.FileNotFoundException;
import java.io.IOException;
import java.util.Scanner;

public class Assignment11AccountDriver
{
    private static Scanner input;    // global variable
    
    public static void main(String[] args)
    {
        Account savings = new Savings(5000);
        Account checking = new Checking(1000);
        Account ira = new IRA(0);

        input = new Scanner(System.in);

        String cont;

        do
        {
            Account currentAccount;
            System.out.print("Please enter the account you'd like to use (S/C/I): ");
            String user = input.next();
            
            switch (user.toLowerCase().charAt(0)) {
                case 's':
                    currentAccount = savings;
                    break;
                case 'c':
                    currentAccount = checking;
                    break;
                default:
                    currentAccount = ira;
                    break;
            }

            System.out.print("Would you like to withdraw, deposit, transfer, read, save, or print (W/D/T/R/S/P)? ");
            user = input.next();
            
            switch (user.toLowerCase().charAt(0)) {
                case 'w':
                    String className = currentAccount.getClass().getName();
                    int index = className.lastIndexOf(".");
                    if(className.substring(index + 1, className.length()).equalsIgnoreCase("Checking"))
                    {
                        System.out.print("Would you like to make a purchase, or withdrawal (W/P)? ");
                        user = input.next();
                        switch(user.toLowerCase())
                        {
                            case "p":
                                MakePurchase((Checking)currentAccount);
                                break;
                            default:
                                Withdraw(currentAccount);
                                break;
                        }
                    }
                    else
                        Withdraw(currentAccount);
                    break;
                case 'd':
                    Deposit(currentAccount);
                    break;
                case 't':
                    System.out.print("What account would you like to transfer from (S/C/I)? ");
                    user = input.next();
                    Account temp;
                    switch(user.toLowerCase())
                    {
                        case "s":
                            temp = savings;
                            break;
                        case "c":
                            temp = checking;
                            break;
                        default:
                            temp = ira;
                            break;
                    }
                    Transfer(currentAccount, temp);
                    break;
                case 'r':
                    Read(currentAccount);
                    break;
                case 's':
                    Save(currentAccount);
                    break;
                default:
                    System.out.println(currentAccount);
                    break;
            }

            System.out.print("Would you like to continue (y/n)? ");
            cont = input.next();
        } while(cont.toLowerCase().equals("y"));
    }
        
    public static void Withdraw(Account acct)
    {
        System.out.print("How much would you like to withdraw? ");
        double amount = input.nextDouble();
        
        try
        {
            amount = acct.Withdraw(amount);
            System.out.println(amount + " has been withdrawn.");
        }
		catch(IllegalArgumentException iae)
		{
			System.out.println(amount + " is not a valid amount.");
		}
        catch(NotEnoughFundsException nefe)
        {
            System.out.println(amount + " could not be withdrawn because of insufficient funds.");
        }
    }
        
    public static void Deposit(Account acct)
    {
        System.out.print("How much would you like to deposit? ");
        double amount = input.nextDouble();
		try
		{
	        amount = acct.Deposit(amount);
	        System.out.println(amount + " has been depositted.");
		}
		catch(IllegalArgumentException iae)
		{
			System.out.println(amount + " is not a valid amount.");
		}
    }
    
    public static void MakePurchase(CreditCard card)
    {
        System.out.print("How much are you trying to spend? ");
        double amount = input.nextDouble();
        if(card.Purchase(amount))
            System.out.println(amount + " has been spent.");
        else
            System.out.println(amount + " could not be spent for some reason.");
    }
    
    public static void Transfer(Account to, Account from)
    {
        System.out.print("How much would you like to transfer? ");
        double amount = input.nextDouble();
        
        try
        {
            to.Transfer(from, amount);
        }
		catch(IllegalArgumentException iae)
		{
			System.out.println(amount + " is not a valid amount.");
		}
        catch (NotEnoughFundsException nefe)
        {
            System.out.println("Could not transfer funds because of not enough funds.");
            System.out.println(nefe.getMessage());
        }
    }

    private static void Read(Readable currentAccount)
    {
        System.out.print("Where would you like to read: ");
        String path = input.nextLine();
        
        try
        {
            currentAccount.Read(path);
        }
        catch(FileNotFoundException fnfe)
        {
            System.out.println("Could not find file " + path);
            System.out.println(fnfe.getMessage());
        }
        catch(IOException ioe)
        {
            System.out.println(ioe.getMessage());
        }
        catch(Exception e)
        {
            System.out.println("Something went wrong. Sorry. " + e.getMessage());
        }
    }

    private static void Save(Writable currentAccount)
    {
        System.out.print("Where would you like to save: ");
        String path = input.nextLine();
        
        try
        {
            currentAccount.Save(path);
        }
        catch(FileNotFoundException fnfe)
        {
            System.out.println("Could not find file " + path);
            System.out.println(fnfe.getMessage());
        }
        catch(IOException ioe)
        {
            System.out.println(ioe.getMessage());
        }
        catch(Exception e)
        {
            System.out.println("Something went wrong. Sorry. " + e.getMessage());
        }
    }
}