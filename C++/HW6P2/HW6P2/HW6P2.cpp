/*
Aaron Shaneen
Homework 6 Problem 2
*/

#include <iostream>
using namespace std;

class Complex	// Complex class
{
private:	// private members

   double real;	// real part
   double imaginary; // imaginary part

public:	// public members

   Complex(double = 0.0, double = 0.0); // constructor

   Complex operator + (const Complex&) const; // addition

   Complex operator - (const Complex&) const; // subtraction

   bool operator == (const Complex&) const;

   bool operator != (const Complex&) const;

   void print() const; // output
}; // end class Complex

Complex :: Complex(double realPart, double imaginaryPart) : real(realPart), imaginary(imaginaryPart)	// Constructor
{
   // empty body
}

Complex Complex :: operator + (const Complex& operand2) const	// addition operator
{
   return Complex(real + operand2.real, imaginary + operand2.imaginary);
}

Complex Complex :: operator - (const Complex& operand2) const	// subtraction operator
{
   return Complex(real - operand2.real, imaginary - operand2.imaginary);
}

bool Complex :: operator == (const Complex& right) const	// equals to operator
{
   return (right.real == real) && (right.imaginary == imaginary);
}

bool Complex :: operator != (const Complex& right) const	// not equals to operator
{
   return (right.real != real) && (right.imaginary != imaginary);
}

void Complex :: print() const	// display a Complex object in the form: (a, b)
{
   cout << '(' << real << ", " << imaginary << ')';
}

int main()
{
   Complex x;
   Complex y(4.3, 8.2);
   Complex z(3.3, 1.1);

   cout << "x: ";
   x.print();
   cout << "\ny: ";
   y.print();
   cout << "\nz: ";
   z.print();

   x = y + z;
   cout << "\n\nx = y + z:" << endl;
   x.print();
   cout << " = ";
   y.print();
   cout << " + ";
   z.print();

   x = y - z;
   cout << "\n\nx = y - z:" << endl;
   x.print();
   cout << " = ";
   y.print();
   cout << " - ";
   z.print();

   cout << "\n\n";

   if(y == z)	// testing equals operator
   {
	   cout << "y and z are the equal to each other." << endl;
   }

   if(y != z)	// testing not equals operator
   {
	   cout << "y and z are not equal to each other." << endl;
   }

   cout << endl;
} // end main