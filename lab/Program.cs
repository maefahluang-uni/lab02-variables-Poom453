
using System; 

public class Program
{
    public static void Main(string[] args)
    {

        string? input = Console.ReadLine();
        int fahrentheit = Convert.ToInt32(input);
        double celsuis = (fahrentheit - 32) * 5/9;
        Console.WriteLine(celsuis);

    }
}
