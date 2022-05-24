using static System.Console;
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



            WriteLine(ball.ThrowCount());
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

        //public int GetRed()
        //{
            //return red;
        //}

        public int Red { get; set; }
        //public int GetGreen()
        //{
           // return green;
       // }

        public int Green
        {
            get { return green; }
            set { green = value; }
        }

        //public int GetBlue()
        //{
           // return blue;
       // }

        public int Blue { get; set; } = 35;

        public int GetAlpha()
        {
            return alpha;
        }

        public int Alpha { get; }

        public Color(int alpha)
        {
            Alpha = alpha;
        }

        public int GetAverage()
        {
            return (red + green + blue) / 3;
        }
    }
}