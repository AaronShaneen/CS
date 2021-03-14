/*
 * Aaron Shaneen
 * Assignment 10 Recursion
 * Uses recursion to print the twelve days of christmas song
 */

package Aaron_Shaneen_OOP;

public class Recursion
{
    public void TwelveDays()    // using this instead of a built in variable inside
    {                           // the method so as to not reset the Days variable
        this.TwelveDays(12);    // to 12 every time the recursion happens
    }
    
    private void TwelveDays(int Days)    // actual recursion occurs here
    {
        if(Days > 1)
        {
            TwelveDays(Days - 1);
        }
        
        switch(Days)    // switch you ask? why not I ask
        {
            case 1:
                System.out.println("On the first day of Christmas my true love gave to me a partridge in a pear tree");
                break;
            case 2:
                System.out.println("On the second day of Christmas my true love gave to me two turtle doves");
                break;
            case 3:
                System.out.println("On the third day of Christmas my true love gave to me three french hens");
                break;
            case 4:
                System.out.println("On the fourth day of Christmas my true love gave to me four colly birds");
                break;
            case 5:
                System.out.println("On the fifth day of Christmas my true love gave to me five gold rings");
                break;
            case 6:
                System.out.println("On the sixth day of Christmas my true love gave to me six geese a laying");
                break;
            case 7:
                System.out.println("On the seventh day of Christmas my true love gave to me seven swans a swimming");
                break;
            case 8:
                System.out.println("On the eighth day of Christmas my true love gave to me eight maids a milking");
                break;
            case 9:
                System.out.println("On the ninth day of Christmas my true love gave to me nine ladies dancing");
                break;
            case 10:
                System.out.println("On the tenth day of Christmas my true love gave to me ten lords a leaping");
                break;
            case 11:
                System.out.println("On the eleventh day of Christmas my true love gave to me eleven pipers piping");
                break;
            case 12:
                System.out.println("On the twelvth day of Christmas my true love gave to me twelve drummers drumming");
                break;    
        } // end switch
    } // end TwelveDays
} // end Recursion