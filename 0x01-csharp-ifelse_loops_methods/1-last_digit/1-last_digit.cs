using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
	int lastdigit = (number % 10);
	if (lastdigit > 5)
	{
		Console.WriteLine($"The last digit of {number} is {lastdigit} and is greater than 5");
	}
	else if (lastdigit == 0)
	{
		Console.WriteLine($"The last digit of {number} is {lastdigit} and is 0");
	}
	else if (6 > lastdigit && lastdigit !=0)
	{
		Console.WriteLine($"The last digit of {number} is {lastdigit} and is less than 6 and not 0");
	}
    }
}
