using System;
					
public class Program
{
	Random rnd = new Random();
	int iAmNotBored = 0;
	public void Main()
	{
		int nowImBored = rnd.Next(0, 10);
		while (iAmNotBored < nowImBored){
			Console.WriteLine("I'm having fun right now!");
			iAmNotBored++;
		}
		Console.WriteLine("I'm bored now");
	}
}