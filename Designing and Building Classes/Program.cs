using Designing_and_Building_Classes;

namespace BuildingClasses
{
    public class Color
    {
        static void Main(string[] args)
        {
            Color color = new Color(3, 5 ,4 ,5);          
            //Console.WriteLine(color.GetAverage());

            Ball ball = new Ball ();
            //ball.Pop();
            ball.Throw();



            Console.WriteLine(ball.ThrowCount());
        }
        //Instant variables
        private int red;
        private int green;
        private int blue;
        private int alpha;

        public Color(int red, int green, int blue, int alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        public Color(int red, int green, int blue)
        {
            this.alpha = 255;
        }

        public int GetRed()
        {
            return red;
        }
        public int GetGreen()
        {
            return green;
        }

        public int GetBlue()
        {
            return blue;
        }

        public int GetAlpha()
        {
            return alpha;
        }

        public int GetAverage()
        {
            return (red + green + blue) / 3;
        }
    }
}