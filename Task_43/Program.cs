/* Задача 43. Напишите программу, которая найдёт точку
пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, 
y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, 
k1 = 5, 
b2 = 4, 
k2 = 9 -> (-0,5; -0,5) 
*/

double[] InitArray(int M)
{
    double[] array = new double[M];
    return array;
}

double[] GetPointInt(double[] pointsArray)
{
    // принимаем массив натуральных чисел b1(0), k1(1), b2(2), k2(3)
    // возвращаем массив натуральных чисел х(0), y(1), флаг результата(2)

    double x = 0;
    double y = 0;

    double[] array = InitArray(3);

    if(pointsArray[1] == pointsArray[3])
    {
         if(pointsArray[0] == pointsArray[2])
        {
            // линии совпадают, бесконечное множество решенй
            array[2] = 1;
        }
        else
        {
            // параллельные линии, решений нет 
            array[2] = 2;
        } 
    }
    else
    {
        // 
        x = Math.Round((pointsArray[2] - pointsArray[0]) / (pointsArray[1] - pointsArray[3]),3);
        y = Math.Round(pointsArray[1] * x + pointsArray[0],3);
    }

    array[0] = x;
    array[1] = y;

    return array;
}

Console.Clear();

double[] array = InitArray(4);

Console.WriteLine("Найдем точку пересечения двух прямых, описываемых формулами y = k1*x + b1 и y = k2*x + b2");
Console.WriteLine("Введите b1");
array[0] = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k1");
array[1] = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите b2");
array[2] = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k2");
array[3] = double.Parse(Console.ReadLine()!);

double[] result = GetPointInt(array);

if(result[2] == 1)
{
    Console.WriteLine("Линии совпадают, бесконечное множество решенй");
}
else if(result[2] == 2)
{
    Console.WriteLine("Параллельные линии, решений нет");
}
else
{
    Console.WriteLine($"x = {result[0]}, y = {result[1]}");
}