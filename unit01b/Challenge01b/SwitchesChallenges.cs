using System;
					
public class Program
{
	
	public Weapon rifle;
	public HeroHealth heroOne;
	
	public void Main()
	{
		rifle = new Weapon();
		heroOne = new HeroHealth();
		
		rifle.weaponDamage = 7;
		heroOne.heroHealth = 6;
		
		heroOne.heroHealth -= rifle.weaponDamage;
		Console.WriteLine(heroOne.heroHealth);
		
		if (heroOne.heroHealth <= 0 ){
			heroOne.healthStatus = HeroHealth.HealthStatus.dead;
		} else {
			heroOne.healthStatus = HeroHealth.HealthStatus.alive;
		}
		heroOne.CheckHealth();
	}
}

public class Weapon {
	public int weaponDamage;
}

public class HeroHealth {
	public int heroHealth;
	
	public enum HealthStatus {
		alive,
		dead
	}
	
	public HealthStatus healthStatus;
	
	public void CheckHealth() {
		switch (healthStatus){
			case HealthStatus.alive:
				Console.WriteLine("The hero is alive!");
				break;
			case HealthStatus.dead:
				Console.WriteLine("The hero is dead!");
				break;
		}
	}
}