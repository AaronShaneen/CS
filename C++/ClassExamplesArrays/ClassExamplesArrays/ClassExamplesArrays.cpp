/*
Aaron Shaneen
Class Examples Arrays
Arrays in Action
*/

#include <iostream>
using namespace std;

class Stack
{

private:

	const static int MAX = 10;
	// enum {MAX = 10};
	int st[MAX];
	int top;

public:

	Stack()
	{
		top = -1;	
	}
	void push(int var){
		cout << top << endl;
		st[++top] = var;
		cout << top << endl;

	}

	int pop(){
		return st[top--];
	}

};

//int const Stack::MAX = 10;

int main()
{
	int days_per_month[] = { 31, 28, 31, 30, 31, 30,
							   31, 31, 30, 31, 30, 31};

	int coins[6] = {1, 5, 10, 25, 50, 100};

	/*
	int age[4];

	for(int j=0; j<4; j++){
		cout << "Enter an age: ";
		cin >> age[j];
	}

	for(int j=0; j<4; j++){
		cout << "You entered: " << age[j] << endl;
	}
	*/

	Stack s1;
	s1.push(11);
	s1.push(22);
	s1.push(33);

	cout << "1: " << s1.pop() << endl;
	cout << "2: " << s1.pop() << endl;

	s1.push(44);
	s1.push(55);

	cout << "3: " << s1.pop() << endl;
	cout << "4: " << s1.pop() << endl;
	cout << "5: " << s1.pop() << endl;

	return 0;
}