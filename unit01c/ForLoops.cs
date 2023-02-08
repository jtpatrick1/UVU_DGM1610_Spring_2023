using System;
					
public class Program
{
	public static void Main()
	{
		string[] game = {"Halo", "StarcraftII", "Call of Duty: Modern Warfare"};
		string[] characters = {"Sgt. Johnson", "Alexi Stukov", "Captain Price"};
		for (var i = 0; i < characters.Length; i++) {
			Console.WriteLine(game[i] + "'s best character is " + characters[i] + ".");
		}
	}
}