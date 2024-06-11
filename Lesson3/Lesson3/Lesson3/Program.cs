internal class Program
{

    private static void Main(string[] args)
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