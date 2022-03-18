<Query Kind="Program" />

/*
Return the Remainder from Two Numbers- There is a single 
operator in C#, capable of providing the remainder of a 
division operation. Two numbers are passed as parameters.
The first parameter divided by the second parameter will 
have a remainder, possibly zero. Return that value.
*/

void Main()
{
	Remainder(7, 4).Dump();
}

public static int Remainder(int x, int y)
{
	return x % y;
}