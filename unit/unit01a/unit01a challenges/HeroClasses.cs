//Use this file to store your work to demonstrate your understanding of operators
//Make sure your work is different from the instructors examples or your peers
using System;
					
public class Program
{
	public Hero heroOne;
	public Hero heroTwo;
	public Villain villainOne;
	public Villain villainTwo;
	
	public void Main()
	{
		heroOne = new Hero();
		heroTwo = new Hero();
		
		villainOne = new Villain();
		villainTwo = new Villain();
		
		heroOne.health = 2;
		heroOne.powerLevel = 5;
		heroOne.goodness = 3;
		
		heroTwo.health = 3;
		heroTwo.powerLevel = 1;
		heroTwo.goodness = 7;
		
		villainOne.catchphrase = ("You meddling kids!");
		villainOne.evilness = 4;
		villainOne.health = 5;
		
		villainTwo.catchphrase = ("Turns out ya dead.");
		villainTwo.evilness = 99;
		villainTwo.health = 8;
		
		Console.WriteLine(heroOne.health);
		Console.WriteLine(heroOne.powerLevel);
		Console.WriteLine(heroOne.goodness);
		
		Console.WriteLine(heroTwo.health);
		Console.WriteLine(heroTwo.powerLevel);
		Console.WriteLine(heroTwo.goodness);
		
		Console.WriteLine(villainOne.catchphrase);
		Console.WriteLine(villainOne.evilness);
		Console.WriteLine(villainOne.health);
		
		Console.WriteLine(villainTwo.catchphrase);
		Console.WriteLine(villainTwo.evilness);
		Console.WriteLine(villainTwo.health);
	}
}

public class Hero {
	public int health;
	public int powerLevel;
	public int goodness;
}

public class Villain {
	public int evilness;
	public int health;
	public string catchphrase;
}