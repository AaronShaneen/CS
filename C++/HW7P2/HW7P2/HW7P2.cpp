/*
Aaron Shaneen
Homework 7 Problem 2
*/

#include <stdexcept>
#include <iostream>
using namespace std;

class Account
{
public:

   Account(double); // constructor initializes balance
   void credit(double); // add an amount to the account balance
   bool debit(double); // subtract an amount from the account balance
   void setBalance(double); // sets the account balance
   double getBalance(); // return the account balance

private:

   double balance; // data member that stores the balance
}; // end class Account


// Account constructor initializes data member balance
Account :: Account(double initialBalance) : balance(0.0)
{
   // if initialBalance is greater than or equal to 0.0, set this value
   // as the balance of the Account
   if(initialBalance >= 0.0)
   {
      balance = initialBalance;
   }

   else
   {
      throw invalid_argument("Initial balance cannot be negative");
   }
} // end Account constructor

// credit (add) an amount to the account balance
void Account :: credit(double amount)
{
   balance = balance + amount; // add amount to balance
} // end function credit

// debit (subtract) an amount from the account balance
// return bool indicating whether money was debited
bool Account :: debit(double amount)
{
   if(amount > balance) // debit amount exceeds balance
   {
      cout << "Debit amount exceeded account balance." << endl;

      return false;
   } // end if

   else // debit amount does not exceed balance
   {
      balance = balance - amount;

      return true;
   } // end else
} // end function debit

// set the account balance
void Account :: setBalance(double newBalance)
{
   balance = newBalance;
} // end function setBalance

// return the account balance
double Account :: getBalance()
{
   return balance;
} // end function getBalance

int main()
{
	// your testing code:

	return 0;
} // end main