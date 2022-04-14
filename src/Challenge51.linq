<Query Kind="Program" />

/*
	 Given a function as a string, 
	return whether or not it is greater than 1 when evealuated
*/

void Main()
{
	GreaterThanOne("10/10").Dump();
}

public bool GreaterThanOne(string str)
{
	double[] arr = Array.ConvertAll(str.Split('/'), double.Parse);
	if (arr[0] / arr[1] > 1)
	{
		return true;
	}
	return false;
}

// You can define other methods, fields, classes and namespaces here