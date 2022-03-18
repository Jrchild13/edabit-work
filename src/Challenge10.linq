<Query Kind="Expression" />

/*
Is the Number Less than or Equal to Zero?-  
Create a function that takes a number as its only 
argument and returns true if it's less than or 
equal to zero, otherwise return false.
*/

void Main()
{
	GiveMeSomething("banana").Dump();
}

public static bool lessThanOrEqualToZero(int num)
{
	if (num <= 0) { return true; }
	return false;
}