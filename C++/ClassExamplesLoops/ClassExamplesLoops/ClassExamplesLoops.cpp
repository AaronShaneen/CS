/*
Aaron Shaneen
Class Examples
Random loops and gadgets
*/

#include <iostream>
using namespace std;

int main()
{

	for(int i = 0; i < 15; i++){
		cout << i * i << " ";
	}

	cout << endl;
	int j = 0;
	while(j < 15){
		cout << j * j << " ";
		j++;
	}

	cout << endl;
	int k = 0;
	do{
		cout << k * k << " ";
		k++;
	} while(k < 15);

	cout << endl;
	if(true){
		cout << "true" << endl;
	}

	if(i){
		cout << "1" << endl;
	}

	if('\0'){		// '\0' terminates the line, zero = false in C++
		cout << "\0" << endl;
	}
	
	// min = (alpha<beta) ? alpha : beta;

	return 0;
}