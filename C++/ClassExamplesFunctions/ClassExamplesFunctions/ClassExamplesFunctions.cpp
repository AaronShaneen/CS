/*
Aaron Shaneen
Class Examples Functions
Random Functions
*/

#include<iostream>
using namespace std;

int max(int, int);
void swap(int&, int&);			// "&" passes the variable in by reference, default gets passed by value
inline float lbstokg(float);
void repchar(char = '*', int = 45);

float getavg(float newdata)		// static variables lifetime lasts as long as the program's lifetime
{
	static float total = 0;
	static int count = 0;
	count++;
	total += newdata;
	return total / count;
}

int main()
{
	int int1, int2;
	int1 = 10;
	int2 = 23;

	cout << max(int1, int2) << endl;
	cout << max(5, 8) << endl;

	cout << "before calling swap\n";
	cout << "int1 = " << int1 << " and int2 = " << int2 << endl;

	swap(int1, int2);

	cout << "before calling swap\n";
	cout << "int1 = " << int1 << " and int2 = " << int2 << endl;

	float pd = 4.6F;
	float kg = 0.453592 * pd;
	cout << kg << endl;

	repchar();
	repchar('-');
	repchar('+', 30);
	repchar(30);

	float data = 1;
	float avg;
	while(data != 0)
	{
		cout << "Enter a number: ";
		cin >> data;
		avg = getavg(data);
		cout << "New average is: " << avg << endl;
	}

	return 0;
}

int max(int a, int b)
{
	if(a < b)
	{
		return b;
	}
	else
	{
		return a;
	}
}

void swap(int& a, int& b)
{
	int temp;
	temp = a;
	a = b;
	b = temp;
}

inline float lbstokg(float pounds)		// "inline" replaces every function call with the actual function line
{
	return 0.453592 * pounds;
}

void repchar(char ch, int n)
{
	for(int i = 0; i < n; i++)
	{
		cout << ch;
	}
	cout << endl;
}