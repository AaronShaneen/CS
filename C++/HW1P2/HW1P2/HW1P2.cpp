/*
Aaron Shaneen
Homework 1 Problem 2
Calculates BMI on a given height/weight
*/

#include <iostream>
using namespace std;

int main()
{
	int height, weight;
	double BMI;

	cout << "Enter your height in inches: " << endl;
	cin >> height;

	cout << "Enter your weight in pounds: " << endl;
	cin >> weight;

	BMI = (weight * 703) / (height * height);		// calculates BMI given the BMI equation

	cout << "Your BMI: " << BMI << endl;
	cout << "Underweight: less than 18.5" << endl;
	cout << "Normal Weight: between 18.5 and 24.9" << endl;
	cout << "Overweight: between 25 and 29.9" << endl;
	cout << "Obese: 30 or greater" << endl;

	return 0;
}