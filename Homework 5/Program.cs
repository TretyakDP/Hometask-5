using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите размер матрицы (n): ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            int[,] matrix = new int[n, n];

            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Введите элемент [{i},{j}]: ");
                    if (int.TryParse(Console.ReadLine(), out int element))
                    {
                        matrix[i, j] = element;
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод. Попробуйте снова.");
                        j--;
                    }
                }
            }

            int diagonalSum = 0;
            int belowDiagonalSum = 0;

            for (int i = 0; i < n; i++)
            {
                diagonalSum += matrix[i, i];
                for (int j = i + 1; j < n; j++)
                {
                    belowDiagonalSum += matrix[i, j];
                }
            }

            Console.WriteLine($"Сумма элементов побочной диагонали: {diagonalSum}");
            Console.WriteLine($"Сумма элементов под побочной диагональю: {belowDiagonalSum}");
        }
        else
        {
            Console.WriteLine("Некорректный размер матрицы. Введите положительное число.");
        }
    }
}