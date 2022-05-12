namespace Methods
{
    public class Methods
    {
        //Calling a static method
        static void Main(string[] args)
        {
            // CountToTen();
            //}

            //static void CountToTen()
            //{
            //for(int index = 1; index < 10; index++)
            //Console.WriteLine(index);
            //}

            //RETURNING STAFF FROM A METHOD
            int userNumber = GetNumberFromUser();

            Console.WriteLine(userNumber);


        }

        static int GetNumberFromUser()
        {
            int userNumber = 0;

            while (userNumber < 1 || userNumber > 10)
            {
                Console.WriteLine("Enter a number between 1 and 10");
                string userResponse = Console.ReadLine();
                userNumber = Convert.ToInt32(userResponse);
            }
            return userNumber;
        }
    }
}