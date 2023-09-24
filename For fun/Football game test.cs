using System;
					
public class Program
{
	public static void Main()
	{
		MainStart();
		
		FootballField field = new FootballField();
		
		Kickoff(field);
		Return(field);
		
		int ballPosition = field.GetBallPosition();
		Console.WriteLine("The ball is at " + ballPosition + " yards from the end zone.");
		
	}
	public static void Return(FootballField field)
	{
		Random random = new Random();
		int min = 25;
		int max = 99;
		int threshold = 25;
		if (random.Next(100) < threshold)
		{
			max = 25;	
		}
		
		int number = random.Next(min, max + 1);
		Console.WriteLine("They return " + number + " yards!");
	}
	public static void Kickoff(FootballField field)
	{
		Random random = new Random();
		int min = 50;
		int max = 99;
		int kickoff = random.Next(min, max + 1);
		Console.WriteLine("The kick goes " + kickoff + " yards!");
	}
	public static void MainStart()
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
public class FootballField
{
	private int ballPosition;
	public FootballField()
	{
		ballPosition = 50;	
	}
	public void MoveBall(int yards)
	{
		ballPosition += yards;
		ballPosition = Math.Max(0, Math.Min(100, ballPosition));
	}
	public int GetBallPosition()
	{
		return ballPosition;	
	}
}