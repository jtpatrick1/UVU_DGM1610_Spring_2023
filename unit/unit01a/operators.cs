using System;

public class Program
{
	public int number = 27;
	public string words = "Hello There";
	public int secondNumber = 10;
	public int thirdNumber;
	
	public void Main() 
	{
		number += 5;
		Console.WriteLine(number);
		secondNumber -= 5;
		Console.WriteLine(secondNumber);
		thirdNumber = secondNumber * number;
		Console.WriteLine(number + " * " + secondNumber + " = " + thirdNumber);
	}
}
