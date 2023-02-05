using System;
					
public class Program
{
	public Status checkStatus;
	
	public void Main()
	{
		checkStatus = new Status();
		checkStatus.status = Status.State.run;
		checkStatus.CheckStatus();
	}
}


public class Status {
	public enum State {
		start,
		run,
		dead,
		stop
	}
	public State status = State.start;
	
	public void CheckStatus() {
		switch (status){
			case State.start:
				Console.WriteLine("The game is starting");
				break;
			case State.run:
				Console.WriteLine("The game is running");
				break;
			case State.dead:
				Console.WriteLine("The player is dead");
				break;
			case State.stop:
				Console.WriteLine("The game is stopping");
				break;
		}
	}
}