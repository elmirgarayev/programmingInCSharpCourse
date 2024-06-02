internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number: ");

         int var1=0;

        while (true)
        {
            try
            {
                var1 = int.Parse(Console.ReadLine());
                break;
            }
            catch
            {
                Console.WriteLine("You must enter the number!");
                Console.WriteLine(" Enter the number again: ");
            }
        }

        Console.WriteLine("Enter the second number: ");
        int var2 = int.Parse(Console.ReadLine());

        int sum = Sum(var1 , var2);

        Console.WriteLine( "Sum is : " + sum);
    }

    public static int Sum(int var1, int var2)
    {
        return var1 + var2;
    }

}