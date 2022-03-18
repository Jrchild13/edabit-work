<Query Kind="Program" />

/*
Are the Numbers Equal?- Create a function that 
returns true when num1 is equal to num2; otherwise return false.
*/

void Main()
{
	IsSameNum(3, 5).Dump();
}

public static bool IsSameNum(int num1, int num2)
{
	if (num1 == num2) { return true; }
	return false;
}