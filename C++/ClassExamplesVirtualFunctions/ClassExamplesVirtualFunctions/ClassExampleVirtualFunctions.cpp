/*
Aaron Shaneen
Class Examples Virtual Functions
*/

#include <iostream>
using namespace std;

class person
{
protected:

	char name[40];
	static int total;
	int id;

public:

	person()
	{
		total++;
		id = total;
	}

	virtual ~person()	// virtual destructor
	{
		total--;

		cout << "Base destroyed!" << endl;
	}

	void getName()	// setter
	{
		cout << "Enter name: " << endl;
		cin >> name;
	}

	void putName()	// getter
	{
		cout << "Name is: " << name << endl;
	}

	virtual void getData() = 0;			// pure virtual function
	
	virtual bool isOutstanding() = 0;	// having one pure virtual function
										// makes person an abstract class
	static void showTotal()
	{
		cout << "Total is: " << total << endl;
	}

}; // end person

int person :: total = 0;

class student : public person
{
private:

	float gpa;

public:

	~student()
	{
		cout << "Student destroyed!" << endl;
	}

	void getData()
	{
		cout << "getData in student is called." << endl;

		person :: getName();

		cout << "Enter GPA: " << endl;
		cin >> gpa;
	}

	bool isOutstanding()
	{
		return (gpa > 3.5) ? true : false;
	}
}; // end student

class professor : public person
{
private:

	int numPubs;

public:

	~professor()
	{
		cout << "Professor destroyed!" << endl;
	}

	void getData()
	{
		cout << "getData in professor is called." << endl;

		person :: getName();
		
		cout << "Enter number of publications: " << endl;
		cin >> numPubs;
	}

	bool isOutstanding()
	{
		return (numPubs > 10) ? true : false;
	}
}; // end professor

int main()
{
	person* persPtr[3];

	persPtr[0] = new student;
	person :: showTotal();

	persPtr[1] = new professor;
	person :: showTotal();

	persPtr[2] = new student;
	person :: showTotal();

	//person* ptr;
	//ptr = new student;
	//delete ptr;

	//person* notworking = new person;	// doesn't work because person is an abstract class

	for(int i = 0; i < 3; i++)
	{
		persPtr[i]->getData();
	}

	for(int i = 0; i < 3; i++)
	{
		persPtr[i]->putName();

		if(persPtr[i]->isOutstanding())
		{
			cout << "This person is outstanding!" << endl;
		}
	}

	//delete[] persPtr;

	return 0;
} // end main