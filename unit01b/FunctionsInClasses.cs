using System;
					
public class Program
{
	public Weapon rifle;
	public PlayerHealth playerOne;
	
	public void Main()
	{
		rifle = new Weapon();
		
		rifle.weaponDamage = 6;
		
		rifle.DoDamage();
		if (rifle.playerOne.playerHealth <= 0) {
			Console.WriteLine("You are dead!");
		} else {
			Console.WriteLine("You are alive!");
		}
		
	}
}

public class PlayerHealth{
	public float playerHealth;
	public float damageResist; 
}

public class Weapon{
	public PlayerHealth playerOne;
	public int weaponDamage;
	public void DoDamage(){
		playerOne = new PlayerHealth();
		
		playerOne.playerHealth = 8f;
		playerOne.damageResist = 1.0f;
		
		playerOne.playerHealth = playerOne.playerHealth - weaponDamage * playerOne.damageResist;
		Console.WriteLine(playerOne.playerHealth);
	}
}