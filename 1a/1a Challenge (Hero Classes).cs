//Use this file to store your work to demonstrate your understanding of operators
//Make sure your work is different from the instructors examples or your peers
using System;
					
public class Program
{
	public Hero heroOne;
	public Hero heroTwo;
	
	public void Main()
	{
		heroOne = new Hero();
		heroTwo = new Hero();
		
		heroOne.health = 2;
		heroOne.powerLevel = 5;
		heroOne.stamina = 10;
		
		heroTwo.health = 3;
		heroTwo.powerLevel = 1;
		heroTwo.stamina = 7;
		
		Console.WriteLine("The Knight has a health value of " + heroOne.health);
		Console.WriteLine("The Knight has a powerlevel of " + heroOne.powerLevel);
		Console.WriteLine("The Knight has " + heroOne.stamina + " remaining stamina.");
		
		Console.WriteLine("The Archer has a health value of " + heroTwo.health);
		Console.WriteLine("The Archer has a powerlevel of" + heroTwo.powerLevel);
		Console.WriteLine("The Archer has " + heroTwo.stamina + " remaining stamina.");
	}
}

public class Hero {
	public int health;
	public int powerLevel;
	public int stamina;
}
