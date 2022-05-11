namespace IfStatement
{
    public class IfStatement
    {
        static void Main(string[] args)
        {
            int score;

            Console.WriteLine("Enter Your Score!");
            string scoreAsText = Console.ReadLine();
            score = Convert.ToInt32(scoreAsText);

            if(score == 100)
            {
                Console.WriteLine("Perfect score! You win");
            }
            else if (score >= 80)
            {
                Console.WriteLine("You got an A");
            }
            else if(score >= 70)
            {
                Console.WriteLine("You got a B");
            }
            else if(score >= 60)
            {
                Console.WriteLine("You got a C");
            }
            else if(score >= 50)
            {
                Console.WriteLine("You got a D");
            }
            else
            {
                Console.WriteLine("You got an F");
            }

        }
    }
}