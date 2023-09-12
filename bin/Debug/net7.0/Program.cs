namespace task2._0;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("enter you name please!");
        Console.ReadLine();

        {
            int number;
            Console.WriteLine("enter a number");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" the divisors for the number {0} are", number);
            Console.WriteLine("{0} {1}", 1, number);
            for (int divisor = 2; divisor <= (number / 2); divisor++)
                if ((number % divisor) == 0)
                    Console.WriteLine("{0}", divisor);



        }
    }
}

    
