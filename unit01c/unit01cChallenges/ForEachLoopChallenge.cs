using System;
					
public class Program
{
	public static void Main()
	{
		Random rnd = new Random();
		string[] waffleNames = {"Nutella Love", "Red Wonder", "Chicken and Waffles", "Dulce", "Chickin Alvocado Tartine"};
		string[] waffleOrder = {"","","","","","",""};
		for (var i = 0; i < rnd.Next(1, 6); i++){
			int randomWaffle = rnd.Next(0, waffleNames.Length);
			waffleOrder[i] = waffleNames[randomWaffle];
		}
		foreach(var waffle in waffleOrder){
			Console.WriteLine(waffle);
		}
	}
}