///This code is designed to display favorite foods.  Added items to the array past 4 will result in "An honorable mention goes to _______"

using System;
					
public class Program
{
	public static void Main()
	{
        //User's Favorite Food.  More food can be added by using a: ',' then the string: "Chips"
		string[] favoriteFood = {"Tacos", "Hamburger", "Pizza", "General Tao Chicken", "Pringles"};
		//Loops until the end of the array
		for(int i = 0; i < favoriteFood.Length; i++){
			switch(i){
				case 0:
					Console.WriteLine("I love " + favoriteFood[i]);
					break;
				case 1:
					Console.WriteLine("A close second is a " + favoriteFood[i]);
					break;
				case 2:
					Console.WriteLine("Although having " + favoriteFood[i] + " is always a good choice");
					break;
				case 3:
					Console.WriteLine("And don't forget " + favoriteFood[i]);
					break;
				case > 3:
					Console.WriteLine("An honorable mention goes to " + favoriteFood[i]);
					break;
					
			}
		}
	}
}