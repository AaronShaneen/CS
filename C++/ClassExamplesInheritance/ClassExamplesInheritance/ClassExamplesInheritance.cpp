/*
Aaron Shaneen
Class Examples Inheritance
*/

#include <iostream>
using namespace std;

class Counter
{
protected:

	unsigned int count;		// not private

public:

	Counter() : count(0)	// default constructor
	{
		cout << "Ctor in Base Class is called!" << endl;
	}

	Counter(int c) : count(c) {}	// single arg constructor

	unsigned int getCount() const	// getter
	{
		return count;
	}

	Counter operator ++ ()		// overloaded prefix ++ operator
	{
		return Counter(++count);
	}
}; // end Counter

class CountDn : public Counter		// derived class of Counter
{
public:

	CountDn() : Counter()	// derived default constructor
	{
		cout << "Ctor in Derived Class is called!" << endl;
	}

	CountDn(int c) : Counter(c) {}	// derived single arg constructor

	unsigned int getCount() const	// ovveriding getCount
	{
		cout << "I am about to return the count!" << endl;
		return count;
	}

	Counter operator -- ()		// overloaded prefix -- operator, already has ++prefix
	{
		return Counter(--count);
	}
}; // end CountDn

int main()
{
	CountDn c1;

	cout << "\nc1 = " << c1.getCount();

	++c1;
	++c1;
	++c1;

	cout << "\nc1 = " << c1.getCount();

	--c1;
	--c1;

	cout << "\nc1 = " << c1.getCount();

	cout << endl;

	return 0;
} // end main