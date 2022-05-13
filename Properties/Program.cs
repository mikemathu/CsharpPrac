using Properties;

namespace Properties
{
    public class Property
    {
        static void Main(string[] args)
        {
            Book book = new Book("how to get rich", "unknown");

            //Console.WriteLine(book.GetTitle());

            //book.SetTitle("New title");

            //Console.WriteLine(book.GetTitle());

            //Properties
            book.Title = "Old Book";//Set
            book.Author = "New Author";//set

            Console.WriteLine(book.Title);
            Console.WriteLine(book.Author);



            
        }
    }
}