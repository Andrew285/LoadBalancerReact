using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoadBalancerReact
{
    public class Matrix
    {
        public int rowsAmount;
        public int columnsAmount;
        public int[,] array;

        public Matrix(string rows, string cols)
        {
            rowsAmount = Int32.Parse(rows);
            columnsAmount = Int32.Parse(cols);

            Random random = new Random();
            array = new int[rowsAmount, columnsAmount];
            for(int i = 0; i < rowsAmount; i++)
            {
                for(int j = 0; j < columnsAmount; j++)
                {
                    array[i, j] = random.Next(1, 101);
                }
            }
        }
    }
}
