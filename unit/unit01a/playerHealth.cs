using System;
					
public class Program
{
	public Health player;
	public Health player2;
	public Weapon pistol;
		
	public void Main()
	{
		player = new Health();
		player2 = new Health();
		pistol = new Weapon();
		
		player2.playerHealth -= pistol.weaponDamage;
		Console.WriteLine("Bob has health: " + player2.playerHealth);
		Console.WriteLine("Steve has health: " + player.playerHealth);
	}
}

public class Health{
	public int playerHealth = 5;
	public float playerStrength = 1.3f;
}

public class Weapon {
	public int weaponDamage = 1;
	public string weaponName = "pistol";
}