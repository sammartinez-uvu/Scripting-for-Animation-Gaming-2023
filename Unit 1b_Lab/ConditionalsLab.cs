//This code has both Conditionals AND Switches
//because I thought it was all one code we had to put it into
//instead of seeing the other switches example code

//This code should output the results of... 
//DoMath: two vars adding together and a string asking if value1 >= to value2
//Compare: I did not change the origial code because I kind of did it in the DoMath section
//OpenTheAirlockDoors: inputing a password and if it is the correct one "OVERRIDE LEVEL 7" then it will output a movie quote
//characterStates: has 3 possible states it can output: Idle, Running, and Jumping and output as a string

using System;
					
public class Program
{
	public Operations myOperator;
	
	public CharacterStates characterStates;
	
	public void Main()
	{
		myOperator = new Operations();
		
		Console.WriteLine("Welcome");
		//modified the values to test the different If statements
		myOperator.DoMath(10, 4);
		myOperator.DoMath(20, 20);
		myOperator.DoMath(5, 15);
		myOperator.Compare(4,3);
		myOperator.Compare(3,4);
		myOperator.OpenTheAirlockDoors("SevenOF9");
		myOperator.OpenTheAirlockDoors("OVERRIDE LEVEL 7");
		
		///This should output what state is the current state
		//setting the character state
		characterStates = new CharacterStates();
		//default character state
		characterStates.currentState = CharacterStates.States.Idle;
		//which state are we in
		characterStates.CheckState();
		
	}
}

public class Operations {
	public void DoMath (int value, int value2) {
		var number = value + value2;
		Console.WriteLine(number);
		//adding an IF statement and an Else statement
		if(value >= value2){
			Console.WriteLine("It do be greater or equal to. Yeehaw!");
		} else {
			Console.WriteLine("Eh it's close enough... right?");
		}
	}
	
	public void Compare (int value, int value2) {
		if(value > value2) {
			Console.WriteLine("True, the first greater.");
		} else {
			Console.WriteLine("False, the second is greater.");
		}
	}
	
	//changed the variable name, and the resulting dialog
	public void OpenTheAirlockDoors (string manualOverride) {
		if(manualOverride == "OVERRIDE LEVEL 7") {
			Console.WriteLine("I'm sorry Dave, but I'm afraid I can't do that >:D ");
		} else {
			Console.WriteLine("ACCESS DENIED");	
		}
	}
}
	
//adding a Switch statement
public class CharacterStates {
	public enum States {
		Idle,
		Running,
		Jumping,
	}
	
	public States currentState = States.Idle;
		
	public void CheckState(){
		switch (currentState){
			case States.Idle:
				Console.WriteLine("Idle");
				break;
			case States.Running:
				Console.WriteLine("Running");
				break;
			case States.Jumping:
				Console.WriteLine("Jumping");
				break;
		}
	}
}
