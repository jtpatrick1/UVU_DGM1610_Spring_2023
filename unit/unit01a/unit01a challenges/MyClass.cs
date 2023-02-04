//Use this file to store your work to demonstrate your understanding of operators
//Make sure your work is different from the instructors examples or your peers

//Based on the HelloWorld File, turn this into a class.

//Write a console program with a program class, and Main Function
//Add another class with any name, add variables 
//Using the new keyword create several objects
//Console writeline the Objects variables

using System;

public class DamageTaken{
	
	public Weapon pistol;
	public Weapon rifle;
	public Weapon rocketLauncher;
	
	public void Main(){
		pistol = new Weapon();
		rifle = new Weapon();
		rocketLauncher = new Weapon();
		
		pistol.weaponName = "pistol";
		pistol.weaponDamage = 1;
		pistol.weaponAmmo = 8;
		
		rifle.weaponName = "rifle";
		rifle.weaponDamage = 2;
		rifle.weaponAmmo = 20;
		
		rocketLauncher.weaponName = "rocket launcher";
		rocketLauncher.weaponDamage = 20;
		rocketLauncher.weaponAmmo = 1;
		
		Console.WriteLine("The " + pistol.weaponName + " does " + pistol.weaponDamage + " damage and has " + pistol.weaponAmmo + " ammo.");
		Console.WriteLine("The " + rifle.weaponName + " does " + rifle.weaponDamage + " damage and has " + rifle.weaponAmmo + " ammo.");
		Console.WriteLine("The " + rocketLauncher.weaponName + " does " + rocketLauncher.weaponDamage + " damabe and has " + rocketLauncher.weaponAmmo + " ammo.");

	}
}

public class Weapon{
	public string weaponName;
	public int weaponDamage;
	public int weaponAmmo;
}