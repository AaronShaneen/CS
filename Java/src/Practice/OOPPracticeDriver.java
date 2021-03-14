/*
 * Aaron Shaneen
 * OOP Practice 2
 */

package Practice;

public class OOPPracticeDriver
{

    private int numWheels;
    private int engineSize;
    public static int MyStaticVariable = 42;
    
    private boolean numWheelsSet = false;
    
    // Mutator function / Setter function
    public void SetNumWheels(int numWheels)
    {
        if(!numWheelsSet)
        {
            this.numWheels = numWheels;
            numWheelsSet = true;
        }
    }
    
    // Accessor function / Getter function
    public int GetNumWheels()
    {
        return numWheels * 2;
    }
    
    public void Drive()
    {
        System.out.println("I'm driving on " + numWheels + "!!!!!!!!!!!!!!!!");
        this.ChangeGear();
        System.out.println("Now I'm in a higher gear.");
        
        System.out.println(MyStaticVariable);
    }
    
    private void ChangeGear()
    {
        System.out.println("Change gears.");
    }
    
    public void Stop()
    {
        System.out.println("Vehicle stopped.");
    }
    
    public void Refuel()
    {
        System.out.println("Vehicle refueled.");
    }
   
}