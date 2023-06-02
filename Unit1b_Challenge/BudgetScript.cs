//This script was created to figure out my budget for the upcoming school year.  Current numbers do not reflect my current financial situation
//It is based off of potential costs I could think of plus general cost of living in Orem
//I do plan on using this to help me with my budgeting in the future though
using System;
					
public class Budget
{
	public static void Main()
	{
		//monthly expenses
		var insurance = 60;
		var carLoan = 100;
		var adobe = 30;
		var food = 150;
		var phone = 20;
		
		//expenses + rent
		var homeExpenses = insurance + carLoan + adobe + food + phone;
		var rent = 750;
		var utilities = 92;
		var internet = 30;
		
		var totalRent = (rent + utilities + internet);
		var monthlyExpense = homeExpenses + totalRent;
		
		//earnings and current account amount
		var currentBalance = 10000;
		var monthlyEarnings = 1500;
		
		var leaseLength = 12;
		
		var totalExpense = monthlyExpense * leaseLength;
		
		var monthlyEndingBalance = monthlyEarnings - monthlyExpense;
		var totalEndingBalance =  currentBalance + (monthlyEarnings * leaseLength) - totalExpense;
		
		//Writing Results
		Console.WriteLine("Monthly Earnings: " + monthlyEarnings);
		Console.WriteLine("Monthly Expense: " + monthlyExpense);
		Console.WriteLine("Monthly End Balance: " + monthlyEndingBalance);
		Console.WriteLine("Total Ending Balance: " + totalEndingBalance);
		
		if(monthlyEndingBalance < 0){
			Console.WriteLine("Not enough money to cover monthly expenses");
		} else {
			Console.WriteLine("Enough to cover monthly expenses");
		}
		
		if(totalEndingBalance < 0){
			Console.WriteLine("Not enough money to cover total expenses");
		} else {
			Console.WriteLine("Enough to cover total expenses");
		}
	}
}