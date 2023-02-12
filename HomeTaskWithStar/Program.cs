// Задача со звездочкой. Напишите программу, которая реализует обход введенного двумерного массива,
// начиная с крайнего нижнего левого элемента против часовой стрелки.

Console.Write("Введите количество строк массива: ");
int i = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int j = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[i, j];                                // объявляем массив

void PrintArray(int[,] matrix)                                // создаем массив
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matrix)                                 // инициализируем массив
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 20);
            Console.Write(matrix[i, j].ToString().PadLeft(4));
        }
        Console.WriteLine();
    }
}

int count = 0;
void PrintArray1(int[,] matrix)                                      // передаем массив в метод
{
    if (count == matrix.Length - 1)                                  // условие выхода из рекурсии
    {
        return;
    }
    for (j = count; j < matrix.GetLength(1) - count; j++)            // делаем проход вправо
    {
        i = matrix.GetLength(0) - 1 - count;
        Console.Write($"{matrix[i, j]} ");
    }
    for (i = i - 1; i >= count; i--)                                 // делаем проход вверх
    {
        j = matrix.GetLength(1) - 1 - count;
        Console.Write($"{matrix[i, j]} ");
    }
    for (j = j - 1; j >= count; j--)                                 // делаем проход влево
    {
        i = count;
        Console.Write($"{matrix[i, j]} ");
    }
    for (i = i + 1; i < matrix.GetLength(0) - 1 - count; i++)        // делаем проход вниз
    {
        j = count;
        Console.Write($"{matrix[i, j]} ");
    }
    count++;                                // с помощью счетчика отсекаем пройденные стороны
    PrintArray1(matrix);
}

PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
Console.WriteLine();
PrintArray1(matrix);