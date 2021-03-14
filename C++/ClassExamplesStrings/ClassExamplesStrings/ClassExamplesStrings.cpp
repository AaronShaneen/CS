/*
Aaron Shaneen
Class Examples Strings
Arrays and Strings in action
*/

#include<iostream>
#include<cstring>
#include<string>
using namespace std;

int main()
{
	const int MAX = 80;
	char str[MAX];

	// Cstring
	string str;
	string strcopy;

	cout << "Enter a string: ";
	cin >> str;
	
	cout << "Your entered, " << str << endl;
	
	char strcon[] = "It is a beautiful day!";

	strcopy(str, strcon);
	cout << str << endl;

	// C++ String
	string s1("Man");
	string s2 = "Beast";
	string s3;

	s3 = s1;
	cout << "s3 = " << s3 << endl;

	s3 = "Neither " + s1 + " nor ";
	s3  += s2;
	
	// swap = swaps two string objects
	s1.swap(s2);					// swaps s1 with s2 and s2 with s1
	cout << "s2 = " << s2 << endl;
	cout << "s1 = " << s1 << endl;

	// find
	s1 = "I am a student.";
	int n;
	n = s1.find("student");			// finds the index of the first char of "student" w/ 's' at 7, returns a negative if no such substring
	cout << "Found student at: " << n << endl;

	// find_first_of
	n = s1.find_first_of("a");		// finds first letter of
	cout << "Found first letter a at: " << n << endl;

	// erase
	s1.erase(0, 2);				// 1st arg is position, 2nd arg which index to erase
	cout << "s1 = " << s1 << endl;

	// replace
	s1.replace(7, 7, s2);		// 1st arg is position, 2nd # of chars to be replaced, 3rd arg to replace with
	cout << "s1 = " << s1 << endl;

	// insert
	s1.insert(5, "not ");				// 1st arg is position, 2nd arg to replace with
	cout << "s1 = " << s1 << endl;

	// compare strings
	string userName;
	string aName = "David";

	cout << "Enter your first name: ";
	cin >> username;

	if(userName == aName)
	{
		cout << "Greetings David\n";
	}
	else if(userName < aName)
	{
		cout << "Before David\n";
	}
	else
	{
		cout << "After David\n";
	}
	
	// compare chars in strings
	n = userName.compare(0, 2, aName, 0, 2);	// position, # of chars, comparison, position, # of chars
	if(n == 0)		// n > 0 if before, 0 if matched, n > 0 if after
	{
		cout << "Match\n";
	}

	// access chars in strings
	int len = s1.length();
	for(int j = 0; j < len; j++)
	{
		cout << s1.at(j);		// files through chars in a string
	}

	return 0;
} // end main