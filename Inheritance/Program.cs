using Inheritance;

namespace Inheritance
{
    //Base Class
    class Polygon
    {
        static void Main(string[] args)
        {
            //Polygon polygon = new Polygon();
            Square square = new Square(3.3f);

            //polygon.Size = 3.3f;
            //square.Size = 3.3f;

            Console.WriteLine(square.Size);
        }        
    }
}