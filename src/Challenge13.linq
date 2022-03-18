<Query Kind="Program" />

/*
Basic Variable Assignment- A student learning C# was trying
to make a function. His code should concatenate a passed string
name with string "Edabit" and store it in a variable called result.
He needs your help to fix this code.
*/

void Main()
{
	NameString("banana").Dump();
}

public static string NameString(string name)
{
	string b = "Edabit";
	string result = name + b;
	return result;
}