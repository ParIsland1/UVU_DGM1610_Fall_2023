using System;
					
public class BMR
{
	public static void Main()
	{
		Console.WriteLine("Basal Metabolic Rate Calculator (Kg and Cm)");
		
		Console.WriteLine();
		Console.WriteLine("Enter: Male or Female");
		string sex = Console.ReadLine();
		
		Console.WriteLine();
		Console.WriteLine("Enter your height in Cm");
		int height = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine();
		Console.WriteLine("Enter your weight in Kg");
		int weight = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine();
		Console.WriteLine("Enter your age");
		int age = Convert.ToInt32(Console.ReadLine());
		
		double MaleBMR = 66.5 + (13.75 * weight) + (5.003 * height) - (6.75 * age);
		double FemaleBMR = 655.1 + (9.563 * weight) + (1.850 * height) - (4.676 * age);

		switch(sex) 
		{
			case "male":
				Console.WriteLine("Your BMR is: " + MaleBMR + " Calories per day.");
				break;
			case "female":
				Console.WriteLine("Your BMR is: " + FemaleBMR + " Calories per day.");
				break;
		}
		
		
	}
}