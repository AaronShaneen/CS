/*
Aaron Shaneen
Homework 9 Problem 1
*/

#include <iostream>
#include <string>
using namespace std;

class publication
{
private:

	string title;
	float price;

public:

	virtual void getdata()
    {
		cout << "Enter title: " << endl;
		cin >> title;

        cout << "Enter price: " << endl;
		cin >> price;
    }
    
	virtual void putdata() const
    {
		cout << "Title: " << title << endl;
        cout << "Price: " << price << endl;
    }

	virtual bool isOversize() = 0;
}; // end publication

class book : public publication
{
private:

	int pages;

public:

	void getdata()
    {
		publication :: getdata();

		cout << "Enter number of pages: " << endl;
		cin >> pages;
    }
    
	void putdata() const
    {
		publication :: putdata();

		cout << "Pages: " << pages << endl;
    }

	bool isOversize()
	{
		return (pages > 800) ? true, false;
	}
}; // end book

class tape : public publication
{
private:

	float time;

public:

	void getdata()
    {
		publication :: getdata();

		cout << "Enter playing time in minutes: " << endl;
		cin >> time;
    }
    
	void putdata() const
    {
		publication :: putdata();

		cout << "Time: " << time << endl;
    }

	bool isOversize()
	{
		return (time > 800) ? true, false;
	}
}; // end tape

int main()
{
	publication* pubarr[100];
	char choice;
	int index = 0;

	do
	{
		cout << "Enter data for book or tape (b/t)?" << endl;
		cin >> choice;

		if(choice == 'b')
		{
			pubarr[index] = new book;
		}

		else if(choice == 't')
		{
			pubarr[index] = new tape;
		}

		pubarr[index]->getdata();
		index++;

		cout << "Enter another (y/n)?" << endl;
		cin >> choice;

	} while(choice == 'y');

	for(int i = 0; i < index; i++)
	{
		pubarr[i]->putdata();
	}

	for(int i = 0; i < index; i++)
	{
		delete pubarr[i];
	}

	return 0;
} // end main