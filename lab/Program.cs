
using System; 

public class Program
{
    public static void Main(string[] args)
    {

        string? input = Console.ReadLine();
        int F = Convert.ToInt32(input);
        double c = (F - 32) * 5/9;
        Console.WriteLine("celsius is"+ c);

    }
}
