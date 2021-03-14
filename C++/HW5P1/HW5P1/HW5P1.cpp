/*
Aaron Shaneen
Homework 5 Problem 1
Builds and tests a safe array
*/

#include<iostream>
#include<cstdlib>
using namespace std;

const int LIMIT = 10;	// global variable

class safearay
{
private:	// private members

	int myArray[LIMIT];

public:		// public members

	void putel(int index, int val)    // insert an element
	{
		if(index < 0 || index >= LIMIT)
		{
			cout << "Index out of bounds." << endl;
			exit(1);
		}

		myArray[index] = val;
	} // end putel

	int getel(int index)	// get an element
	{
		if(index < 0 || index >= LIMIT)
		{
			cout << "Index out of bounds." << endl;
			exit(1);
		}

		return myArray[index];
	} // end getel

}; // end safearay class

int main()
{
	safearay sa1;

	// test putel for too high an index
	for(int j = 0; j < LIMIT; j++)	// for(int j = 0; j < LIMIT + 1; j++)
	{
		cout << "About to insert at index " << j << endl;
		sa1.putel(j, j);
	}

	// test getel for too low an index
	for(int j = -1; j < LIMIT; j++)
	{
		cout << "About to insert at index " << j << endl;
		sa1.getel(j);
	}

	return 0;
} // end main