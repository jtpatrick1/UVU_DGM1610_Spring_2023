using System;
					
public class Program
{
	public Weapon rifle;
	public PlayerHealth playerOne;
	
	public void Main()
	{
		rifle = new Weapon();
		playerOne = new PlayerHealth();
		
		rifle.weaponDamage = 10;
		
		playerOne.playerHealth = 8f;
		playerOne.damageResist = 1.0f;
		
		DoDamage();
		if (playerOne.playerHealth <= 0) {
			Console.WriteLine("You are dead!");
		} else {
			Console.WriteLine("You are alive!");
		}
		
	}
	
	public void DoDamage(){
		playerOne.playerHealth = playerOne.playerHealth - rifle.weaponDamage * playerOne.damageResist;
		Console.WriteLine(playerOne.playerHealth);
	}
}

public class Weapon{
	public int weaponDamage;
}

public class PlayerHealth{
	public float playerHealth;
	public float damageResist; 
}