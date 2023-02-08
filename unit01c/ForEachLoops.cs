using System;
					
public class Program
{
	public static void Main()
	{
		string[] game = {"Halo", "StarcraftII", "Call of Duty: Modern Warfare"};
		string[] characters = {"Sgt. Johnson", "Alexi Stukov", "Captain Price"};
		int i = 0;
		foreach (var name in game){
			Console.WriteLine("The best character from " + name + " is " + characters[i] + ".");
			i++;
		}
	}
}