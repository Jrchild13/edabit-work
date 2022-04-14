<Query Kind="Program" />

/*
	 Create a function that takes an 
	equation (e.g. "7*4-2"), and returns the answer
*/

void Main()
{
	Equation("7*4-2").Dump();	
}

public int Equation(string str)
{
	string math = str;
	string value = new DataTable().Compute(math, null).ToString();
	return Convert.ToInt32(value);
}

// You can define other methods, fields, classes and namespaces here