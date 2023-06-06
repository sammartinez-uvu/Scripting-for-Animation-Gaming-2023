using System;
					
public class Program
{
	public static void Main()
	{
		string[] inventory = {"Diamonds", "Gold", "Silver", "Iron"};
		foreach(var currentInventory in inventory){
			inventory[0] = "Empty";
			Console.WriteLine(currentInventory);
		}
		foreach(var currentInventory in inventory){
			inventory[0] = "Empty";
			Console.WriteLine(currentInventory);
		}
	}
}