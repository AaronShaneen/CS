/*
Aaron Shaneen
Class Examples Constructors
*/

#include <iostream>
using namespace std;

class alpha
{
private:

	int data;

public:

	alpha() {}			// default constructor

	alpha(int d)		// one arg constructor
	{
		data = d;
	}

	alpha(alpha& a)		// copy constructor
	{
		data = a.data;

		cout << "Copy constructor invoked." << endl;
	}

	void display()		// getter...ish
	{
		cout << data << endl;
	}

	alpha operator = (alpha& a)		// overloaded = operator
	{
		data = a.data;

		cout << "Assignment operator invoked." << endl;

		return alpha(data);
	}
}; // end alpha

int main()
{
	alpha a1(37);
	alpha a2;

	a2 = a1;			// assignment operator

	cout << "a2 = ";
	a2.display();

	alpha a3 = a2;		// copy constructor

	cout << "a3 = ";
	a3.display();

	alpha a4(a1);		// copy constructor

	cout << "a4 = ";
	a4.display();

	return 0;
} // end main