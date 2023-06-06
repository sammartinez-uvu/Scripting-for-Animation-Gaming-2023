using System;
					
public class Program
{
	public static void Main()
	{
		int[] pyramid = {1, 2, 3, 4, 5};
		for(int i = 0; i < pyramid.Length; i++){
			Console.WriteLine(pyramid[i]);
			for(int j = 0; j < i; j++){
				Console.Write(i);
			}
			
		}
	}
	
}