//This code is designed to have player 1 and 2 change their character's details (inputs): name, age, and class
//Code outputs a console line of text using those variables to describe the character

using System;
					
public class PlayerCreation
{

	public void Main()
	{
		playerOne = new PlayerCreation();
		playerTwo = new PlayerCreation();
		
        playerOne.name = "name_here";
        playerOne.age = "age_here";
        playerOne.characterClass = "Wizard";

        playerTwo.name = "name_here";
        playerTwo.age = "age_here";
        playerTwo.characterClass = "Rouge";
		
		
		Console.WriteLine("Hello " + playerOne.name + ", you just had a birthday yes? Wow you're already " + playerOne.age + "?");
        Console.WriteLine(" Wow and you've already started to train as a " + playerOne.characterClass);

		Console.WriteLine("Hello " + playerTwo.name + ", you just had a birthday yes? Wow you're already " + playerTwo.age + "?");
        Console.WriteLine(" Wow and you've already started to train as a " + playerTwo.characterClass);
	}
	public PlayerCreation playerOne;
    public PlayerCreation playerTwo;
	public string name;
	public string age;
	public string characterClass;
}
