using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1P2
{
    class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// prompt user for first number
            /// </summary>
            Console.Write("Please enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());     // stores first number entered

            /// <summary>
            /// prompt user for second number
            /// </summary>
            Console.Write("Please enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());     // stores second number entered

            int sum = num1 + num2;          // calculates and saves sum of num1 and num2
            int difference = num1 - num2;   // calculates and saves difference of num1 and num2
            int product = num1 * num2;      // calculates and saves product of num1 and num2
            int quotient = num1 / num2;     // calculates and saves quotient of num1 and num2
            int remainder = num1 % num2;    // calculates and saves remainder of num1 and num2

            Console.WriteLine("{0} + {1} = {2}", num1, num2, sum);          // prints num1, num2, and the addition of both
            Console.WriteLine("{0} - {1} = {2}", num1, num2, difference);   // prints num1, num2, and the subtraction of both
            Console.WriteLine("{0} * {1} = {2}", num1, num2, product);      // prints num1, num2, and the multiplication of both
            Console.WriteLine("{0} / {1} = {2}", num1, num2, quotient);     // prints num1, num2, and the division of both
            Console.WriteLine("{0} % {1} = {2}", num1, num2, remainder);    // prints num1, num2, and the remainder of both

            /// <summary>
            /// if num1 is less than num2
            /// </summary>
            if(num1 < num2)
            {
                Console.WriteLine("{0} is less than {1}", num1, num2);
            }

            /// <summary>
            /// or else num1 is not less than num2
            /// </summary>
            else
            {
                Console.WriteLine("{0} is not less than {1}", num1, num2);
            }

            /// <summary>
            /// if num1 is greater than num2
            /// </summary>
            if (num1 > num2)
            {
                Console.WriteLine("{0} is greater than {1}", num1, num2);
            }

            /// <summary>
            /// or else num1 is not greater than num2
            /// </summary>
            else
            {
                Console.WriteLine("{0} is not greater than {1}", num1, num2);
            }

            /// <summary>
            /// if num1 is equal to num2
            /// </summary>
            if (num1 == num2)
            {
                Console.WriteLine("{0} does equal {1}", num1, num2);
            }

            /// <summary>
            /// or else num1 is not equal to num2
            /// </summary>
            else
            {
                Console.WriteLine("{0} does not equal {1}", num1, num2);
            }

            /// <summary>
            /// to pause app after executing
            /// </summary>
            Console.ReadLine();
        }
    }
}
