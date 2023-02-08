using System;
					
public class Program
{
	public static void Main()
	{
		string[] game = {"Halo", "StarcraftII", "Call of Duty: Modern Warfare", "Ace Combat 7"};
		string[] characters = {"Sgt. Johnson", "Alexi Stukov", "Captain Price", "Trigger", "Tychus Findlay", "Arbiter", "Soap Macktavish"};
		int i = 0;
		while (i < game.Length && i < characters.Length) {
			Console.WriteLine("The best character from " + game[i] + " is " + characters[i] + ".");
			i++;
		}
	}
}