namespace Methods
{
    public class Methods
    {
        //Calling a static method
        static void Main(string[] args)
        {
           CountToTen();
        }

        static void CountToTen()
        {
            for(int index = 1; index < 10; index++)
                Console.WriteLine(index);
        }


    }
}