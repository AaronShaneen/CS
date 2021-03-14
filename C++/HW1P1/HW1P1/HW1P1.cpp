/*
Aaron Shaneen
Homework 1 Problem 1
Simulates interest accrued on a given amount
*/

#include <iostream>
using namespace std;

int main()
{
	int years;
	double amount, rate;

	cout << "Enter initial amount: " << endl;
	cin >> amount;

	cout << "Enter a number of years: " << endl;
	cin >> years;

	cout << "Enter an interest rate (percentage per year): " << endl;
	cin >> rate;

	rate /= 100;		// converts an annual percentage rate to decimal form

	for(int i = 0; i < years; i++)
	{
		amount += amount * rate;		// calculates amount plus its annual percentage
	}

	cout << "At the end of " << years << " years, you will have " << amount << " dollars." << endl;

	return 0;
}