using System;
					
public class Program
{
	public Weapon rifle;
	public PlayerHealth playerOne;
	
	public void Main()
	{
		rifle = new Weapon();
		playerOne = new PlayerHealth();
		
		rifle.weaponDamage = 4;
		
		playerOne.playerHealth = 8f;
		playerOne.damageResist = 1.3f;
		
		DoDamage();
		
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