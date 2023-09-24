using System;
					
public class Program
{
	public static void Main()
	{
		GameStart();
		
		Kickoff();
		Return();
		
		
	}
	public static void Return()
	{
		Random random = new Random();
		int min = 25;
		int max = 99;
		int number = random.Next(min, max + 1);
		Console.WriteLine("They return " + number + " yards!");
	}
	public static void Kickoff()
	{
		Random random = new Random();
		int min = 50;
		int max = 99;
		int kickoff = random.Next(min, max + 1);
		Console.WriteLine("The kick goes " + kickoff + " yards!");
	}
	public static void GameStart()
	{
		string[] leagueTeams = {"SD Sharks", "NY Bulls", "MIA Suns", "DEN Stallions", "LV Outlaws"};
		
		Console.WriteLine("Welcome to First Down!");
		Console.WriteLine("Select your team coach.");
		Console.WriteLine();
		
		foreach (var item in leagueTeams) 
		{
			Console.WriteLine(item);
		}
		string playerTeam = Console.ReadLine();
		Console.WriteLine("You are the " + playerTeam + " head coach!");	
	}
}