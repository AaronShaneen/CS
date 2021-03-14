/*
Aaron Shaneen
Class Examples This
*/

#include <iostream>
using namespace std;

class where()
{
private:



public:
	
void display()
{
	cout << alpha << endl;
}

where& operator = (where& a)
{
	alpha = a.alpha;
	cout << "Assignment operator involved." << endl;
	return *this;
}

void reveal()
{
	cout << "My object's address is: " << this;
}

} // end where

int main()
{
	where w1, w2, w3;
	w1.reveal();
	w2.reveal();
	w3.reveal();

	cout << endl;

	w1.tester();

	where a1(37), a2, a3;

	a3 = a2 = a1;

	cout << "\na2 = ";
	a2.display();

	cout << "\na3 = ";
	a3.display();

	return 0;
}