/*
 * Assignment2
 * Aaron Shaneen
 * prints questions and answers to ch3 exercises
 */

package Aaron_Shaneen;
    public class Assignment2 {
        public static void main(String[] args) {
        
            // exercise1
            
            // This is a very long comment with lots of useless and unnecessary words that force us to use multiple lines to inclue it all 
            
            /* 
             * This is a very long comment with lots of
             * useless and unnecessary words that force
             * us to use multiple lines to inclue it all
             */
            
            // exercise2
            
            System.out.println("Why does public static void Main(String[] args) generate an error? Because the m in main is meant to be lowercase, not uppercase");
            
            // exercise8
            
            System.out.println("Question: If we just write a floating point number without specifying its type, what type does the computer assume it is?");
            System.out.println("Answer: The computer will automatically assume the the number is a whole number (integer) and negate its fractional and decimal values");
            
            // exercise10
            
            System.out.println("a (3 * 3) - (k * k) / (4 * 4)");    // Needed variable assignments, doubles, and correct squaring
            System.out.println("b (4.5 + y) - 9x / 2x");            // Needed variable assignments, doubles, and correct execution
            
            // exercise12
            
            System.out.println("integer = (int) preciseReal");        // double cast as int
            System.out.println("integer = (int) sloppyReal");         // float cast as int
            System.out.println("preciseReal = (double) bigInteger");  // long cast as double
            System.out.println("integer = (int) bigInteger");         // long cast as int
            System.out.println("preciseReal = (double) sloppyReal");  // float cast as double
                        
            // exercise 15
            
            String myName;
                myName = "aaron";
            System.out.println(myName.charAt(3));
            
}   // end main
}   // end class
