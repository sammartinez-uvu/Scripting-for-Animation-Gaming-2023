//Use this file to store your work to demonstrate your understanding of operators
//Make sure your work is different from the instructors examples or your peers
using System;
					
public class Program
{
	public Hero heroOne;
	public Hero heroTwo;
	public Hero heroThree;
    public Hero heroFour;
	public void Main()
	{
		//Initializing Heros as variables
        heroOne = new Hero();
		heroTwo = new Hero();
        heroThree = new Hero();
        heroFour = new Hero();
		
        //Hero 1 Stats
		heroOne.health = 2;
		heroOne.powerLevel = 5;
        heroOne.speed = 2;
        heroOne.canDance = true;
		
        //Hero 2 Stats
		heroTwo.health = 3;
		heroTwo.powerLevel = 3;
        heroTwo.speed = 4;
        heroTwo.canDance = true;
		
        //Hero 3 Stats
		heroThree.health = 4;
		heroThree.powerLevel = 2;
        heroThree.speed = 3;
        heroThree.canDance = true;
		
        //Hero 4 Stats
		heroFour.health = 1;
		heroFour.powerLevel = 7;
        heroFour.speed = 1;
        heroFour.canDance = false;
        heroFour.thinksTheyCanDance = true;

        //Hero 1 Display Stats
		Console.WriteLine(heroOne.health);
		Console.WriteLine(heroOne.powerLevel);
        Console.WriteLine(heroOne.speed);
        Console.WriteLine(heroOne.canDance);
		
        //Hero 2 Display Stats
		Console.WriteLine(heroTwo.health);
		Console.WriteLine(heroTwo.powerLevel);
        Console.WriteLine(heroTwo.speed);
        Console.WriteLine(heroTwo.canDance);

        //Hero 3 Display Stats
		Console.WriteLine(heroThree.health);
		Console.WriteLine(heroThree.powerLevel);
        Console.WriteLine(heroThree.speed);
        Console.WriteLine(heroThree.canDance);
        
        //Hero 4 Display Stats
		Console.WriteLine(heroFour.health);
		Console.WriteLine(heroFour.powerLevel);
        Console.WriteLine(heroFour.speed);
        Console.WriteLine(heroFour.canDance);
        Console.WriteLine(heroFour.thinksTheyCanDance);
        
	}
}

public class Hero {
	public int health;
	public int powerLevel;
    public int speed;
    public bool canDance;
    public bool thinksTheyCanDance;
}