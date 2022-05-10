namespace CopyingAnArray
{
    class CopyingAnArray
    {

        static void Main(string[] args)
        {

            int[] arrayFirst = new int[10] { 3, 4, 5, 6, 2, 5, 7, 2, 8, 2 };

            int[] arraySecond = new int[arrayFirst.Length];

            for (int index = 0; index < arrayFirst.Length; index++)
            {
                arraySecond[index] = arrayFirst[index];

                Console.WriteLine("First Array" +arrayFirst[index]);
                Console.WriteLine("Copied arry"+ arraySecond[index]);

            }
           

            //Console.WriteLine("Array value is " + arraySecond[9]);


        }
            


            
    }       
}