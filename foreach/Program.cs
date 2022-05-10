namespace ForEach
{
    class ForEach
    {
        static void Main(string[] args)
        {
            //int[] arrays = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

            //int currentMinimum = Int32.MaxValue;

            //Minimum Value
            //foreach (int array in arrays )
            //{
            //if (array < currentMinimum)
            //{
            //currentMinimum = array;
            //}
            //}

            //Console.WriteLine(currentMinimum);

            //AVERAGE
            int[] arrays = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

            int total = 0;

            foreach (int array in arrays)
            {
                total += array;
            }

            float average = (float)total / arrays.Length;

            Console.WriteLine(average);
        }
    }
}