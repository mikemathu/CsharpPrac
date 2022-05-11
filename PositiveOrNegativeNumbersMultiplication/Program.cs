namespace PositiveOrNegativeNumbersMultiplication
{
    public class PositiveOrNegativeNumbersMultiplication
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
            string FirstNumberAsText = Console.ReadLine();
            int firstNumber = Convert.ToInt32(FirstNumberAsText);

            //bool one = (firstNumber > 0);

            Console.WriteLine("Enter Second Number");
            string SecondNumberAsText = Console.ReadLine();
            int secondNumber = Convert.ToInt32(SecondNumberAsText);

            //bool two = (secondNumber > 0);

            if (firstNumber > 0 && secondNumber > 0 || firstNumber < 0 && secondNumber < 0)
            {
                Console.WriteLine("The result will be positive");
                
            }
            else 
            {
                Console.WriteLine("The result will be negative");
            }
            int product = firstNumber * secondNumber;
            Console.WriteLine(product);




            //int product = firstNumber * secondNumber;
        }
    }
}