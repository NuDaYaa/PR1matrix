using System;

class Program
{
    static void Main(string[] args)
    {
        // Запрос размерности матрицы
        Console.WriteLine("Введите количество строк (n): ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов (m): ");
        int m = Convert.ToInt32(Console.ReadLine());

        // Создание и заполнение матрицы
        double[,] matrix = new double[n, m];
        Random rand = new Random();

        Console.WriteLine("Сгенерированная матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = rand.NextDouble() * 20 - 10; // Случайные числа от -10 до 10
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // Поиск и вывод номеров столбцов с отрицательными элементами
        Console.WriteLine("Столбцы, содержащие только отрицательные элементы:");
        for (int j = 0; j < m; j++)
        {
            bool allNegative = true;

            for (int i = 0; i < n; i++)
            {
                if (matrix[i, j] >= 0)
                {
                    allNegative = false;
                    break;
                }
            }

            if (allNegative)
            {
                Console.Write((j + 1) + " "); // Вывод номера столбца (индексация с 1)
            }
        }
    }
}