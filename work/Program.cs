using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class QueryAString
{
    public static void Main()
    {
        string aString = "ABCDE99F-J74-12-89A";

        string number = Console.ReadLine();
        int index = Convert.ToInt32(number);

        
        IEnumerable<char> stringQuery2 = aString.Skip(index - 1).Take(aString.Count());

       
        foreach (char c in stringQuery2)
            Console.Write(c);

        Console.WriteLine(System.Environment.NewLine + "Press any key to exit");
        Console.ReadLine();
    }
}








