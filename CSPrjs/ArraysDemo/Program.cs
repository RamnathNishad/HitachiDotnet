using System.Collections;

namespace ArraysDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SingleDimensionArray();
            //RectangularArray();
            //JaggedArray();
            //ForEachDemo();
        }
        static void SingleDimensionArray()
        {
            //data-type[] array-name=new data-type[size]  0 to n-1
            //int[] numbers = new int[5];
            //numbers[0] = 10; numbers[1] = 20;
            //numbers[2] = 30; numbers[3] = 40;
            //numbers[4] = 50;

            int[] numbers = { 10, 20, 30, 40, 50 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

        }
        static void RectangularArray()
        {
            //int[,] numbers = new int[2, 3];
            //numbers[0, 0] = 10; numbers[0, 1] = 20;
            //numbers[1, 0] = 30; numbers[1, 1] = 40;

            int[,] numbers = {
                                { 10,20,30,1 },
                                { 40,50,60,2 } ,
                                { 70,80,90,3 }
                             };

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write(numbers[i, j] + "\t");
                }
                Console.WriteLine("");
            }
        }

        static void JaggedArray()
        {
            int[][] numbers = new int[3][];
            numbers[0] = new int[] { 10, 20, 30 };
            numbers[1] = new int[] { 10, 20 };
            numbers[2] = new int[] { 10, 20, 30, 40 };

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers[i].Length; j++)
                {
                    Console.Write(numbers[i][j] + "\t");
                }
                Console.WriteLine("");
            }
        }

        static void ForEachDemo()
        {
            string[] cities = { "Bangalore", "Mysore", "Delhi" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //    //cities.Append("Jaipur");
            //}

            IEnumerator ie = cities.GetEnumerator();

            while (ie.MoveNext())
            {
                Console.WriteLine(ie.Current);
            }
        
        }
    }
    //foreach is used for read-only access, so we cannot modify 
    //the enumeration of the arrays i.e. we cannot add or remove
    //items from the array
}
