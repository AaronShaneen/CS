/*
Aaron Shaneen
Homework 4 Problem 1
Creates and counts objects and assigns
appropriate serial numbers to each
*/

#include<iostream>
using namespace std;

class serial	// Serial Class
{
private:	// private member variables

	int serialNum;
	static int count;

public:		// public member functions

	serial()	// serial constructor
	{
		count++;				// increments count for amount of serial numbers created
		serialNum = count;		// sets serial number to which serial is created
	}

	int getSerialNum()	const	// serial number getter
	{
		return serialNum;
	}

};	// end serial class

int serial::count = 0;		// definition of static private variable

int main()		// main function
{
	serial serial1, serial2, serial3;		// creating 3 serial numbers

	cout << "I am object number " << serial1.getSerialNum() << endl;	// shows first serial number's number
	cout << "I am object number " << serial2.getSerialNum() << endl;	// shows seconds serial number's number
	cout << "I am object number " << serial3.getSerialNum() << endl;	// shows third serial number's number

	return 0;
}	// end main