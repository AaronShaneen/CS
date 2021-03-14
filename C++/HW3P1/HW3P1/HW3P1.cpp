/*
Aaron Shaneen
Homework 3 Problem 1
Calls a function which displays how many
times that function has been displayed
*/

#include<iostream>
using namespace std;

int counterFunction1();		// first counter function using the global variable declared below
int counterFunction2();		// second counter function using a static local variable

int count1 = 0;		// gloabal variable for counterFunction()

int main()
{
	for(int i = 0; i < 10; i++)
	{
		counterFunction1();
	}

	for(int i = 0; i < 10; i++)
	{
		counterFunction2();
	}
	
	return 0;
}

int counterFunction1()		// function using the global variable
{
	count1++;
	cout << "Counter Function 1 has been called " << count1 << " times." << endl;
	return count1;
}

int counterFunction2()		// function using the static local variable
{
	static int count2 = 0;
	count2++;
	cout << "Counter Function 2 has been called " << count2 << " times." << endl;
	return count2;
}

/*
Global variables are useful but for a small program it is okay to show it's usage
but in the real world and in larger programs a static local variable is safer and
more approriate
*/