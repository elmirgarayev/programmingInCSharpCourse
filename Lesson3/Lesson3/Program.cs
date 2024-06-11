internal class Program
{

    private static void Main(string[] args) 
    {
        /*
        Console.WriteLine("Write the first number: ");
        int var1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Write the second number: ");
        int var2 = int.Parse(Console.ReadLine());

        Console.WriteLine(toDo1(var1, var2));
        

        Console.WriteLine("Write the first string: ");
        string var1 = Console.ReadLine();
        Console.WriteLine("Write the second string: ");
        string var2 = Console.ReadLine();

        Console.WriteLine(toDo2(var1, var2));
        */

        Console.WriteLine("Write the first number: ");
        int var1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Write the second number: ");
        int var2 = int.Parse(Console.ReadLine());

        Console.WriteLine(toDo3(var1, var2));

    }

    private static bool toDo1(int var1, int var2) 
    {
        if ((var1 % 2 == 0 &&  var2 % 2 == 0) || (var1 % 2 == 1 && var2 % 2 == 1)) 
        {
            return true;
        }
        else 
        {
            return false;
        }
    } 

    private static bool toDo2(string str1, string str2)
    {

        if (str1.Contains(str2))
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    private static float toDo3(int var1, int var2)
    {
        float var = (float)var1 / (float)var2;
        return var;
    }

    private static void Main4(string[] args)
    {
        var resul4 = sizeof(int);
        int a = 5;
        var resul5 = a.GetType() == typeof(int);

        bool result = a is int;
        
        

        long? b = 15;
        int? c = b as int?;

        Console.ReadLine();
    }



    private static void Main3(string[] args)
    {
        int var1 = int.Parse("4351324");

        var isItOK = int.TryParse(Console.ReadLine(), out int result);

        var var3 = Convert.ToBoolean(1);

        float var6 = 234234.2523F;

        var stringResult = Convert.ToString(var6);

        var var2 = float.Parse("3242.342");

        Console.ReadLine();
    }
    private static void Main2(string[] args)
    {

        // implicit or autoconversion

        byte var1 = 15;
        
        short var2 = var1;

        int var3 = var2;

        double var4 = var3;

        //explicit or manual conversion

        int var6 = 300;

        byte var7 = (byte)var6;

        Console.WriteLine(var7);

        int var8 = 50000;

        int var9 = int.Parse(Console.ReadLine());

        int var10 = var8 * var9;



        var2 = (short)var3;

        float var5 = (float)var4;



        Console.WriteLine("Hello, World!");
    }
}