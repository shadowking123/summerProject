using System;

namespace MatrixQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Made by ofek itzhaki and google.com
            int[,] oneArray = { {1,2,3},
                                {4,5,6},
                                {7,8,9}};

            Matrix one = new Matrix(oneArray, 5);

            void printDividedByLine()
            { 
                int sumOfLine = 0;
                int[,] array = one.getArr();
                int counter = 0;
                int[] devidedNumbers = new int[array.GetLength(0)];

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] += sumOfLine;
                    }

                    if (sumOfLine%one.getNum()==0)
                    {
                        devidedNumbers[counter] = i;
                        counter++;
                        //I could just print I but this way is better(:
                    }
                }
            }
            printDividedByLine();
        }
    }
}
