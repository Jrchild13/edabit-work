<Query Kind="Program" />

/*
Boolean to String Conversion- Create a function that
takes a boolean variable flag and returns it as a string.
*/

void Main()
{
	BoolToString(true).Dump();
}

public static string BoolToString(bool flag)
{
	return flag.ToString();
}