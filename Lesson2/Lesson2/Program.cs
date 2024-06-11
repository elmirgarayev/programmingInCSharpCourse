internal class Program
{
    private static void Main(string[] args)
    {
        /*
        string str;
        str = Console.ReadLine();
        toDo1(str);
        

        string str1,str2;
        Console.WriteLine("Enter the name:");
        str1 = Console.ReadLine();
        Console.WriteLine("Enter the surname:");
        str2 = Console.ReadLine();
        toDo2(str1,str2);
        */

        Console.WriteLine("enter the radius");
        float radius = float.Parse(Console.ReadLine());
        toDo3(radius);


        Console.ReadLine();
    }

    public static void toDo1(string str)
    {
        str = new string(str.Reverse().ToArray());
        Console.WriteLine(str);
    }

    public static void toDo2(string str1, string str2) 
    {
        string str = str1 + " " + str2;
        str = str.ToUpper();
        Console.WriteLine(str);
    }

    public static void toDo3(float radius) 
    {
        Console.WriteLine(radius * radius * 3.14);
    }

    private static void Main1(string[] args)
    {
        byte var1 = 45;
        byte var2;

        var2 = byte.Parse(Console.ReadLine());

        int sum = var1 + var2;

        Console.WriteLine(sum);

        var intMin = int.MinValue;
        var intMax = int.MaxValue;

        float var3 = 567.890F;

        double var4 = 43525.453;
        
        double sum2 = var3 + var4;

        Console.WriteLine(sum2);

        bool var5 = (5 > 6) && (7 < 5);

        Console.WriteLine(var5);

        char var6 = 'A';
        char var7 = 'B';
        var concat = var6.ToString() +var7.ToString();
        
        Console.WriteLine(concat);

        var var8 = char.IsLetter(var6);
        var var9 = char.IsNumber(var7);

        Console.WriteLine(var8);
        Console.WriteLine(var9);

        string var10 = "dfaesfasdf";

        string var11 = var10.ToUpper();

        Console.WriteLine(var11);

        Console.ReadLine();
    }
}