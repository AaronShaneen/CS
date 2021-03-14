/*
Aaron Shaneen
Homework 6 Problem 1
Uses an overloaded operator
to add two times together
*/

#include <iostream>
using namespace std;

class time
{
private:	// private members

      int hrs, mins, secs;

public:		// public members

      time() : hrs(0), mins(0), secs(0)	// no-arg constructor
      {
	  
	  }
                                        
      time(int h, int m, int s) : hrs(h), mins(m), secs(s)	// 3-arg constructor
      {
	  
	  }

      void display() const	// format 11:59:59
      {
		  cout << hrs << ":" << mins << ":" << secs;
	  }

      void add_time(time t1, time t2)   // adds two times
      {
         secs = t1.secs + t2.secs;      // add seconds
         
		 if(secs > 59)                  // if secs overflow...
         {
			 secs -= 60; mins++;		// carry a minute
		 }     
         
		 mins += t1.mins + t2.mins;     // add minutes
         
		 if(mins > 59)                  // if mins overflow...
         {
			 mins -= 60; hrs++;			// carry an hour
		 }      
         
		 hrs += t1.hrs + t2.hrs;        // add hours
      } // end add_time

	  time operator + (time t1)		// overloaded + operator to add times
	  {
		  int s = secs + t1.secs;	// add secs
		  int m = mins + t1.mins;	// add mins
		  int h = hrs + t1.hrs;		// add hrs

		  if(s > 59)	// if secs overflow...
          {
			 s -= 60;
			 m++;		// carry a minute
		  }

		  if(m > 59)	// if mins overflow...
          {
			 m -= 60;
			 h++;		// carry an hour
		  }

		  return time(h, m, s);
	  } // end operator +

	  time operator ++ ()	// overload ++ (prefix)
	  {
		  ++secs;			// prefixed incrementing

		  if(secs > 59)		// if secs overflow...
          {
			 secs -= 60;
			 ++mins;		// carry a minute
		  }

		  if(mins > 59)		// if mins overflow...
          {
			 mins -= 60;
			 ++hrs;			// carry an hour
		  }

		  return time(hrs, mins, secs);
	  } // end operator ++ prefix

	  time operator -- ()	// overloaded -- (prefix)
	  {
		  --secs;			// prefixed decrementing

		  if(secs < 0)		// if secs is less than 0...
		  {
			  secs += 60;	// secs resets to 60...
			  --mins;		// derement mins
		  }

		  if(mins < 0)		// if mins is less than 0...
		  {
			  mins += 60;	// mins resets to 60
			  --hrs;		// decrement hrs
		  }

		  return time(hrs, mins, secs);
	  } // end operator -- prefix

	  time operator ++ (int)	// overloaded ++ (postfix)
	  {
		  time temp;		// temp variable
		  
		  secs++;			// postfix incrementing

		  if(secs > 59)		// if secs overflow...
          {
			 secs -= 60;
			 ++mins;		// carry a minute
		  }

		  if(mins > 59)		// if mins overflow...
          {
			 mins -= 60;
			 ++hrs;			// carry an hour
		  }

		  return time(hrs, mins, secs);
	  } // end operator ++ postfix

	  time operator -- (int)	// overloaded -- (postfix)
	  {
		  time temp;		// temp variable
		  
		  secs--;			// postfix decrementing

		  if(secs < 0)		// if secs is less than 0...
		  {
			  secs += 60;	// secs resets to 60...
			  --mins;		// derement mins
		  }

		  if(mins < 0)		// if mins is less than 0...
		  {
			  mins += 60;	// mins resets to 60
			  --hrs;		// decrement hrs
		  }

		  return time(hrs, mins, secs);
	  } // end operator ++ postfix
}; // end time

int main()
{
   time time1(5, 59, 59);	// declares and initializes
   time time2(4, 30, 30);	// two times
   time time3;				// create another time

   //time3.add_time(time1, time2);	// alternate add two times

   time3 = time1 + time2;			// overloaded add operator

   cout << "time3 = "; time3.display();	// display result

   cout << endl;

   ++time1;	// overloaded prefix increment

   cout << "time1 = "; time1.display();	// display result
   
   cout << endl;

   --time1;	// overloaded prefix decrement

   cout << "time1 = "; time1.display();	// display result
   
   cout << endl;

   time1++;	// overloaded postfix increment

   cout << "time1 = "; time1.display();	// display result
   
   cout << endl;

   time1--;	// overloaded postfix decrement

   cout << "time1 = "; time1.display();	// display result
   
   cout << endl;

   return 0;
} // end main