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
            //int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
            //int currentMinimum = Int32.MaxValue;

            //for (int index=0; index<array.Length; index++)
            //{
            //if(array[index] < currentMinimum)
            // {
            //currentMinimum = array[index];
            //}
            // }
            // Console.WriteLine(currentMinimum);

            //TOTAL & AVERAGE VALUE IN AN ARRAY
            //int[] array = new int[8] { 4, 51, -7, -99, 15, -8, 45, 90 };
            //int total = 0;
            //for (int index = 0; index < array.Length; index++)
            //{
            //total
            //total  += array[index];
            //}
            //Average
            //float average = (float)total / array.Length;
            //Console.WriteLine(average);

            //ARRAYS OF ARRAYS AND MULTI-DIMENTIONAL ARRAYS
            //int[][] matrix = new int[4][];

            //matrix[0] = new int[4];
            //matrix[1] = new int[5];
            //matrix[2] = new int[2];
            //matrix[3] = new int[6];

            //for (int row = 0; row < matrix.Length; row++)
            //{
            //for (int column = 0; column < matrix[row].Length; column++)
            //Console.Write(matrix[row][column] + " "); // Each item in the row separated by spaces

            //Console.WriteLine(); // Rows separated by lines
            //}

            //Multi-dimentional array
            //int[,] matrix = new int[4, 4];

            //Fill in contents for multi-dimensional array
            //Note: GetLength gives back the size of the multi-dimensional array for a specific index.
            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{
            //for (int column = 0; column < matrix.GetLength(1); column++)
            //Console.Write(matrix[row, column] + " ");
            //Console.WriteLine();
            //}

            //FOREACH LOOP
            int[] scores = new int[] { 75, 44, 34, 25, 78, 89, 90, 69, 45, 36 };

            foreach(int score in scores)
            {
                Console.WriteLine("Someone had this score: "+score);
            }
        }
    }
}