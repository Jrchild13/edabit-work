<Query Kind="Program" />

/*
	  Create a function that takes an array 
	of strings and returns the words that are exactly 4 letters long
*/

void Main()
{
	IsFourLetters(new string[] { "Kangaroo", "Bear", "Fox"}).Dump();
}

public string[] IsFourLetters(string[] arr)
{
	List<string> fourChars = new List<string>();
	foreach (string word in arr)
	{
		if (word.Length == 4)
		{
			fourChars.Add(word);
		}
	}
	return fourChars.ToArray();
}

// You can define other methods, fields, classes and namespaces here