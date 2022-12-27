namespace Reto__0___EL_FAMOSO_FIZZ_BUZZ__Fácil_;
class Tools
{
    public static bool IsItAMultipleOf(int multiple, int number)
    {
        return multiple % number == 0;
    }
}


class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 100; i++)
        {
            if (Tools.IsItAMultipleOf(i, 3) && Tools.IsItAMultipleOf(i, 5))
                System.Console.WriteLine("fizzbuzz");

            else if(Tools.IsItAMultipleOf(i, 3))
                System.Console.WriteLine("fizz");

            else if (Tools.IsItAMultipleOf(i, 5))
            {
                System.Console.WriteLine("buzz");
            }
            else
                System.Console.WriteLine(i);
        }
        System.Console.Read();
    }
}