/*
Aaron Shaneen
Homework 9 Problem 2
*/

#include <iostream>
#include <vector>
using namespace std;

int main()
{
   vector< CarbonFootprint* > list;

   // add elements to list
   list.push_back(new Bicycle());
   list.push_back(new Building(2500));
   list.push_back(new Car(10));

   // display carbon footprint of each object
   for (size_t i = 0; i < list.size(); ++i)
   {
	   //TODO: polymorphically invoking each object¡¯s getCarbonFootprint method
   }

   // release elements of list
   for ( size_t i = 0; i < list.size(); ++i )
   {
	   //TODO: release elements in the list
   }
} // end main