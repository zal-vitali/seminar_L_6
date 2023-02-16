/* ### Задача со звездочкой. 
Напишите программу, которая
реализует обход введенного двумерного массива,
начиная с крайнего нижнего левого элемента против
часовой стрелки.
 1 2 3
 4 5 6 -> 7 8 9 6 3 2 1 4 5
 7 8 9
 */

int[,] GetArray()
{
    int[,] array = new int[,]
    {
    {1,2,3},
    {4,5,6},
    {7,8,9},
    };

    return array;

}

void PrintArray(int[,] array)
{
    int maxStr = array.GetLength(0);
    int maxCol = array.GetLength(1);

    for (int i = 0; i < maxStr; i++)
    {
        for (int j = 0; j < maxCol; j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[] TraverseArray(int[,] array)
{
    int maxStr = array.GetLength(0);
    int maxCol = array.GetLength(1);
    int qtElem = maxStr * maxCol;
    int[] result = new int[qtElem];
    
    if (qtElem == 0)
    {
        return result;
    }

    int minStringIndex = 0;
    int maxStringIndex = maxStr - 1;
    int minColumnIndex = 0;
    int maxColumnIndex = maxCol - 1;

    int direction = 0;
    int currentString = maxStr - 1;
    int currentColumn = -1;
    int i = 0;

    while (true)
    {
        //Идём вправо    
        if ((currentColumn < maxColumnIndex) && (direction == 0))
        {
            if ((currentColumn + 1) == maxColumnIndex)
            {
                maxStringIndex--;
                direction = 1;
            }

            currentColumn++;
            result[i] = array[currentString, currentColumn];
        }
        //Идём вверх
        else if ((currentString > minStringIndex) && (direction == 1))
        {
            if ((currentString - 1) == minStringIndex)
            {
                maxColumnIndex--;
                direction = 2;
            }

            currentString--;
            result[i] = array[currentString, currentColumn];
        }
        //Идем влево
        else if ((currentColumn > minColumnIndex) && (direction == 2))
        {
            if ((currentColumn - 1) == minColumnIndex)
            {
                minStringIndex++;
                direction = 3;
            }

            currentColumn--;
            result[i] = array[currentString, currentColumn];
        }
        //Идём вниз
        else if ((currentString < maxStringIndex) && (direction == 3))
        {
            if ((currentString + 1) == maxStringIndex)
            {
                minColumnIndex++;
                direction = 0;
            }

            currentString++;
            result[i] = array[currentString, currentColumn];
        }

        else
        {
            break;
        }

        i++;
    }

    return result;
}

Console.Clear();
int[,] array = GetArray();
int[] result = TraverseArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(string.Join(", ", result));

