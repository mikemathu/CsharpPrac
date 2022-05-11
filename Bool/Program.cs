namespace Bool
{
    public class Bool
    {
        static void Main(string[] args)
        {
            int score = 100;

            int pointsNeededToPass = 100;

            //The initial way
            //bool levelComplete;


            //if (score >= pointsNeededToPass)            
            //levelComplete = true;            
            //else            
            //levelComplete = false;            

            // Console.WriteLine(levelComplete);

            //Improved way
            bool levelComplete = (score >= pointsNeededToPass);

            if (levelComplete)
                Console.WriteLine("You have beten the level");
            else
                Console.WriteLine("Try next time");

        }
    }
}