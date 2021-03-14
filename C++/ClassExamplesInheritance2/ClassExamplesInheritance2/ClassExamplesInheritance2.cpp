/*
Aaron Shaneen
Class Examples Inheritance 2
*/

#include <iostream>
#include <string>
using namespace std;

const int LEN = 80;		// max length of name

class student
{
private:

	char school[LEN];	// name of the school
	char degree[LEN];	// highest degree earned

public:

	void getedu()	// setter
	{
		cout << "\nEnter name of school or university: ";
		cin >> school;

		cout << "\nEnter highest degree earned: ";
		cin >> degree;
	}

	void putedu() const		// getter
	{
		cout << "\nSchool or University: " << school;
		cout << "\nHighest degree earned: " << degree;
	}
}; // end student

class employee
{
private:

	char name[LEN];			// employee name
	unsigned long number;	// employee number

public:

	void getdata()		// get user input for employee
	{
		cout << "\nEnter last name: ";
		cin >> name;

		cout << "\nEnter number: ";
		cin >> number;
	}

	void putdata() const	// display employee info
	{
		cout << "\nName: " << name;
		cout << "\nNumber: " << number;
	}
}; // end employee

class manager : public employee		// dervies employee
{
private:

	char title[LEN];	// such as CEO, COO, etc
	double dues;		// golf club dues

public:

	void getdata()		// overriding getData()
	{
		employee :: getdata();		// calling base getData()

		cout << "\nEnter title: ";
		cin >> title;

		cout << "\nEnter dues: ";
		cin >> dues;
	}

	void putdata() const	// overriding putData()
	{
		employee :: putdata();		// calling base putData()

		cout << "\nTitle: " << title;
		cout << "\nDues: " << dues;
	}
}; // end manager

class manager2
{
private:

	string title;
	double dues;
	employee exp;
	student stu;

public:

	void getdata()
	{
		emp.getdata();
		stu.getedu();

		cout << "\nEnter title: ";
		cin >> title;

		cout << "\nEnter dues: ";
		cin >> dues;
	}

	void putdata()
	{
		emp.putdata();
		stu.putedu();

		cout << "\nTitle: " << title;
		cout << "\nDues: " << dues;
	}
}; // end manager2

class laborer : public employee		// derives employee
{
};

class scientist : private employee, private student
{
private:

	int pubs;	// number of publications

public:

	void getdata()
	{
		employee :: getdata();
		student :: getedu();

		cout << "\nEnter number of publications: ";
		cin >> pubs;
	}

	void putdata() const
	{
		employee :: putdata();
		student :: putedu();

		cout << "\nNumber of publications: " << pubs;
	}
}; // end scientist

int main()
{
	/*manager m1, m2;

	cout << "\nEnter data for manager 1: ";
	m1.getdata();

	cout << "\nEnter data for manager 2: ";
	m2.getdata();

	cout << "\nData on manager 1: ";
	m1.putdata();

	cout << "\nData on manager 2: ";
	m2.putdata();*/

	scientist s1;

	s1.getdata();

	s1.putdata();

	return 0;
} // end main