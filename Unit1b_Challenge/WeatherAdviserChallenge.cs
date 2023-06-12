//This script is designed to show the current temprature and if it's warm, cold, or nice
using System;
					
public class TemperatureAdviser
{
	public WeatherStates weatherStates;
	public void Main() {
		//setting the current temperature
		weatherStates = new WeatherStates();
		weatherStates.currentState = WeatherStates.States.Warm;
		weatherStates.CheckState();
	}

	public class WeatherStates {
		public enum States {
		Warm,
		Nice,
		Cold
	}
		public States currentState = States.Warm;
		public void CheckState() {
			//Set the current Temprature
			int currentTemp = 5;
			
			//Checks temprature compared to possible lables of Warm, Nice, and Cold
			if(currentTemp >= 30){
				currentState = States.Warm;
			}
			if(currentTemp >= 20){
				currentState = States.Nice;
			}
			if(currentTemp < 20){
				currentState = States.Cold;
			}
			
			// Results of Weather Forcast
			switch (currentState){

				case States.Warm:
					Console.WriteLine("The current temprature is " + currentTemp + " degrees. Which means it's" + currentState);
					Console.WriteLine("Don't forget sunscreen");
					break;
				case States.Nice:
					Console.WriteLine("The current temprature is " + currentTemp + " degrees. Which means it's " + currentState);
					Console.WriteLine("Nice Weather, enjoy!");
					break;
				case States.Cold:
					Console.WriteLine("The current temprature is " + currentTemp + " degrees. Which means it's" + currentState);
					Console.WriteLine("Be sure to wear warm clothing");
					break;
			}
		}
	}
}
