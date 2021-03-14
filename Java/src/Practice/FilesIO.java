/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

package Practice;

import java.io.PrintWriter;
import java.nio.file.Paths;
import java.util.Scanner;

public class FilesIO
{
    public static void main(String[] args)
    {
        Scanner input = new Scanner(System.in);
        
        String FileName, FileOutput, Line;
        int DotLocation;
        
        // C:\temp\File Input\file.txt
        System.out.print("Enter file name: ");
        FileName = input.nextLine();
        
        DotLocation = FileName.indexOf('.');
        
        if(DotLocation == -1)
        {
            FileName += ".txt";
            FileOutput = FileName + ".txt";
        }
        
        else
        {
            FileOutput = FileName.substring(0, DotLocation) + ".txt";
        }
        
        try(Scanner FileIn = new Scanner(Paths.get(FileName));PrintWriter FileOut = new PrintWriter(FileOutput))
        {
            Line = FileIn.nextLine();
            
                if(Line == null)
                {
                    System.out.println(FileOutput + " is empty.");
                }
                else
                {
                    FileOut.println("Today is 11/18/2013.");
                    FileOut.println("Printing successful.");
                }
        }
        
        catch(Exception e)
        {
            System.out.println(e.getClass());
            System.out.println(e.getMessage());
        }
    }
}