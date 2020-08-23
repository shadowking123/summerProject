using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixQuestion
{
    class Matrix
    {
        int[,] arr;
        int num;

        public Matrix(int[,]Arr, int number)
        {
            arr = Arr;
            num = number;
        }

        //get
        public int[,] getArr()
        {
            return arr;
        }

        public int getNum()
        {
            return num;
        }

        //set

        public void setArr(int[,] Arr)
        {
            arr = Arr;
        }

        public void setnum(int Num)
        {
            num = Num;
        }

        //isSame
        public int IsSame(Matrix other)
        {
            int sumOther = 0;
            int sumCurrent = 0;

            int[,] currentArr = this.getArr();
            int[,] otherArr = other.getArr();

            for (int i = 0; i < currentArr.GetLength(0); i++)
            {
                for (int j = 0; j < currentArr.GetLength(1); j++)
                {
                    currentArr[i, j] += sumCurrent;
                }
            }

            for (int i = 0; i < otherArr.GetLength(0); i++)
            {
                for (int j = 0; j < otherArr.GetLength(1); j++)
                {
                    otherArr[i, j] += sumOther;
                }
            }

            if (sumOther > sumCurrent)
            {
                return 1;
            }

            else if (sumCurrent == sumOther)
            {
                return 0;
            }

            return 2;
        }
    }
}
