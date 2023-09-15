using System;
					
public class ExamGrader
{
	public void Main()
	{
		Console.WriteLine("Enter Exam Score: (Out of 100)");
		int examScore = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter Subject:");
		string subject = (Console.ReadLine());
		
		if (examScore >= 90) {
			Console.WriteLine("Your Grade: A");
		} else if (examScore >=80) {
			Console.WriteLine("Your Grade: B");
		} else if (examScore >=70) {
			Console.WriteLine("Your Grade: C"); 
		} else if (examScore >=60) {
			Console.WriteLine("Your Grade: D");
		} else {
			Console.WriteLine("Your Grade: F");
		}
		   switch (subject.ToLower()) // Convert to lowercase to handle case-insensitivity
        {
            case "math":
                Console.WriteLine("Keep practicing and exploring mathematical concepts!");
                break;
            case "science":
                Console.WriteLine("Science is fascinating; keep discovering new things!");
                break;
            case "history":
                Console.WriteLine("History is a journey through time; keep learning from the past!");
                break;
            case "english":
                Console.WriteLine("Reading and writing are essential skills; keep improving!");
                break;
            default:
                Console.WriteLine("Invalid subject. Enter 'Math' 'Science' 'History' or 'English'");
                break;
		   }
	}
}