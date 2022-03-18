<Query Kind="Program" />

/*
Convert Hours and Minutes into Seconds- Write a 
function that takes two integers (hours, minutes),
converts them to seconds, and adds them.
*/

void Main()
{
	Convert(4, 27).Dump();
}

public static double Convert(int hours, int minutes)
{
	return (hours * 3600) + (minutes * 60);
}