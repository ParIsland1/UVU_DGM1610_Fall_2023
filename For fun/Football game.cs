using System;
					
public class Program
{
	public static void Main()
	{
		Random random = new Random();
		int min = 50;
		int max = 99;
		int number = random.Next(min, max + 1);
		Console.WriteLine("The kick goes " + number + " yards!");
		
		Return();
	}
	public static void Return()
	{
		Random random = new Random();
		int min = 25;
		int max = 50;
		int number = random.Next(min, max + 1);
		Console.WriteLine("They return " + number + " yards!");
	}
}