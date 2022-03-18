<Query Kind="Program" />

/*
Frames Per Second- Create a function that returns the
number of frames shown in a given number of minutes for 
a certain FPS.
*/

void Main()
{
	Frames(10, 25).Dump();
}

public static int Frames(int minutes, int fps)
{
	return (minutes * fps) * 60;
}