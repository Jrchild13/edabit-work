<Query Kind="Expression" />

/*
Compare Strings by Count of Characters- Create a function
that takes two strings as arguments and return either true 
or false depending on whether the total number of characters
in the first string is equal to the total number of characters 
in the second string.
*/

void Main()
{
	Comp("asdf", "jkl;").Dump();
}

public static bool Comp(string str1, string str2)
{
	if (str1.Length == str2.Length) { return true; }
	return false;
}