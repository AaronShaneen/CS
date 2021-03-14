/*
Aaron Shaneen
Homework 3 Problem 2
Contains two functions that triple a
given amount by reference and by value
*/

#include<iostream>
using namespace std;

int tripleByValue(int x);		// this function triples user input by value
int tripleByRef(int& y);		// this function triples user input by reference

int main()
{
	int byValueVar;		// by value variable
	int byRefVar;		// by reference variable

	cout << "Enter a number to triple by value: ";			
	cin >> byValueVar;															

	cout << "Your number before the function call: " << byValueVar << endl;		// before function call
	tripleByValue(byValueVar);													// passing/multiplying by value
	cout << "Your number after the function call: " << byValueVar << endl;		// after function call

	cout << "Enter a number to triple by reference: ";
	cin >> byRefVar;															

	cout << "Your number before the function call: " << byRefVar << endl;		// before function call
	tripleByRef(byRefVar);														// passing/multiplying by reference
	cout << "Your number after the function call: " << byRefVar << endl;		// after function call

	return 0;
}

int tripleByValue(int x)	// by value function
{
	x *= 3;
	return x;
}

int tripleByRef(int& y)		// by reference function
{
	y *= 3;
	return y;
}