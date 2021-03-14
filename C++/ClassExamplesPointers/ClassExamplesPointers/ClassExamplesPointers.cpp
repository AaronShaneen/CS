/*
Aaron Shaneen
Class Examples Pointers
*/

#include <iostream>
#include <string>
#include <cstring>
using namespace std;

void centimize(double&);
void centimizeByPointer(double*);
void dispstr(char*);

int main()
{
	int var1 = 11;
	int var2 = 22;

	cout << &var1 << endl;		// &var1/2 prints address
	cout << &var2 << endl;

	int* ptr;					// pointer declaration = type* name;
	
	ptr = &var1;				// assigns var1's addrss to ptr

	cout << ptr << endl;		// print value of pointer (address)
	cout << *ptr << endl;		// print contents of pointer (addresses contents)

	*ptr = 33;					// modifying ptr's value
	var1 = *ptr;				// assigns pointer value to var1
	cout << var1 << endl;

	int intarray[5] = {11, 22, 33, 44, 55};		// intarray holds the address of the first element (is itself a pointer)
												// intarray[i] holds the value of given element
	for(int i = 0; i < 5; i++)					// *intarray will show the contents instad of the address
	{
		//cout << intarray[i] << endl;
		cout << *(intarray + 1) << endl;
	}

	cout << endl;

	double var = 10.0;

	cout << "var = " << var << " inches." << endl; 
	
	centimize(var);

	cout << "var = " << var << " centimeters." << endl; 

	var = 10.0;
	
	cout << "var = " << var << " centimeters." << endl;	//centimizeByPointer(&var); 

	double darray[5] = {10.0, 43.1, 99.6, 27.3, 87.2};

	centimizeByPointer(darray);
	
	for(int i = 0; i < 5; i++)
	{
		cout << "darray[" << i << "]: " << darray[i] << endl;
	}

	char str1[] = "Defined as an array";
	char* str2 = "Defined as a pointer";
	cout << str1 << endl;
	cout << str2 << endl;

	//str1++;
	str2++;
	dispstr(str2);

	int len = strlen(str1);
	char* ps;
	ps = new char[len + 1];
	strcpy_s(ps, len + 1, str1);
	cout << "ps = " << ps << endl;

	delete[] ps;

	return 0;
} // end main


void centimize(double& v)	// convert a value in inches to a value in centimeters
{
	v *= 2.54;
}

void centimizeByPointer(double* ptrd)
{
	for(int i = 0; i < 5; i++)
	{
		*(ptrd++) *= 2.54;
	}
	
}

void dispstr(char* ps)
{
	while(*ps)
	{
		cout << *ps++;
	}

	cout << endl;
}