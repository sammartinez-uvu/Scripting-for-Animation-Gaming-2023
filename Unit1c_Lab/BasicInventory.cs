using System;
					
public class Program
{
	public static void Main()
	{
        //Displays the Inventory
		string[] inventory = {"Diamonds", "Gold", "Silver", "Iron"};
		foreach(var currentInventory in inventory){
			inventory[0] = "Empty";
			Console.WriteLine(currentInventory);
		}
        //Displays an updated Inventory after changing slot 0 to "Empty"
		foreach(var currentInventory in inventory){
			inventory[0] = "Empty";
			Console.WriteLine(currentInventory);
		}
	}
}