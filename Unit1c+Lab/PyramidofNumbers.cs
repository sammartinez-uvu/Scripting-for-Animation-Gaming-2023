using System;
					
public class Program
{
	public static void Main()
	{
		int rows = 5;
		for(int i = 0; i < rows ; i++){
			
			for(int j = 0; j < i; j++){
				Console.Write(i+1);
			}
			Console.WriteLine(i+1);
			
		}
	}
}