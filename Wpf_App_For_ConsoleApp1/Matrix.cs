using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_App_For_ConsoleApp1
{
    internal class Matrix
    {
        public static double[,] Multiply(double[,] x, double[,] y)
        {
            double[,] res = new double[x.GetLength(0),y.GetLength(1)];
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < y.GetLength(1); j++)
                {
                    res[i,j] = x[i,j] * y[j,i];
                }
            }
            return res;
        } 
    }
}
