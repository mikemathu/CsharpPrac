namespace FuzzBuzzChallenge
{
    public class FuzzBuzz
    {
        static void Main(string[] args)
        {
            for (int number = 1; number <= 100; number++ )
            {
                if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    continue;
                }

                if (number%3 == 0)
                {
                    Console.WriteLine("Fizz");
                    continue;
                }

                if (number % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    continue;
                }

                

                Console.WriteLine(number);
            }
        }
    }
}