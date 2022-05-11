namespace SwitchStatement
{
    public class SwitchStatement
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EnterYour Score");
            string score = Console.ReadLine();
            int grade = Convert.ToInt32(score);

            switch (grade)
            {
                case >= 80:
                    //Console.WriteLine("Your grade is A");
                    break;
                case >= 60:
                    //Console.WriteLine("Your grade is B");
                    break;
                case >= 50:
                    //Console.WriteLine("Your grade is C");
                    break;
                default:
                   //Console.WriteLine("You failed");
                    break;
            }

            //CALCULATOR
            Console.WriteLine("Enter the first number");
            string firstNumner = Console.ReadLine();
            int firstNumber = Convert.ToInt32(firstNumner);

            Console.WriteLine("Enter Second Numner");
            string secondNumner = Console.ReadLine();
            int secondNumber = Convert.ToInt32(secondNumner);

            Console.WriteLine("Enter the computation sign");
            string computationalSign = Console.ReadLine();

            int answer = firstNumber + secondNumber;

            Console.WriteLine("Your number is {0}", answer);
        }
    }
}