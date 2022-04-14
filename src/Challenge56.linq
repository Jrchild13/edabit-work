<Query Kind="Program" />

/*
	 Create a function that returns the 
	greatest common divisor (GCD) of two integers
*/

void Main()
{
	GCD(17, 13).Dump();
}

public int GCD(int n1, int n2)
{
	int gcd = 0;
	int[] nums = new int[2];
	nums[0] = n1;
	nums[1] = n2;
	for (int i = 1; i < nums.Max(); i++)
	{
		if (nums[0] % i == 0 && nums[1] % i == 0)
		{
			gcd = i;
		}
	}
	return gcd;
}

// You can define other methods, fields, classes and namespaces here