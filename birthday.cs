using System;
using System.Linq;

namespace Birthday;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("enter name of the day you were born \n");
        string answer = Console.ReadLine().ToLower();
        switch (answer)
        {
            case "monday":
                Console.WriteLine("You were born on the first day of the week.");
                break;
            case "tuesday":
                Console.WriteLine("You were born on the second day of the week.");
                break;
            case "wednesday":
                Console.WriteLine("You were born on the third day of the week.");
                break;
            case "thursday":
                Console.WriteLine("You were born on the fourth day of the week.");
                break;
            case "friday":
                Console.WriteLine("You were born on the fifth day of the week.");
                break;
            case "saturday":
                Console.WriteLine("You were born on the sixth day of the week");
                break;
            case "sunday":
                Console.WriteLine("You were born on the seventh day of the week");
                break;
            default:
                Console.WriteLine("Please enter a valid day; Monday for example.");
                break;

        }



    }
}
