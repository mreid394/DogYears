using System;

class Program
{
	static void Main()
	{		
		int myAge = 24; // Declare and initialize the variable for age in human years.

		// Declare and initialize early years, then calculate its value in dog years.
		double earlyYears = 2;
		earlyYears *= 10.5;

		// Calculate later years by subtracting 2 from the age and converting to dog years.
		int laterYears = myAge - 2;
		laterYears *= 4;
		
		double myAgeInDogYears = earlyYears + laterYears; // Calculate total age in dog years by summing earlyYears and laterYears.
		
		string myName = "Matthew"; // Declare a string variable to store the user's name.

		Console.WriteLine($"My name is {myName}. I am {myAge} years old in human years which is {myAgeInDogYears} years old in dog years."); // Print the final output to the console.
	}
}