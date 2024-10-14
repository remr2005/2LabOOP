﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_App_For_ConsoleApp1
{
    class Matrix
    {
        /// <summary>
        /// Функция для перемножения матриц
        /// </summary>
        /// <param name="x">Первая матрица</param>
        /// <param name="y">Вторая матрица</param>
        /// <returns>Результат</returns>
        /// <exception cref="ArgumentException"></exception>
        public static double[,] Multiply(double[,] x, double[,] y)
        {
            // Проверяем, что количество столбцов первой матрицы равно количеству строк второй
            if (x.GetLength(1) != y.GetLength(0))
            {
                throw new ArgumentException("Matrices cannot be multiplied: invalid dimensions.");
            }

            // Инициализация результатирующей матрицы с размерами (строки x) x (столбцы y)
            double[,] res = new double[x.GetLength(0), y.GetLength(1)];

            // Умножаем матрицы
            for (int i = 0; i < x.GetLength(0); i++) // строки матрицы x
            {
                for (int j = 0; j < y.GetLength(1); j++) // столбцы матрицы y
                {
                    for (int k = 0; k < x.GetLength(1); k++) // столбцы матрицы x и строки матрицы y
                    {
                        res[i, j] += x[i, k] * y[k, j]; // Правильное вычисление произведения
                    }
                }
            }

            return res;
        }
    }
}
