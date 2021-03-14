/*
Aaron Shaneen
MyFirstProgram
I are programmerist
*/

#include <iostream>					// preprocessor directive
#include <cmath>
using namespace std;

int main()
{
	int var1;
	int var2;

	var1 = 10;
	var2 = var1 + 20;

	char character1 = 'A';
	char character2 = '\t';			// tab symbol
	char character3 = '\'';

	cout << "Hellow CS1410!" << endl;
	cout << "var1 + 20 is " << var2 << endl;
	cout << character1 << character2 << character3 << '\n';

	int ftemp;
	cout << "Enter temperature in fahrenheit: ";		// << "put to" operator
	cin >> ftemp;										// >> "get to" operator
	int ctemp = (ftemp - 32) * 5 / 9;
	cout << "Equivalent in Celsius is: " << ctemp << endl;

	float radius = 5.0F;
	const float PI = 3.14159F;
	cout << "Area is " << PI * radius * radius << endl;

	int count = 7;
	float avgWeight = 155.5F;

	double totalWeight = count * avgWeight;		// compiler will auto promote lower types to higher types
	cout << totalWeight << endl;

	count = static_cast<int>(avgWeight);		// type casting
	cout << "After cast, count becomes " << count << endl;		// drops fractional value

	cout << sqrt(count) << endl;

	return 0;
}