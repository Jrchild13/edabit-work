<Query Kind="Statements" />

/*
Return the Next Number from the Integer Passed- Create a function that 
takes a number as an argument, increments the number by +1 and returns the result.
*/

void Main()
{
	Addition(22).Dump();	
}

public class Program
{
	public static int Addition(int num)
	{
		return num + 1; 
	}
}