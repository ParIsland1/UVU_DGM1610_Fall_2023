using System;

public class WeatherTips
  {
    public void Main()
    {
      // Type the current temperature in degrees Celsius
      Console.WriteLine("Temperature in degrees Celsius");

      // Convert a string variable to Int and get user input from the keyboard and store it in the variable
      int tempInput = Convert.ToInt32(Console.ReadLine());

      // Different outputs depending on what temperature it is, added recomendations for different ranges of temperature
      	if (tempInput >= 30) {
		Console.WriteLine("Make sure to stay hydrated and drink water!");
		} else if (tempInput <= 20 && tempInput >= 10) {
			Console.WriteLine("Make sure to wear a light coat.");
		} else if (tempInput <= 10) {
			Console.WriteLine("Make sure to warm clothing.");
		} else if (tempInput >= 20 && tempInput <= 30) {
			Console.WriteLine("Enjoy the nice weather at the park!");
		}
    }
  }