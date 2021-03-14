/*
 * Aaron Shaneen
 * Assignment 7 Exercise 12
 * Populates a Student ID with student info
 */

package Aaron_Shaneen_OOP;

// Exercise 12 (w/ StudentId class) - Populates a StudentId with student info

public class Assignment7StudentId
{
    private String Name;
    private int Id;

    public void SetName(String N)       // setter for name       
    {
        this.Name = N;
    }        

    public String GetName()             // getter for name    
    {
        return this.Name;
    }

    public void SetId(int Id)           // setter for student id    
    {
        this.Id = Id;
    }        

    public int GetId()                  // getter for student id    
    {
        return this.Id;
    }        

    public String GetEmailAccount()     // makes an email address with student's first initial, id, and domain of school
    {
        return "" + this.Name.charAt(0) + this.Id + "@pirate.park.edu";
    }   

    public boolean IsValid()            // input validation for student id number
    {
        return this.Id >= 100000 && this.Id <= 999999; 
    }        

} // end StudentId