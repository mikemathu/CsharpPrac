namespace BuildingClasses
{
    public class Color
    {
        //Instant variables
        private int red;
        private int green;
        private int blue;
        private int alpha;

        public Color(int red, int green, int blue, int alpha)
        {

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