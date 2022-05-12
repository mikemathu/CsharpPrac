using OOP;

namespace CreatingClasses
{
    public class Program
    {
        static void Main(string[] args)
        {
            //New Instant of the object(1st constructor)
            //Book book = new Book("Fastlane", "MJ");

            //Console.WriteLine(book.GetTitle());
            //Console.WriteLine(book.GetAuthor());

            //2nd Constructor
            Book book = new Book("Think and Grow rich","Unknown", 200, 5000 );
            //Console.WriteLine(book.GetTitle());
            //Console.WriteLine(book.GetAuthor());

            book.SetTitle("How to get rich");
            Console.WriteLine(book.GetTitle());

        }
    }
}