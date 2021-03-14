/*
Aaron Shaneen
Homework 2 Problem 2
Simulates a game of craps
*/

#include <iostream>
#include <cstdlib> // contains prototypes for functions srand and rand
#include <ctime> // contains prototype for function time
using namespace std;

unsigned int rollDice(); // rolls dice, calculates and displays sum

int main()
{
   // TODO: define an enumeration with constants that represent the game status: continue, won, lost
	enum status{cont, won, lost};

   // randomize random number generator using current time
   srand(static_cast<unsigned int>(time(0)));

   unsigned int myPoint = 0; // point if no win or loss on first roll

   // TODO: define a variable named gameStatus of Status type and initialize it with continue as the value.
   status gameStatus = cont;

   unsigned int sumOfDice = rollDice(); // first roll of the dice

   // determine game status and point (if needed) based on first roll
   switch (sumOfDice)
   {
      case 7: // win with 7 on first roll
      case 11: // win with 11 on first roll
         // TODO: assign the won status to gameStatus
		  gameStatus = won;
         break;
      case 2: // lose with 2 on first roll
      case 3: // lose with 3 on first roll
      case 12: // lose with 12 on first roll
         // TODO: assign the lost status to gameStatus
		  gameStatus = lost;
         break;
      default: // did not win or lose, so remember point
         // TODO: assign the continue status to gameStatus
		  gameStatus = cont;
         myPoint = sumOfDice; // remember the point
         cout << "Point is " << myPoint << endl;
         break; // optional at end of switch
   } // end switch

   // while game is not complete
   // TODO: provide the condition statement for while loop to check if the gameStatus is continue
   while (gameStatus == cont) // not WON or LOST
   {
      sumOfDice = rollDice(); // roll dice again

      // determine game status
      if (sumOfDice == myPoint) // win by making point
      	 // TODO: assign won status to gameStatus
			 gameStatus = won;
      else
         if (sumOfDice == 7) // lose by rolling 7 before point
      	 // TODO: assign lost status to gameStatus
			 gameStatus = lost;
   } // end while

   // display won or lost message
   // TODO: provide the condition statement for the if statement to see if gameStatus is won
   if (gameStatus == won)
      cout << "Player wins" << endl;
   else
      cout << "Player loses" << endl;
} // end main

// roll dice, calculate sum and display results
unsigned int rollDice()
{
   // pick random die values
   unsigned int die1 = 1 + rand() % 6; // first die roll
   unsigned int die2 = 1 + rand() % 6; // second die roll

   unsigned int sum = die1 + die2; // compute sum of die values

   // display results of this roll
   cout << "Player rolled " << die1 << " + " << die2
      << " = " << sum << endl;
   return sum; // return sum of dice
} // end function rollDice