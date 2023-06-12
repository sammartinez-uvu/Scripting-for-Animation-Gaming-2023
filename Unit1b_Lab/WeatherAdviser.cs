using System;
					
public class TemperatureAdviser
{
	public void Main() {
		//setting the current temperature
		var currentTemp = 35;
		Console.WriteLine("The current temperature is " + currentTemp);
		
		//if high temperatures then warn user, else say it's totally fine
		if(currentTemp > 30){
		Console.WriteLine("Stay hydrated and avoid staying in the sun for too long!");
		} else {
		Console.WriteLine("Enjoy the wonderful weather!");
		Console.WriteLine("...");
		Console.WriteLine("Unless it's like 0 then maybe not ideal, in fact I should write a script with a switch function about that...");
		Console.WriteLine("eh we'll save it for the challange assignment");
		}
	}
}

