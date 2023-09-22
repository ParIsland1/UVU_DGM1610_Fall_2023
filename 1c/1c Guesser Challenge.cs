using System;
					
public class Program
{
	public static void Main()
	{
		// Declaring all the variables and generating the #
		Random random = new Random();
		bool playAgain = true;
		int min = 1;
		int max = 10;
		int guess;
		int number;
		int guesses;
		string response;
		// For while the game is running
		while(playAgain == true)
		{
			guess = 0;
			guesses = 0;
			response = "";
			number = random.Next(min, max + 1);
			
			while(guess != number)
			{
				Console.WriteLine("Guess a number bewtween " + min + "-" + max + "! ");
				guess = Convert.ToInt32(Console.ReadLine());
				// Give hint, high or low
				if(guess > number)
				{
					Console.WriteLine("Too high! Try again.");	
				}
				else if (guess < number)
				{
					Console.WriteLine("Too low! Try again.");	
				}
				guesses++;
			}
			Console.WriteLine("Correct!" + number);
			Console.WriteLine("Attempts: " + guesses);
			//Restart the game if yes
			Console.WriteLine("Play again? (Yes or No)");
			response = Console.ReadLine();
			response = response.ToUpper();
			
			if(response == "Yes")
			{
				playAgain = true;	
			} else 
			{
				playAgain = false;	
			}
		}
	}
}