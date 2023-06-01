using System;
					
public class ExamGrader
{
	public void Main() {
		//initializing the grade
		var gradeValue = 100;
		Console.WriteLine(gradeValue);
		/*output changes depending on the grade
			
		100-90 A
		89-80 B
		79-70 C
		69-60 D
		59-0 F
			
		*/
		if(gradeValue >= 90){
			Console.WriteLine("A  Well done you're the best that ever bested");
		}
		if(gradeValue <= 89 && gradeValue >= 80){
			Console.WriteLine("B  Anyone that says C is average is wrong, it's B");
		}
		if(gradeValue <= 79 && gradeValue >= 70){
			Console.WriteLine(gradeValue + " C  This is failing in my household but sure be happy about it");
		}
		if(gradeValue <= 69 && gradeValue >= 60){
			Console.WriteLine("D  I get you don't like me or this subject but please attend a bit more often, okay?");
		}
		if(gradeValue <= 59 && gradeValue != 0 && gradeValue != 1){
			Console.WriteLine("F  Do us both a favor and pass because neither of us want you in this class again");
		}
		if(gradeValue == 0){
			Console.WriteLine("MISSING - JUST TURN IN YOUR WORK!!! I DON'T CARE YOU'LL GET MORE POINTS IF YOU JUST TURN IN YOUR ASSIGNMENTS PLEASE!!!!");
		}
		if(gradeValue == 1){
			Console.WriteLine("F  It's more impressive that you got a 1 than a 100 on this assignment");
		}
	}
}
