<Query Kind="Expression" />

/*
Concatenate First and Last Name into One String- 
Given two strings, firstName and lastName, return
a single string in the format "last, first".
*/

void Main()
{
	ConcatName(Bobby, Swager).Dump();
}

public static string ConcatName(string firstName, string lastName)
{
	return lastName + ", " + firstName;
}