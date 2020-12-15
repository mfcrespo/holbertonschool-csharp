using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int number_list = 0;

        for (int element = 0; element < n; element++, number_list++)
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

        return (number_list);
    }
}
