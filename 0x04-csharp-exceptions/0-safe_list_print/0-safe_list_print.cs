using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int count = 0;

        for (int element = 0; element < n; element++, count++)
        {
            try
            {
                Console.WriteLine(myList[element]);
            }
            catch (System.Exception)
            {
                break;
            }
        }

        return (count);
    }
}
