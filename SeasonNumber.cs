using System;

class Program
{
    static void Main(string[] args)
    {
        MonthlySeasonClass.SeasonNumber();
    }
}
public class MonthlySeasonClass
{
    public static void SeasonNumber()
    {
        Console.Write("Type a month number: ");
        var month = Console.ReadLine();

        if (int.TryParse(month, out int season))
        {
            switch (season)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Winter");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Spring");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Summer");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Autumn");
                    break;
                default:
                    Console.WriteLine("Invalid month!");
                    break;
            }
        }
        else
        {
            Console.WriteLine("That is not a number!");
        }
    }
}
