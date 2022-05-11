namespace Class_Ball
{
    class Ball
    {
        //Insatant variables/fields
        private int size;
        private int color;
        private int thrown;

        //constructor
        public Ball(int size, int color, int thrown)
        {
            this.size = size;
            this.color = color;
            this.thrown = thrown;
        }

        //method
        public int Pop()
        {
            size = 0;
            return size;
        }

        public int Thrown()
        {
            if (size == 0)
            {
                this.thrown += 1;
            }
            return thrown;
        }

        public int Times()
        {

        }



    }
}