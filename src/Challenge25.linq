<Query Kind="Expression" />

/*
Check if an Integer is Divisible By Five- Create a 
function that returns true if an integer is evenly 
divisible by 5, and false otherwise.
*/

void Main()
{
	Frames(10, 25).Dump();
}

public static bool DivisibleByFive(int n)
{
	if (n % 5 == 0) { return true; }
	return false;
}