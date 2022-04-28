using System;
using System.Collections.Generic;
using System.Linq;

namespace C_Sharp_Lesson_3_Homework
{
    public class Homework
    {
        public void GetCentralElementFromMatrix(int[,] matrixOfIntegers)
        {
            /*print to console the central element from matrixOfIntegers, if not exist print: "This matrix doesn't have a central element"
             * |   input           | result             |
             * |-------------------|--------------------|
             * | {                 |                    |
             * |  { 1,   3,  5},   |    The central     |
             * |  {-1, 100, 11},   |  element is 100    |
             * |  { 2,  15, 44}    |                    |
             * |  }                |                    |
             * |----------------------------------------|
             * |{                  |                    |
             * | { 1,  6, 21,  8 },| This matrix doesn't|
             * | { 5, -4,  5,  7 },| have a central     |
             * | {77,  5,  0, 74 } |  element           |
             * | }                 |                    |
             * ------------------------------------------
             *    1. Check if rows= columns  and rowLength % 2 != 0
             */
            double[,] arrayOfDouble = new double[3, 3]
            {
               { 1,3,5 },
               {-1,100,11 },
               { 2,15,44 }
                };
            for (int i = 0; i < arrayOfDouble.GetLength(0); i++)
            {
                for (int j = 0; j < arrayOfDouble.GetLength(1); j++)
                {

                    if (i == j);
                    {
                        Console.Write(matrixOfIntegers[i, j] + ", ");
                    }

                }
                if (arrayOfDouble.Length % 2 != 0)
                {
                    Console.WriteLine("100");
                }

                else
                    Console.WriteLine("This matrix doesn't have a central element");
            }



        }
        public void GetSummOfDiagonalsElements(int[,] matrixOfIntegers)
        {
        /*print to console the central element from matrixOfIntegers, if not exist print: "This matrix doesn't have a central element"
 * |   input           | result              |
 * |-------------------|---------------------|
 * | {                 |                     |
 * |  { 1,   3,  5},   | First diagonal: 145 |
 * |  {-1, 100, 11},   | Second diagonal: 107|
 * |  { 2,  15, 44}    |                     |
 * |  }                |                     |
 * |-----------------------------------------|
 * |{                  |                     |
 * | { 1,  6, 21,  8 },| This matrix doesn't |
 * | { 5, -4,  5,  7 },| have a diagonals    |
 * | {77,  5,  0, 74 } |                     |
 * | }                 |                     |
 * ------------------------------------------
 *    
 */
        Console.Write("Principal Diagonal: ");

        for (int i = 0; i < matrixOfIntegers.GetLength(0); i++)
        {
            for (int j = 0; j < matrixOfIntegers.GetLength(1); j++)
            {

                // Condition for principal diagonal
                if (i == j)
                {
                    Console.Write(matrixOfIntegers[i, j] + ", ");
                }
            }
        }
        Console.WriteLine("");

        Console.Write("Secondary Diagonal: ");

        for (int i = 0; i < matrixOfIntegers.GetLength(0); i++)
        {
            for (int j = 0; j < matrixOfIntegers.GetLength(1); j++)
            {

                // Condition for secondary diagonal
                if ((i + j) == (n- 1))
                {
                    Console.Write(matrixOfIntegers[i, j] + ", ");
                }
            }
        }
        Console.WriteLine("");
    }


    /* {
         int i, j, sum = 0, n, m = 0;
         int[,] arr1 = new int[50, 50];


         Console.Write("\n\nFind the sum of left diagonals of a matrix :\n");
         Console.Write("--------------------------------------------\n");

         Console.Write("Input the size of the square matrix : ");
         n = Convert.ToInt32(Console.ReadLine());
         m = n;
         Console.Write("Input elements in the matrix :\n");
         for (i = 0; i < n; i++)
         {
             for (j = 0; j < n; j++)
             {
                 Console.Write("element - [{0}],[{1}] : ", i, j);
                 arr1[i, j] = Convert.ToInt32(Console.ReadLine());
             }
         }
         Console.Write("The matrix is :\n");
         for (i = 0; i < n; i++)
         {
             for (j = 0; j < n; j++)
                 Console.Write("{0}  ", arr1[i, j]);
             Console.Write("\n");
         }
         // calculate the sum of left diagonals
         for (i = 0; i < n; i++)
         {
             m = m - 1;
             for (j = 0; j < n; j++)
             {
                 if (j == m)
                 {
                     sum = sum + arr1[i, j];
                 }

             }
         }
         Console.Write("Addition of the  left Diagonal elements is :{0}\n", sum);
     }*/
 

    public void StarPrinter(int triangleHight)
    {
        /* Write a programm that will print a triagle of stars  with hight = triangleHight
         *  Example: triangleHight = 3;
         *  Result:   *
         *           * *
         *          * * * 
         */
        int number;
        int i, j, k;
        if (int.TryParse(Console.ReadLine(), out number))
        {
            for (i = 0; i < number; i++)
            {
                int numberOfSpaces = i;
                int numberOfStars = (number * 2 - 1) - (2 * numberOfSpaces);

                for (j = 1; j <= numberOfSpaces; j++)
                {
                    Console.Write(" ");
                }

                for (k = 1; k <= numberOfStars; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
            }
        }
        else
        {
            Console.WriteLine("No number entered.");
        }

        Console.Read();
    }
    public void SortList(IList<int> listOfNumbers)
    {
        //Print to console elements of  listOfNumbers in ascending order
        {
            // Creating and initializing list of integers
            List<int> nums = new List<int>() { -5, 8, -7, 0, 44, 121, -7 };

            // Using order by method we sort the list
            var result_set = nums.OrderBy(num => num);

            // Display the list
            Console.WriteLine("Sorted in Ascending order:");
            foreach (int value in result_set)
            {
                Console.Write(value + " ");
            }
        }

    }

    public void Main(String[] args)
    {
        GFG gfg = new GFG();
        Homework homework = new Homework();
        IList<int> list = new List<int>() { -5, 8, -7, 0, 44, 121, -7 };
        int[,] matrix = new int[3, 3] {
                { 1,   3,  5},
                { 2, 3, 5},
                {100, 56 , -54} };
        int[,] matrix2 = new int[3, 4] {
                { 1,   3,  5,   6},
                { 2,   3,  5,  78},
                {100, 56 , -54, 6} };

        //homework.GetCentralElementFromMatrix(matrix)
        //homework.GetCentralElementFromMatrix(matrix2);
        //  homework.GetSummOfDiagonalsElements(matrix);//
        //------------------
        //homework.GetSummOfDiagonalsElements(matrix2);//
        //----------------------
        //homework.StarPrinter(5);//
        //  homework.SortList(list);//
    }
}
}
    
