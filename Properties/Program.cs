using Properties;

namespace Properties
{
    public class Property
    {
        static void Main(string[] args)
        {
            Book book = new Book("how to get rich", "unknown");

            //Console.WriteLine(book.GetTitle());

            book.SetTitle("New title");

            Console.WriteLine(book.GetTitle());



            
        }
    }
}