/*
Aaron Shaneen
Homework 8 Problem 1
*/

#include <iostream>
using namespace std;

int compstr(char*, char*);

int main()
{
	cout << compstr("cats", "rats") << endl;
	cout << compstr("calm", "call") << endl;
	cout << compstr("cat", "cats") << endl;
	cout << compstr("cat", "cat") << endl;
	cout << compstr("He was wet", "He was set") << endl;

	return 0;
} // end main

int compstr(char* s1, char* s2)
{
	char ch1, ch2;

	while(1)
	{
		ch1 = *s1++;
		ch2 = *s2++;

		if(ch1 < ch2)
		{
			return -1;
		}

		else if(ch1 > ch2)
		{
			return 1;
		}

		else
		{
			if(!ch1 && !ch2)
			{
				return 0;
			}
		}
	} // end while loop
} // end compstr