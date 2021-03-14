/*
Aaron Shaneen
Class Examples This This
*/

#include <iostream>
using namespace std;

class base
{
protected:

	int ba;

public:

	base() : base(0) {}

	base(int b) : ba(b) {}

	void show()
	{
		cout << "Base: ba = " << ba << endl;
	}

	virtual void verFunc() {}

}; // end base

class derv1 : public base
{
private:

	int da;

public:

	derv1() : da(0)
	{

	}

	derv1(int b, int d) : da(d)
	{
		ba = b;
	}

	void show()
	{
		cout << "derv1: da = " << ba << endl;
	}
}; // end derv1

class derv2 : public base
{
}; // end derv2

bool isDerv1(base* pUnknown)
{
	derv1* pDerv1;
	
	if(pDerv1 = dynamic_cast<derv1*>(pUnknown))
	{
		return true;
	}

	else
	{
		return false;
	}
} // end isDerv1

int main()
{
	derv1* d1 = new derv1;
	derv2* d2 = new derv2;

	if(isDerv1(d1))
	{
		cout << "d1 is a member of the derv1 class." << endl;
	}

	else
	{
		cout << "d2 is a member of the derv2 class." << endl;
	}

	if(isDerv1(d2))
	{
		cout << "d2 is a member of the derv1 class." << endl;
	}

	else
	{
		cout << "d1 is a member of the derv2 class." << endl;
	}

	return 0;
}