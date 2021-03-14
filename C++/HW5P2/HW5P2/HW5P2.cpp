/*
Aaron Shaneen
Homework 5 Problem 2
Deletes a substring from a user input string
*/

#include<iostream>
#include<string>
using namespace std;

void eraseSubstring(string& input, string substr);

int main()
{
	string someStr;

	cout << "Enter a string: " << endl;
	cin >> someStr;						// inputs user's string into someStr

	eraseSubstring(someStr, "by");		// works with any string containing "by"
	eraseSubstring(someStr, "BY");		// works with any string containing "BY"

	cout << someStr << endl;			// prints new modified string

	return 0;
} // end main

void eraseSubstring(string& input, string subStr)
{
	int x = input.find(subStr);		// returns the position of the substring to x

	input.erase(x, 2);				// uses x to position the erasing function
}