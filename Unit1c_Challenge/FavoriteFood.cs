/*
This code is designed to take the favoriteFood array and display it with "I love " + the array item
I wanted to make this more complex but I didn't just want to use a bunch of if statements, example if(i == 0){Console.WriteLine("Blah Blah Blah")}
I tried using a switch statement but I couldn't get it to work with the array without making a huge enum side quest

*/


using System;
					
public class Program
{
	public static void Main()
	{
        //User's Favorite Food.  More food can be added by using a ',' then the string "Chips"
		string[] favoriteFood = {"Tacos", "Hamburger", "Pizza", "General Tao Chicken"};
		//Loops until the end of the array
		for(int i = 0; i < favoriteFood.Length; i++){

				Console.WriteLine("I love " + favoriteFood[i]);
		}
	}
}