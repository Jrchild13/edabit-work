<Query Kind="Program" />

/*
Profitable Gamble- Create a function that takes three
arguments prob, prize, pay and returns true if prob * prize > pay;
otherwise return false.
*/

void Main()
{
	ProfitableGamble(0.2, 50, 9).Dump();
}

public static bool ProfitableGamble(double prob, double prize, double pay)
{
	if (prob * prize > pay) { return true; }
	return false;
}