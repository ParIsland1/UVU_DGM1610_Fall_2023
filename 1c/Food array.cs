using System;

public class Program
{
    public static void Main()
    {
        string[] favoriteFoods = new string[3]; // Create an array to store three favorite foods

        Console.WriteLine("Please enter your three favorite foods:");

        // Prompt the user to enter each favorite food
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter each food item:");
            favoriteFoods[i] = Console.ReadLine();
        }

        // Display each favorite food with a message
        foreach (string food in favoriteFoods)
        {
            Console.WriteLine("I also love " + food + "!");
        }
    }
}