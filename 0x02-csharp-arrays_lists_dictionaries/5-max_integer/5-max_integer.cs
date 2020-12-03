using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList)
    {
	int max;
        if (myList == null)
        {
            Console.WriteLine("List is empty");
            return (-1);
        }

        max = myList[0];
        
	foreach (var element in myList)
	{
		if (element > max)
		{
			max = element;
		}
	}
	return (max);
    }
}
