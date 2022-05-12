namespace SwitchStatementCalcultor
{
    public class SwitchStatementCalculator
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Enter first number");
                string firstNumberInString = Console.ReadLine();
                int firstNumber = Convert.ToInt32(firstNumberInString);

                Console.WriteLine("Enter operation sign");
                string operationSign = Console.ReadLine();

                Console.WriteLine("Enter second number");
                string secondNumberInString = Console.ReadLine();
                int secondNumber = Convert.ToInt32(secondNumberInString);

                switch (operationSign)
                {
                    case "+":
                        int sum = firstNumber + secondNumber;
                        Console.WriteLine(sum);
                        break;
                    case "-":
                        int difference = firstNumber - secondNumber;
                        Console.WriteLine(difference);
                        break;
                    case "*":
                        int product = firstNumber * secondNumber;
                        Console.WriteLine(product);
                        break;
                    case "/":
                        float quotient = (float)firstNumber / secondNumber;
                        Console.WriteLine(firstNumber + operationSign + secondNumber +" = "+ quotient);
                        break;
                    case "%":
                        int remaider = firstNumber % secondNumber;
                        Console.WriteLine(remaider);
                        break;
                    case "^":
                        double power = Math.Pow(firstNumber, secondNumber);
                        Console.WriteLine(power);
                        break;
                }
            }
           


        }
    }
}