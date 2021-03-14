/*
Aaron Shaneen
Class Examples Operator Overloading
Operators in action
*/

#include<iostream>
using namespace std;

class Counter
{
private:

	unsigned int count;

public:
	
	Counter() : count(0) {}

	Counter(int x) : count(x) {}

	/*void inc_count()		// normal incrementing
	{
		count++;
	}*/

	Counter operator ++ ()		// overloads ++pre operator
	{
		++count;

		return Counter(++count);	// returns incremented Counter object

		/*Counter temp;

		temp.count = count;

		return temp;*/
	}

	Counter operator ++ (int)	// overloads post++ operator
	{
		return Counter(count++);
	}

	int get_count() const
	{
		return count;
	}
};

int main()
{
	Counter c1, c2;

	cout << "C1 is: " << c1.get_count() << endl;
	cout << "C2 is: " << c2.get_count() << endl;
	
	++c1;
	++c1;
	++c2;

	c2 = ++c1;	// c1 = 3, c2 = 3
	c2 = c1++;	// c1 = 4, c2 = 3

	/*c1.inc_count();
	c1.inc_count();
	c2.inc_count();*/

	cout << "C1 is: " << c1.get_count() << endl;
	cout << "C2 is: " << c2.get_count() << endl;

	return 0;
}