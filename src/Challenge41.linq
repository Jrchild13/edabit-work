<Query Kind="Program" />

/*
	  Create a function that repeats 
	each character in the given string "n" times
*/

void Main()
{
	Repeat("mice", 5).Dump();
}

public string Repeat(string str, int num)
{
	StringBuilder sb = new StringBuilder();
	foreach (char letter in str)
	{
		sb.Append(letter, num);
	}
	return sb.ToString();
}

// You can define other methods, fields, classes and namespaces here