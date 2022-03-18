<Query Kind="Program" />

/*
Convert Minutes into Seconds- Write a function that takes an 
integer minutes and converts it to seconds.
*/

void Main()
{
	Convert(120).Dump();
}

public int Convert(int minutes)
{
	return minutes * 60;
}