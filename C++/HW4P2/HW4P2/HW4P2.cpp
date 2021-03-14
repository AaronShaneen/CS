/*
Aaron Shaneen
Homework 4 Problem 2
Simulates a bank account with
credit deposits and debit withdraws
*/

#include<iostream>
using namespace std;

class account	// Account Class
{
private:	// private member variables

	double balance;

public:		// public member functions

	account(double amount)		// account constructor
	{
		if(amount < 0.0)		// if account is initialized to an amount less than zero an error message occurs and balance is set to zero
		{
			cout << "Initial balance is invalid." << endl;

			balance = 0;
		}

		else    // otherwise a valid initial balance is assigned
		{
			balance = amount;
		}
	}	// end constructor

	void credit(double amount)	// adds an amount to account balance
	{
		balance += amount;
	}	// end credit

	void debit(double amount)	// withdraws an amount from account balance
	{
		if(amount > balance)	// if amount is more than balance prints error message and does not withdraw
		{
			cout << "Debit amount exceeded account balance." << endl;
		}

		else    // if amount is less or equal to balance amount is withdrawn
		{
			balance -= amount;
		}
	}	// end debit

	double getBalance() const		// account balance getter
	{
		return balance;
	}

};	// end account

int main()		// main function
{
	account Acct0(-1000.0);		// initialized with an invalid amount
	
	cout << "The balance for Account 0 is: " << Acct0.getBalance() << endl;		// shows balance after an invalid amount was initialized

	
	account Acct1(1000.0);		// initialized with $1000

	cout << "The balance for Account 1 is: " << Acct1.getBalance() << endl;		// shows initialized balance

	Acct1.debit(500.0);		// withdraw made of $500

	cout << "The balance for Account 1 is: " << Acct1.getBalance() << endl;		// shows new balance after withdraw

	Acct1.credit(500.0);		// deposit made of $500

	cout << "The balance for Account 1 is: " << Acct1.getBalance() << endl;		// shows new balance after deposit

	
	account Acct2(2000.0);		// a new account initialized with $2000

	cout << "The balance for Account 2 is: " << Acct2.getBalance() << endl;		// shows initialized balance
	
	Acct2.debit(2500.0);		// a withdraw made for 2500 (which is more than the balance)
	
	cout << "The balance for Account 2 is: " << Acct2.getBalance() << endl;		// shows the unchanged balance after an invalid withdraw

	Acct2.credit(2500.0);		// a deposit made of $2500 instead

	cout << "The balance for Account 2 is: " << Acct2.getBalance() << endl;		// shows the new balance after deposit

	return 0;
}	// end main