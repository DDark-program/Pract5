using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract5
{
    class MainTask
    {
        public void TaskMatr(int sumIn, int countIn,int rowsCount,int columnsCount,out int sumOut, out int countOut)
        {
            sumOut = 0;
            countOut = 0;
            int sum = 0;
            int count = 0;
            Random random = new Random();
            int rand;
            int[,] matr = new int[rowsCount, columnsCount];
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    rand = random.Next(-100, 100);
                    matr[i, j] = rand;
                    sum += (int)matr.GetValue(i, j) + (int)matr.GetValue(i, j++);
                    count += matr.GetLength(1);
                    if (sum == sumIn)
                    {
                        sumOut = matr.GetLength(0);
                    }
                    if (count == countIn)
                    {
                        countOut = matr.GetLength(0);
                    }
                }
            }
        }
    }
}
