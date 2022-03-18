<Query Kind="Expression" />

/*
Divides Evenly- Given two integers, a and b, 
return true if a can be divided evenly by b. 
Return false otherwise.
*/

void Main()
{
	DividesEvenly(10, 25).Dump();
}

public static int DividesEvenly(int a, int b)
{
	if (a % b == 0) { return true; }
	return false;
}