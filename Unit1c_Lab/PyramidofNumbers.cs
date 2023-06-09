using System;
					
public class Program
{
	public static void Main()
	{
		//rows sets how many rows there will be in this pyramid of numbers
		int rows = 5;
		//for loop to create those rows
		for(int i = 0; i < rows ; i++){
			//for loop to add however many numbers there are 2 would be 22 5 would be 55555
			for(int j = 0; j < i; j++){
				Console.Write(i+1);
			}
			
			Console.WriteLine(i+1);
			
		}
	}
}