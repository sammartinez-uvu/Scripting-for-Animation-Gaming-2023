/*I'm having a hard time with this script.  First off I don't know how to create a random number
Maybe I need to do some stuff with arrays or something but I'm stumped
The next issue is getting a single input from the user then running the code again
Maybe I forgot how to do it but my brain is fried and I'll come back to this issue and work on
All the commented code is me trying to figure out a solution to the input problem

*/
using System;
					
public class NumberGame{
	
	//public Inputs myInput;
	public void Main(){
		
		/*myInput = new Inputs();
		myInput.FindInput(5); */
		
		
		int guessAmount = 5; //how many guess are aloted
		int guessInput = 5; //the guess input the user uses
		int guessTotal = 0; //how many guesses have been used
		int randomNumber = 7; //the random number
		for(int i = 0; i < guessAmount ; i++){;
			if(guessInput > randomNumber){
				guessTotal ++;
				Console.WriteLine("Too High.  You have " + (guessAmount - guessTotal) + " guesses left");
			}
			if(guessInput < randomNumber){
				guessTotal++;
				Console.WriteLine("Too Low.  You have " + (guessAmount - guessTotal) + " guesses left");
			}
			if(guessInput == randomNumber){
				guessTotal++;
				Console.WriteLine("YOU WIN.  You did it in " + (guessAmount - guessTotal) + " guesses");
			}
			
		}
	}
}
/*
public class Inputs{
	public void FindInput(int value){
		int guessInput = value;
	}
}
*/