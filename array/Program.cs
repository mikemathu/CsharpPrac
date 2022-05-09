namespace Arrays
{
    class Arrays
    {
        static void Main(string[] args)
        {
            // Array Decraration
            //int[] scores;

            //Array creation
            //int[] scores = new int[] { 2, 3, 6 };

            //int lengthInArray = scores.Length;

            // Console.WriteLine(scores[1]);

            //MINIMUM VALUE IN AN ARRAY
            int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
            int currentMinimum = Int32.MaxValue;

            for (int index=0; index<array.Length; index++)
            {
                if(array[index] < currentMinimum)
                {
                    currentMinimum = array[index];
                }
            }
            Console.WriteLine(currentMinimum);
        }
    }
}