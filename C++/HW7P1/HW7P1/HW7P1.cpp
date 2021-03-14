/*
Aaron Shaneen
Homework 7 Problem 1
*/

#include <iostream>
using namespace std;
#include <process.h>           //for exit()
const int LIMIT = 100;         //array size

class safearay
{
protected:

	int arr[LIMIT];
   
public:

	void putel(int n, int elvalue)  // insert an element
	{
		if(n < 0 || n >= LIMIT)
		{ 
			cout << "\nIndex out of bounds\n";
			exit(1);
		}
		
		arr[n] = elvalue;
	}
	  
	int getel(int n)                // get an element
	{
		if(n < 0 || n >= LIMIT)
		{
			cout << "\nIndex out of bounds\n";
			exit(1);
		}
		
		return arr[n];
	}

    int& operator [] (int n)  //note: return by reference
    {
		if(n < 0 || n >= LIMIT)
        {
			cout << "\nIndex out of bounds";
			exit(1);
		}

        return arr[n];
    }

}; // end safearay

class safehilo : public safearay
{
private:

	int lower;
	int upper;

public:

	safehilo()
	{
		lower = 0;
		upper = 0;
	}

	safehilo(int l, int u)
	{
		if(l > u)
		{
			cout << "\nLower is higher than upper\n";
			exit(1);
		}

		if(u - l > LIMIT - 1)
		{
			cout << "\nRange is too large\n";
			exit(1);
		}

		lower = l;
		upper = u;
	}

	int& operator [] (int n)	// overloading []
	{
		if(n < lower || n >= upper)
        {
			cout << "\nIndex out of bounds"; exit(1);
		}
        return arr[n - lower];
	}
}; // end safehilo

int main()
{
	safearay sa1;

	for (int i = 0; i < LIMIT; i++)
	{
		sa1[i] = i * 10;
	}

	for (int i = 0; i < LIMIT; i++)
	{
		cout << sa1[i] << endl;
	}

	//cout << sa1[100] << endl;		// testing out of bounds

	int lower = 10, upper = 14;
	safehilo sh1(lower, upper);

	for (int i = lower; i < upper; i++)
	{
		sh1[i] = i * 10;
	}

	for (int i = lower; i < upper; i++)
	{
		cout << sh1[i] << endl;
	}

	return 0;
} // end main