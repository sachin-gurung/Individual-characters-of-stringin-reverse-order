﻿using System;
public class Exercise4
{
    public static void Main()
    {
        string str;
        int l = 0;

        Console.Write("\n\nprint individual characters of string in reverse order :\n");
        Console.Write("------------------------------------------------------\n");
        Console.Write("Input the string : ");
        str = Console.ReadLine();

        l = str.Length - 1;
        Console.Write("The characters of the string in reverse are : \n");
        while (l >= 0)
        {
            Console.Write("{0} ", str[l]);
            l--;
        }
        Console.Write("\n\n");
    }
}
/*
print individual characters of string in reverse order :
------------------------------------------------------
Input the string : sachin gurung
The characters of the string in reverse are :
g n u r u g   n i h c a s

Press any key to continue . . .

*/