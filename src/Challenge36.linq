<Query Kind="Program" />

/*
	Given the number of "Imposters" (i) and the "Player" count (p),
	calculate the chances of being an imposter. Make sure to round
	the value to the nearest integer and return the value as a percentage
*/

void Main()
{
	ImposterFormula(1, 8).Dump();
}

public string ImposterFormula(int i, int p)
{
	double formula = Math.Round(100.0 * i / p, 0, MidpointRounding.AwayFromZero);
	return $"{formula}%";
}

// You can define other methods, fields, classes and namespaces here