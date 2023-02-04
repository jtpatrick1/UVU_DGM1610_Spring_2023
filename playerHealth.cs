using System;
					
public class Program
{
	public Health player;
	public Health player2;
		
	public void Main()
	{
		player = new Health();
		player2 = new Health();
		player2.playerHealth = player2.playerHealth - 3;
		player2.playerName = "Steve";
		Console.WriteLine(player2.playerName + " has health: " + player2.playerHealth);
		Console.WriteLine(player.playerName + " has health: " + player.playerHealth);
	}
}

public class Health {
	public int playerHealth = 5;
	public string playerName = "Bob";
	public float playerStrength = 1.3f;
}
