<Query Kind="Program" />

/*
Convert Age to Days- Create a function that takes the 
age inyears and returns the age in days.
*/

void Main()
{
	CalcAge(22).Dump();
}

public static int CalcAge(int age)
{
	return age * 365;
}