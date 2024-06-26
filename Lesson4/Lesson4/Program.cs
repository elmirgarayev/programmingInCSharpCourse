using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        /*
        string var1 = Console.ReadLine();

        switch (var1)
        {
            case "5":
            case "6":
            case "7":
            case "8":
                Console.WriteLine("Number is {0}", var1);
                break;
            default:
                Console.WriteLine("Other number");
                break;
        }
        */

        int var2 = int.Parse(Console.ReadLine());

        string result;

        result = var2 >= 5 ? "true" : "false";

        if (var2 >= 5)
        {
            result = "true";
        }
        else
        {
            result = "false";
        }

        

        Console.ReadLine();

    }

    static void Main7(string[] args)
    {
        

        string var1 = Console.ReadLine();

        if (var1 == "5") 
        {
            Console.WriteLine("Number is {0}", var1);
        }
        else if(var1 == "6")
        {
            Console.WriteLine("Number is {0}", var1);
        }
        else
        {
            Console.WriteLine("Other Number");
        }
        Console.WriteLine("Program ended");


        Console.ReadLine();
    }

    static void Main5(string[] args)
    {
        int[,] dim2Array1 = new int[2, 3];

        dim2Array1[0, 0] = 5;
        dim2Array1[0, 1] = 6;
        dim2Array1[0, 2] = 7;
        dim2Array1[1, 0] = 8;
        dim2Array1[1, 1] = 9;
        dim2Array1[1, 2] = 10;



        Console.WriteLine(dim2Array1.Length);
        Console.WriteLine(dim2Array1.Rank);
        Console.WriteLine(dim2Array1.GetLength(0));
        Console.WriteLine(dim2Array1.GetLength(1));

        var sum2DimArray = 0;

        for (int i = 0; i < dim2Array1.GetLength(0); i++)
        {
            for (int j = 0; j < dim2Array1.GetLength(1); j++)
            {
                sum2DimArray += dim2Array1[i,j];
            }
        }

        Console.WriteLine(sum2DimArray);

        Console.ReadLine();
    }

    static void Main4(string[] args)
    {
        int length = int.Parse(Console.ReadLine());

        int[] array1 = new int[length];
        array1[0] = 5;
        array1[1] = 6;
        array1[2] = 19;

        int sum = 0;

        for (int i = 0; i < array1.Length; i++)
        {
            sum += array1[i];
        }

        Console.WriteLine($"Sum is {sum}");

        int[] array2 = new int[50];
        var random = new Random();

        for (int i = 0;i < array2.Length; i++)
        {
            array2 [i] = random.Next(0, 100);
            Console.WriteLine(array2[i]);
        }

        Console.WriteLine("Max number is:");
        Console.WriteLine(array2.Max());

        Console.WriteLine(array2.Length);


        Console.ReadLine();
    }

    static void Main3(string[] args)
    {
        const double pi = 3.14;

        DateTime date1 = DateTime.Now;

        DateTime date2 = DateTime.Parse("11.06.2023 23:59:59");

        TimeSpan timeRange = date1 - date2;

        Console.WriteLine(timeRange);

        string stringResult = $"TimeRange is {timeRange}, year is {timeRange.Days / 365}, days is {timeRange.Days}";
        string stringResult2 = string.Format("TimeRange is {0}, year is {1}, days is {2}", timeRange, timeRange.Days / 365, timeRange.Days);

        Console.WriteLine(stringResult);
        Console.WriteLine(stringResult2);
        Console.WriteLine("TimeRange is {0}, year is {1}, days is {2}", timeRange, timeRange.Days / 365, timeRange.Days);

        Console.WriteLine((int)date1.DayOfWeek);

        Console.WriteLine(date1.ToString("dd.MM.yyyy HH:mm:ss"));

        Console.ReadLine();
    }

    static void Main2(string[] args)
    {
        var studentType = (StudentType)int.Parse(Console.ReadLine());

        if (studentType == StudentType.BadStudent)
        {
            //do something
        }
        else if(studentType == StudentType.ExcellentStudent)
        {
            //do some other things
        }

        Console.ReadLine();
    }

    public enum StudentType : int
    {
        BadStudent = 1,
        GoodStudent = 4,
        VeryGoodStudent = 9,
        ExcellentStudent = 15
    }


    public enum DayOfWeek
    {
        Sunday = 0,
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6
    }

}