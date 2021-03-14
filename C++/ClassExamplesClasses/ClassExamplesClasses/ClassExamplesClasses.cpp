/*
Aaron Shaneen
Class Examples Classes
Demonstrating classes and their functionality
*/

#include<iostream>
using namespace std;

class Distance
{
private:

	int feet;
	float inches;
	static int count;
	float MTF;	// meters-to-feet
	
public:

	Distance() : feet(0), inches(0.0), MTF(3.280833F)	// constructor with no arguments using initializer list
	{		
		count++;
	}

	Distance(int ft, float in) : feet(ft), inches(in), MTF(3.280833F)	// constructor with two arguments using initializer list
	{ 
		count++;	
	}
	
	explicit Distance(float meters) : MTF(3.280833F)	// constructor used to convert meters to Distance
	{
		float fltfeet = MTF * meters;	// convert to float feet

		feet = int(fltfeet);			// feet is int part

		inches = 12 * (fltfeet - feet);	// inches in what is left
	}

	~Distance(){}	// destructor

	void getdist()	// get user inputs for feet and inches
	{
		cout << "\nEnter feet: ";
		cin >> feet;
		cout << "\n Enter inches: ";
		cin >> inches;	
	}

	void showdist()	const	// display distance; constant member function
	{
		cout << feet << "\'" << inches << "\"" << endl;	
	}

	//Distance add_dist(Distance);			// add two distances
	Distance operator + (Distance) const;	// overload operator + for Distance class

	int getcount() const	// return count, a constant member function
	{		
		return count;
	}

	
	bool operator < (Distance) const;	// overload < to compare distances
	void operator += (Distance);

	operator float() const		// conversion operator
	{
		float fracfeet = inches / 12;			// convert to inches
		fracfeet += static_cast<float>(feet);	// add the feet
		return fracfeet / MTF;					// convert to meters
	}
}; // end Distance


int Distance :: count = 0;		// definition of count

/*
Distance Distance::add_dist(Distance d2)
{
	Distance temp;
	temp.inches = inches + d2.inches;
	temp.feet = 0;
	if(temp.inches >= 12.0){
		temp.inches -= 12.0;
		temp.feet++;	
	}
	temp.feet += feet + d2.feet;
	return temp;

}
*/

Distance Distance :: operator + (Distance d2) const
{
	int f = feet + d2.feet;
	float i = inches + d2.inches;
	
	if( i >= 12.0 )
	{
		i -= 12.0;
		f++;
	}

	return Distance(f, i);
}

bool Distance :: operator < (Distance d2) const
{
	float f1 = feet + inches / 12;
	float f2 = d2.feet + d2.inches / 12;

	return (f1 < f2) ? true : false;
}

void Distance :: operator += (Distance d2)
{
	feet += d2.feet;
	inches += d2.inches;
	
	if(inches >= 12.0)
	{
		inches -= 12.0;
		feet++;
	}
}

int main()
{
	Distance d1;

	cout << d1.getcount() << endl;

	Distance d2(2, 6.3);

	cout << d1.getcount() << endl;

	Distance d3(3, 8.5);

	cout << d1.getcount() << endl;

	Distance d4;

	cout << d1.getcount() << endl;

	d1.getdist();
	//d2.getdist();
	//d3.add_dist(d1, d2);
	//d3 = d1.add_d(d2);

	d3 = d1 + d2;

	d3.showdist();
	d4.showdist();

	const Distance football(300, 0);

	//football.getdist();
	football.showdist();

	/*
	Distance distarray[100];

	char ans;
	int n = 0;

	do
	{
		cout << "Enter distance number" << n+1;
		distarray[n++].getdist();
		cout << "Enter another (y/n)?: ";
		cin >> ans;
	
	} while(ans != 'n');
	*/

	if(d1 < d2)
	{
		cout << "d1 is less than d2" << endl;
	}
	
	else
	{
		cout << "otherwise." << endl;
	}

	d2 += d1;

	///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	float mtrs;

	// convert a float to an object
	Distance d5 = 2.35F;
	Distance d6(2.67F);

	cout << "d5 = " << d5.showdist() << endl;

	// convert an object to a float
	mtrs = static_cast<float>(d5);
	mtrs = d6;

	cout << "Meters = " << mtrs << endl; 

	return 0;
} // end main