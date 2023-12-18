using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec18Console
{
    internal class Program
    {
        public static void JaggedarrayFun()
        {
            int[][] arr = new int[3][];// Declare the array  

            arr[0] = new int[] { 11, 21, 56};// Initialize the array          
            arr[1] = new int[] { 42, 61, 41, 59, 63 };
            arr[2] = new int[] { 1, 2, 3 };

            // array elements  
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            //JaggedarrayFun();
            // SystemArray.ArraylistFun();
            //SystemArray.HastableFun();
            //SystemArray.SortFun();
            //SystemArray.StackQueue();
            SystemArray.BothIterator();
            Console.Read();
        }
    }
}
