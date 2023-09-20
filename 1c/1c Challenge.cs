using System;
					
public class Program
{
	public static void Main()
	{
	 Console.WriteLine("Enter number of rows for Pyramid:");
	
		int input = Convert.ToInt32(Console.ReadLine());	
		 Console.WriteLine();
		// Start the pyramid 
    int rows, cols;  
    for (rows = 1; rows <= input; rows++)  
    {  
        for (cols = 1; cols <= rows; cols++)  
        {  
            Console.Write(rows + " "); // print rows value  
        }  
        Console.WriteLine("");  
    }  
	}
}