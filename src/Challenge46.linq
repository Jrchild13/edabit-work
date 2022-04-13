<Query Kind="Program" />

/*
	  	A palindrome is a word that is identical forward and backwards.
	
	examples:
		-mom
		-racecar
		-kayak
	
	Given a word, create a function that checks whether it is a palindrome.
*/

void Main()
{
	CheckPalindrome("mom").Dump();
}

public bool CheckPalindrome(string str)
{
	string reversed = new string(str.ToCharArray().Reverse().ToArray());

	if (str.Equals(reversed))
	{
		return true;
	}
	else
	{
		return false;
	}
}

// You can define other methods, fields, classes and namespaces here