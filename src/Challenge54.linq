<Query Kind="Program" />

/*
	 Create a function that takes a number as an
	argument and returns true or false depending on if the number reads the 
	same backwards and it does forwards
*/

void Main()
{
	IsSymmetrical(7227).Dump();
}

public bool IsSymmetrical(int num)
{
	string value = num.ToString();
	if (string.Concat(value.Reverse()) == value)
	{
		return true;
	}
	return false;
}

// You can define other methods, fields, classes and namespaces here