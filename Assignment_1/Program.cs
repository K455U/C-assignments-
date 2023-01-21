using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Here we define a random number generator object, which is
            //used to generate random numbers.
            Random random = new Random();

            int row1 = random.Next(2, 5);
            int col1 = random.Next(2, 5);
            int row2 = col1;
            int col2 = random.Next(2, 5);

            //Here we define a 4x2 matrix
            int[,] matrix1 = new int[row1, col1];
            //Here we define second matrix which is 4x2
            int[,] matrix2 = new int[row1, col1];
            //Adding matrices together
            int[,] matrixSum = new int[row1, col1];
            //Substracting matrices
            int[,] matrixSub = new int[row1, col1];
            //Matrix 3
            int[,] matrix3 = new int[row2, col2];
            //Multiplication
            int[,] matirxMulti =  new int[row1, col2];



            //In the following we firs initialize matrix number.
            //numbers.GetLength(0) returns the length of the first dimension
            //of the matrix, numbers.GetLength(0) returns the the length of
            //the second dimension, etc.
            for (int i = 0; i < matrix1.GetLength(0); i++)
                for (int j = 0; j < matrix1.GetLength(1); j++)
                    //Here we initialize the matrix location by a value
                    //between 0 and 10.
                    matrix1[i, j] = random.Next(11);


            Console.WriteLine("Content of matrix 1:");


            //Here we print the content of matrix1's numbers
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                    Console.Write("{0,5}", matrix1[i, j] + "\t");

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Content of matrix 2:");
           

            //matrix2's numbers
            for (int i = 0; i < matrix2.GetLength(0); i++)
                for (int j = 0; j < matrix2.GetLength(1); j++)
                    matrix2[i, j] = random.Next(11);

            //Here we print content of matrix2´s numbers
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                    Console.Write("{0,5}", matrix2[i, j] + "\t");

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Content of matrix 3:");

            //matrix3's numbers
            for (int i = 0; i < matrix3.GetLength(0); i++)
                for (int j = 0; j < matrix3.GetLength(1); j++)
                    matrix3[i, j] = random.Next(11);

            for (int i = 0; i < matrix3.GetLength(0); i++)
            {
                for (int j = 0; j < matrix3.GetLength(1); j++)
                    Console.Write("{0,5}", matrix3[i, j] + "\t");

                Console.WriteLine();
            }

            //Here we do the sum
            for (int i = 0; i < matrixSum.GetLength(0); i++)
                for (int j = 0; j < matrixSum.GetLength(1); j++)
                    matrixSum[i, j] = matrix1[i, j] + matrix2[i, j];

            //Here we do the substraction
            for (int i = 0; i < matrixSub.GetLength(0); i++)
                for (int j = 0; j < matrixSub.GetLength(1); j++)
                    matrixSub[i, j] = matrix1[i, j] - matrix2[i, j];

            //Here we do the multiplication
            for (int i = 0; i < matrix1.GetLength(0); i++)
                for (int j = 0; j < matrix3.GetLength(1); j++)
                    for (int k = 0; k < matrix1.GetLength(1); k++) 
                        matirxMulti[i, j] += matrix1[i, k] * matrix3[k, j];


            // Printing sum
            Console.WriteLine();
            Console.WriteLine("Adding two matrices together.");
            for (int i = 0; i < matrixSum.GetLength(0); i++)
            {
                for (int j = 0; j < matrixSum.GetLength(1); j++)
                    Console.Write("{0,5}", matrixSum[i, j] + "\t");

                Console.WriteLine();
            }

            // Printing substraction
            Console.WriteLine();
            Console.WriteLine("Substracting two matrices.");
            for (int i = 0; i < matrixSub.GetLength(0); i++)
            {
                for (int j = 0; j < matrixSub.GetLength(1); j++)
                    Console.Write("{0,5}", matrixSub[i, j] + "\t");

                Console.WriteLine();

            }

            // Printing multiplication
            Console.WriteLine();
            Console.WriteLine("Multiplies matrices");
            for (int i = 0; i < matirxMulti.GetLength(0); i++)
            {
                for (int j = 0; j < matirxMulti.GetLength(1); j++)
                    Console.Write("{0,5}", matirxMulti[i, j] + "\t");

                Console.WriteLine();

            }



        }
    }
}