// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// Решив систему уравнений, получаем x = (b1 - b2) / (k2 - k1), y = (k2*b1 - k2*b2) / (k2 - k1) + b2
Console.Clear();
Console.Write("Введите значение b1 для уравнения прямой (y = k1 * x + b1): ");
int b1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение k1 для уравнения прямой (y = k1 * x + b1): ");
int k1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение b2 для уравнения прямой (y = k2 * x + b2): ");
int b2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение k2 для уравнения прямой (y = k2 * x + b2): ");
int k2 = int.Parse(Console.ReadLine()!);

if (k1 == k2 && b1 == b2) Console.WriteLine("Прямые совпадают"); // Проверка прямых на совпадение
else if (k1 == k2) Console.WriteLine("Прямые параллельны, точки пересечения нет");// Проверка прямых на параллельность
else
{
    int x = (b1 - b2) / (k2 - k1);
    int y = (k2 * b1 - k2 * b2) / (k2 - k1) + b2;
    Console.WriteLine($"Точка пересечения прямых будет с координатами ({x}, {y})");
}