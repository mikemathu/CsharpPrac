﻿namespace WhileLoop
{
    public class WhileLoop
    {
        static void Main(String[] args)
        {
            //int x = 1;

            //while (x <= 10)
            //{
            //Console.WriteLine(x);
            //x++;
            //}

            //LOOP FOR ENTERING NUMBER BTWN 0 AND 10

            //int playerNumber = -1;

            // while (playerNumber < 0 || playerNumber > 10)
            //{ 
            //Console.WriteLine("Enter Number btwn 0 and 10");
            //string numberInText = Console.ReadLine();
            //playerNumber = Convert.ToInt32(numberInText);
            //}

            //DO WHILE LOOP
            //int playerNumber;
            //do
            //{
            //Console.WriteLine("Enter number between 0 and 10");
            //string palyerResponce = Console.ReadLine();
            //playerNumber = Convert.ToInt32(palyerResponce);
            //}
            //while (playerNumber < 0 || playerNumber > 10);

            //FOR LOOP
            //for (int x = 1; x <= 10; x++ )
            //{
            //Console.WriteLine(x);
            //}

            //BREAKING OUT OF FOR LOOP
            //int numberThatCanCauseProblems = 54;

            //for (int x = 1; x < 100; x++ )
            //{
            //Console.WriteLine(x);

            //if (x == numberThatCanCauseProblems)
            //{
            //break;
            //}
            //}

            //FOR LOOP WORTH BREAKING
            //while (true)
            //{
            //Console.WriteLine("What is rhy bidding, my maste?");
            //string input = Console.ReadLine();

            //if (input == "quit" || input == "exit")
            //break;
            //}

            //CONTINUING TO THE NEXT ITERATION
            //for (int x = 1; x <= 10; x++)
            //{
            //if (x == 3)
            //continue;
            //break;

            //Console.WriteLine(x);
            //}




            //NESTING LOOPS

            //for (int index = 0; index < 2; index++)
            //{
                //for (int number = 0; number < 10; number++)
                //{
                    //Console.WriteLine(number);
                //}
                //Console.WriteLine();
            //}


            for (int index = 0; index < 3; index++)
            {
                for (int number = 0; number < index+1; number++)
                {
                    Console.WriteLine(number);
                }
                Console.WriteLine();
            }

            








        }

       
    }
}