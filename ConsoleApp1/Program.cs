
using System;

class MyClass
{
    public class MyDate
    {
        public int d, m, y;

        public MyDate(int d, int m, int y)
        {
            this.d = d;
            this.m = m;
            this.y = y;
        }
    };

    // To store number of days in all months.
    static int[] monthDays = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

    //To Counts number of leap years before the given date
    static int countLeapYears(MyDate d)
    {
        int years = d.y;       
        if (d.m <= 2)
        {
            years--;
        }
      
        return years / 4
            - years / 100
            + years / 400;
    }

    // Returns number of days between two given dates
    static int getDateDifference(MyDate dt1, MyDate dt2)
    {       
        int n1 = dt1.y * 365 + dt1.d;

        for (int i = 0; i < dt1.m - 1; i++)
        {
            n1 += monthDays[i];
        }

        var k = countLeapYears(dt1);
        n1 += k;
      
        int n2 = dt2.y * 365 + dt2.d;
        for (int i = 0; i < dt2.m - 1; i++)
        {
            n2 += monthDays[i];
        }
        n2 += countLeapYears(dt2);

        return (n2 - n1);
    }

    public static void Main(String[] args)
    {
       
        Console.WriteLine("Enter Date 1 Day:");
        var dt1Day = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Date 1 Month:");
        var dt1Month = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Date 1 Year:");
        var dt1Year = Convert.ToInt32(Console.ReadLine());
        MyDate date1 = new MyDate(dt1Day, dt1Month, dt1Year);

        Console.WriteLine("Enter Date 2 Day:");
        var dt2Day = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Date 2 Month:");
        var dt2Month = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Date 2 Year:");
        var dt2Year = Convert.ToInt32(Console.ReadLine());
        MyDate date2 = new MyDate(dt2Day, dt2Month, dt2Year);

        Console.WriteLine("Difference between two dates is "
                        + getDateDifference(date1, date2));
    }
}


