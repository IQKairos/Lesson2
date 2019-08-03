using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson2
{
    static class Task2
    {      

        static void Main()
        {
            // Task 2.1
            int[] arr1 = { 1, 3, 5, 9 };
            int arrLength = arr1.Length;
            for (int i = 0; i < (arrLength / 2); i++)
            {
                object left = arr1[i];
                object right = arr1[arrLength - 1 - i];
                arr1.SetValue(left, arrLength - 1 - i);
                arr1.SetValue(right, i);
            }

            for (int i = 0; i < arrLength; i++)
            {
                int Elem = arr1[i];
            }

            //Task 2.2
            int[] arr2 = { 1, 3, 20, 4, 7, 20, 3, 6, 20 };
            int arr2Length = arr2.Length;
            int max = arr2[0];
            int first = 0;
            int second = 0;
            int distance = 0;
            for (int i = 0; i < arr2Length; i++)
            {
                if (max < arr2[i])
                {
                    max = arr2[i];
                    first = i;

                }
                if (max == arr2[i])
                {
                    second = i;
                }
                distance = second - first - 1;
            }

            //Task 3
            int[,] arr3 = {{2, 4, 3, 3},
                           {5, 7, 8, 5},
                           {2, 4, 3, 3},
                           {5, 7, 8, 5},
                           };
            int arr3Length = arr3.Length;
            int b = arr3.Rank;
            int elemLengt = arr3.GetLength(0);
            int rows = arr3.GetUpperBound(0) + 1;
            for (int i = 0; i < (Math.Sqrt(arr3Length)); i++)
            {
                for (int j = 0; j < elemLengt; j++)
                {
                    if (i > j)
                    {
                        arr3[i, j] = 0;
                    }
                    if (i < j)
                    {
                        arr3[i, j] = 1;
                    }
                }
            }
            int[,] b123 = arr3;
        }
    }
}

