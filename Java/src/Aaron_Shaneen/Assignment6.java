/*
 * Aaron Shaneen
 * Assignment 6
 * Performs various functions on arrays for Ex 6, 7b, 9, and 15 (1st ed.)
 */

package Aaron_Shaneen;

public class Assignment6
{
    
    public static void main(String[] args)
    {
        Exercise6();
        
        System.out.print("\n");
        
        Exercise7b();
        
        System.out.print("\n");
        
        Exercise9();
        
        System.out.print("\n");
        
        Exercise15();
        
    } // end main        

// Exercise6 - Copies last five elements of one array to another and prints both
    
        public static void Exercise6()
        {
            double[] AllSalaries = {100000.0, 110000.0, 25000.0, 18000.0, 30000.0, 9000.0, 12000.0};
            double[] WorkerSalaries = new double[5];
            
            System.arraycopy(AllSalaries, 2, WorkerSalaries, 0, 5);   // note array copy starts at 2 to skip first two elements
            
            System.out.println("All Salaries: ");
            for(int i = 0; i < AllSalaries.length; i++)
                System.out.println(AllSalaries[i]);
                       
            System.out.println("WorkerSalaries: ");
            for(int j = 0; j < WorkerSalaries.length; j++)
                System.out.println(WorkerSalaries[j]);
            
        } // end Exercise6        

// Exercise7b - Takes a string array of names and copies them in reverse order to another then prints both
    
        public static void Exercise7b()
        {
            String[] Simpsons = {"Homer", "Flanders", "Apu"};
            System.out.println(Simpsons[0] + " " + Simpsons[1] + " " + Simpsons[2]);    // added to original code to print array before it's reversed                
            
            Reverse(Simpsons);
            System.out.println(Simpsons[0] + " " + Simpsons[1] + " " + Simpsons[2]);
        
        } // end Exercise7b

// Reverses the Simpsons array order
        
            public static void Reverse(String[] List)
            {
                String[] Temp = new String[List.length];
                
                for(int i = 0; i < List.length; i++)
                    Temp[i] = List[List.length - i - 1];                    
                
                System.arraycopy(Temp, 0, List, 0, 3);
            
            } // end Reverse
                
// Exercise9 - Takes some numbers then figures out if they're all positive
    
        public static void Exercise9()
        {
            double[] Arr = {3, 5, 7, 9, 11};    // you can change these integers to test for negatives
            
            boolean Positives = true;
                        
            for(int i = 0; i < Arr.length; i++)
            {        
                if(Arr[i] <= 0)
                {    
                    Positives = false;
                    break;                      // the first negative parsed triggers this break    
                }                               // answering whether or not if they are ALL positive
            } // end for loop
            
            if(Positives == false)
                System.out.println("False");
            else
                System.out.println("True");
        
        } // end Exercise9    
     
// Exercise15 - Takes a two dimensional array, copies it, and runs copy through a mask function
    
        public static void Exercise15()
        {
            int[][] Table = {{8, -5, 2}, {-1, 3, -7}};
            int[][] Mask = new int[3][3];
                                    
            System.arraycopy(Table[0], 0, Mask[0], 0, 3);
            System.arraycopy(Table[1], 0, Mask[1], 0, 3);
            
            GetMask(Mask);
            
            System.out.println("Table Array");          // just to show original
            for(int k = 0; k < Table[0].length; k++)      
                System.out.print(Table[0][k] + " ");
            
            System.out.println();
                                                         
            for(int l = 0; l < Table[1].length; l++)     
                System.out.print(Table[1][l] + " ");
            
            System.out.println();
            
            System.out.println("Mask Array");           // just to show copy
            for(int m = 0; m < Mask[0].length; m++) 
                System.out.print(Mask[0][m] + " ");
            
            System.out.println();
            
            for(int n = 0; n < Mask[0].length; n++)
                System.out.print(Mask[1][n] + " ");
            
            System.out.println();
        
        } // end Exercise15
        
// GetMask replaces any numbers zero and above with a one and any negatives with a zero        
        
                public static int[][] GetMask(int[][] Mask)
                {
                    for(int i = 0; i < Mask[0].length; i++)
                    {
                        if(Mask[0][i] <= 0)
                            Mask[0][i] = 0;
                        
                        else
                            Mask[0][i] = 1;
                    }
                    
                    for(int j = 0; j < Mask[1].length; j++)
                    {
                        if(Mask[1][j] <= 0)
                            Mask[1][j] = 0;
                        
                        else
                            Mask[1][j] = 1;
                    }
                    
                    return Mask;
                
                } // end GetMask        
   
} // end Assignment6