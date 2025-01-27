using System;

class SpringSeason
{
    public static bool IsSpringSeason(int month, int day){
        if (month == 3 && day >= 20 || month == 6 && day <= 20 || month == 4 || month == 5)
            return true;
        return false;
    }

    static void Main(string[] args){
        Console.WriteLine("Enter month and day:");
        int month = int.Parse(Console.ReadLine());
        int day = int.Parse(Console.ReadLine());
        Console.WriteLine("Is Spring Season: " + IsSpringSeason(month, day));
    }
}