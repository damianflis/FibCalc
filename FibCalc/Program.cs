internal class Program
{
    private static long Fibonacci(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
    private static void Main(string[] args)
    {
        int length = 0;
        Console.WriteLine("FibCalc\nDamian Flis\nI2S 2.2\n");
        while (length >= 0)
        {
            Console.WriteLine("What element of Fibonacci you want to know? ");
            Console.WriteLine("If you want to exit, write negative number ");
            while (!int.TryParse(Console.ReadLine(), out length))
            {
                Console.WriteLine("You entered an invalid number\n");
                Console.WriteLine("What element of Fibonacci you want to know? ");
                Console.WriteLine("If you want to exit, write negative number ");
            }
            if (length >= 0)
                Console.WriteLine("{0} element of Fibonacci Sequence is {1}\n", length, Fibonacci(length));
        }
    }
}