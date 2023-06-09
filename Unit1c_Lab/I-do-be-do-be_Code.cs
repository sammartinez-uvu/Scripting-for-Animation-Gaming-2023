using System;
					
public class Program
{
	public static void Main()
	{
        //while and do loop writing dobedobedo until i reaches 5
		int i = 0;
		do{
			Console.WriteLine("dobedobedo");
			i++;
		}
		while(i < 5);
		
        //for loop repeats 3 times "i be"
        //for every time i be shows up the second for loop states "da stooooopid"
		for(int j = 0; j < 3; j++){
			Console.WriteLine("i be");
			for(int k = 0; k < 1; k++){
				Console.WriteLine("da stoooopid");
			}
			
		}
	}
	
}