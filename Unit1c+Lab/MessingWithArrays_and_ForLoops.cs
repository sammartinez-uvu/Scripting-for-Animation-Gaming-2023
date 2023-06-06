using System;
					
public class Program
{
	public static void Main()
	{
		int[] pyramid = {5, 10, 15, 20, 25};
		for(int i = 0; i < 3; i++){
			Console.WriteLine(pyramid[i]);
			for(int j = 0; j < pyramid.Length; j++){
				Console.WriteLine(i+1);
			}
			
		}
	}
	
}