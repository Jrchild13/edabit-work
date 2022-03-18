<Query Kind="Program" />

/*
Return Something to Me!- Write a function that
returns the string "something" joined with a 
space " " and the given argument a.
*/

void Main()
{
	GiveMeSomething("banana").Dump();
}

public static string GiveMeSomething(string a)
{
	return "something " + a;
}