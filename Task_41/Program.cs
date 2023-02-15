/*  Задача 41: Пользователь вводит с клавиатуры M чисел.
    Посчитайте, сколько чисел больше 0 ввёл пользователь.
    0, 7, 8, -2, -2 -> 2
    -1, -7, 567, 89, 223-> 3
 */

int[] InitArray(int M)
{
    int[] array = new int[M];
    return array;
}
    
int QuantPositiveNumbers(int[] array)
{
    int result = 0;
    for(int i = 0; i < array.Length; i++)
    {
        result += (array[i] > 0) ? 1 : 0;
    }

    return result;
}

Console.Clear();
Console.WriteLine("Задайте размерность массива:");
int m = int.Parse(Console.ReadLine()!);

int[] array = InitArray(m);

for(int i = 0; i < m; i++)
{
    Console.WriteLine($"Введите элемент №{i+1}");
    array[i] = int.Parse(Console.ReadLine()!);
}

Console.WriteLine($"Количество положительных чисел во введённом массиве: {QuantPositiveNumbers(array)}");