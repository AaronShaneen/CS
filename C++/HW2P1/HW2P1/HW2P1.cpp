/*
Aaron Shaneen
Homework 2 Problem 1
Builds a time structure with user input and
calculates the amount of seconds in that time
*/

#include<iostream>
using namespace std;

struct time
{
	int hours;
	int mins;
	int secs;
};

int main()
{
	time time1;

	cout << "Enter hours: ";
	cin >> time1.hours; 

	cout << endl;
	cout << "Enter minutes: ";
	cin >> time1.mins;

	cout << endl;
	cout << "Enter seconds: ";
	cin >> time1.secs;

	long totalsecs = time1.hours * 3600 + time1.mins * 60 + time1.secs;

	cout << endl;
	cout << "The total amount of seconds in the amount of time entered: "<< totalsecs << endl;

	return 0;
}