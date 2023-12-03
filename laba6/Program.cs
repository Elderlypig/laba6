using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Чтение данных из файла Inlet.in
        string[] inputLines = File.ReadAllLines("Inlet.in");
        string[] sizes = inputLines[0].Split(' ');
        int N = int.Parse(sizes[0]);
        int M = int.Parse(sizes[1]);
        int[,] A = new int[N, M];

        for (int i = 0; i < N; i++)
        {
            string[] values = inputLines[i + 1].Split(' ');
            for (int j = 0; j < M; j++)
            {
                A[i, j] = int.Parse(values[j]);
            }
        }

        // Нахождение номера столбца с минимальным элементом
        int minColumn = 0;
        int minElement = A[0, 0];

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
             
               if (A[i, j] < minElement)
               {
                  minElement = A[i, j];
                  minColumn = j;
               }
                
            }
        }

        // Запись результата в файл Outlet.out
        File.WriteAllText("Outlet.out", (minColumn + 1).ToString());

        // Уведомление о записи результата в файл
        Console.WriteLine("Результат успешно записан в файл Outlet.out.");
    }
}
