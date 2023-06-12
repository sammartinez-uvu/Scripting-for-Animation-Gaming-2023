//This code is designed to have player 1 and 2 change their character's details (inputs): name, age, and class
//Code outputs a console line of text using those variables to describe the character

using System;
					
public class PlayerCreation
{

	public void Main()
	{
		//creates instances of characters 1&2
        playerOne = new PlayerCreation();
		playerTwo = new PlayerCreation();
		
        //Initializes variables for player 1
        playerOne.name = "name_here";
        playerOne.age = "age_here";
        playerOne.characterClass = "Wizard";

        //Initializes variables for player 2
        playerTwo.name = "name_here";
        playerTwo.age = "age_here";
        playerTwo.characterClass = "Rouge";
		
		//Outputs text for player 1's character
		Console.WriteLine("Hello " + playerOne.name + ", you just had a birthday yes? Wow you're already " + playerOne.age + "?");
        Console.WriteLine(" Wow and you've already started to train as a " + playerOne.characterClass);

        //Outputs text for player 2's character
		Console.WriteLine("Hello " + playerTwo.name + ", you just had a birthday yes? Wow you're already " + playerTwo.age + "?");
        Console.WriteLine(" Wow and you've already started to train as a " + playerTwo.characterClass);
	}
	public PlayerCreation playerOne;
    public PlayerCreation playerTwo;
	public string name;
	public string age;
	public string characterClass;
}
