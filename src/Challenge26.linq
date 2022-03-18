<Query Kind="Expression" />

/*
Multiple of 100- Create a function that takes 
an integer and returns true if it's divisible 
by 100, otherwise return false.
*/

void Main()
{
	Frames(10, 25).Dump();
}

public static bool Divisible(int num)
{
	if (num % 100 == 0) { return true; }
	return false;
}