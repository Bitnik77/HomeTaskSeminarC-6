// Задача №41. Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Write("Введите числа через запятую или пробел: ");
string numbers = Console.ReadLine()!;
numbers = numbers.Replace(",", " ");    //заменяем запятые на пробелы
//далее создаем массив из подстрок, разделенных пробелами и удаляем пустые (только с пробелами) подстроки
string[] Numbers = numbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

int NumbersArray(int[] intNumbers)
{
    int count = 0;
    for (int i = 0; i < Numbers.Length; i++)
    {
        intNumbers[i] = int.Parse(Numbers[i]);
        if (intNumbers[i] > 0) count++;
    }
    Console.WriteLine($"Пользователь ввел чисел больше нуля в количестве {count}");
    return count;
}
int[] intNumbers = new int[Numbers.Length];
NumbersArray(intNumbers);
