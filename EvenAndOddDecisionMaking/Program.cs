﻿namespace EvenAndOdd
{
    public class EvenAndOdd
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Enter Number");
                string numberAsText = Console.ReadLine();

                int number = Convert.ToInt32(numberAsText);

                //int modulus = number % 2;

                //if (modulus == 0)
                //{
                //Console.WriteLine("Even Number");
                //}
                //else
                //{
                //Console.WriteLine("Odd Number");
                //}

                //Improved way
                bool modulus = (number % 2 == 0);

                if (modulus)
                    Console.WriteLine("Even number");
                else
                    Console.WriteLine("Odd number");
            }

            


        }
    }
}