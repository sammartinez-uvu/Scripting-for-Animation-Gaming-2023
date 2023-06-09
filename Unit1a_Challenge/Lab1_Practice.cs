//This script is designed to change the result of the battle depending on which variables are altered
//Changing the hasBigSword value changes the currentHeroPowerLevel
//If the currentHeroPowerLevel is below the single enemyPowerLevel the hero loses a life
//Otherwise one of the enemies dies and the battle continues
//At the end there can be 3 results: 1. the battle is ongoing, 2. the hero wins, 3. the hero loses
//Battle ongoing means the hero has lives and there are still enemies
//The hero wins when there are no more enemies
//the hero loses when they run out of lives
using System;

public class EnemyEncounter
{
    public static void Main(string[] args)
    	{
		
		//Initializing Big Sword Stats
		double bigSword;
		bool hasBigSword = true;
		
		//Is Big Sword Equiped?
		if(hasBigSword == true)
		{
			//yes
			bigSword = 2.5;
		}
		else{
			//no
			bigSword = 0;
		}
		
		
		//Initializing Hero Stats
		int heroLives = 5;
		double baseHeroPowerLevel = 5.0;
		double currentHeroPowerLevel = baseHeroPowerLevel + bigSword;

		
        //Initializing how many enemies and how strong they are
		int numbOfEnemies = 3;
		double enemyPowerLevel = 5.5;
		double totalEnemyStats;
		totalEnemyStats = numbOfEnemies * enemyPowerLevel;
		
		//The Dialog for what the enemy count/results are
		string enemyAnalysis;
		string gameOver = "The Hero Has fallen, Game Over";
		
		//If the hero is alive
		if(heroLives > 0)
		{
		//If enemy power is greater than hero power then hero lose life, else 1 enemy dies
		if(enemyPowerLevel > currentHeroPowerLevel)
			{
			heroLives --;
			}
		else
			{
			numbOfEnemies --;
			}
			
			//If there are still enemies alive: state how many are left, else, end the battle with end battle text
			if(numbOfEnemies > 0)
				{
				//If there are enemies remaining
				enemyAnalysis = numbOfEnemies + " Enemies left with a total power of " + totalEnemyStats + " watch out!";

				//Write out the results
				Console.WriteLine(enemyAnalysis);
				}	
			else{
				//If there are no enemies left
				enemyAnalysis = "There are no more enmeies left.  Great Job!";
				//Write out the results
				Console.WriteLine(enemyAnalysis);
				}
		}
		
		//If the Hero Dies
		if(heroLives <= 0)
		{
			//write out game over screen
			Console.WriteLine(gameOver);
		}
		
		//whether alive or dead write out the Hero's stats
		string heroStats = "Hero Lives: " + heroLives + " , Hero Power: " + currentHeroPowerLevel;
		Console.WriteLine(heroStats);
   	}    
}