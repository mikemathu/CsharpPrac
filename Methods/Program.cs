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

            //SEQUENTIAL CODE EXECUTION
            Console.WriteLine("I am about to go into a mwthod");

            DoSomethingAwesome();

            Console.WriteLine("I am back from the method");

        }

        static void DoSomethingAwesome()
        {
            Console.WriteLine("I am inside of a method! Awesome");

        }
    } 
}