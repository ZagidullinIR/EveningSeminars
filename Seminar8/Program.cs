//Task 1. Задайте двумерный массив. Напишите программу, которая
// поменяет местами первую и последнюю строку массива.
//Пересмотреть видео и обновить данные
/*
int[,] CreateRandom2dArray()
 {
    Console.Write("Input a rows of array: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a columns of array: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows,columns];
     for (int i = 0; i < rows; i++)
     {
        for(int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue +1);
        }
     }
    return array;

 }
 void Print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
--------------------------------------------------
void ChangeRows(int[,] array, int r1, int r2)
{
    if(r1 >= 0 && r1 < array.GetLength(0) &&
       r2 >= 0 && r2 < array.GetLength(0) &&
       r1 != r2)
    {
        for(int j =0; j < array.GetLength(1); j++)
        {
            int temp = array[r1, j]
            array[r1, j] = array[r2, j];
            array[r2, j] = temp;
        }
    }
}
-----------------------------------------------------
int[,] myArray = CreateRandom2dArray();
Print2dArray(myArray);
*/

//Task 2.
//Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы.

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for(int i =0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue +1);
        }
    }
    return array;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.WritLine(array[i,j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}


Console.Write("Input a quantity of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a quantity of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows, columns, min, max);
Show2dArray(myArray);
/*
int[,] ChangeRowsToColoumns (int[,] array) //значение столбца встает в строку
            {
                
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = i + 1; j < array.GetLength(1); j++)
                    {
                        int temp = array[i, j];
                        array[i, j] = array[j, i];
                        array[j, i] = temp;
                    }
          
                }
                return array;
            }

Console.Write("Enter a row quantity of an array: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a coloumn quantity of an array: ");
            int col = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the min possible value: ");
            int minValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the max possible value: ");
            int maxValue = Convert.ToInt32(Console.ReadLine());

            int[,] myArray = CreateRandom2dArr(row, col, minValue, maxValue);
            Show2dArray(myArray);

            ChangeRowsToColoumns(myArray);
            Show2dArray(myArray);
*/




//Task 3.
//Из двумерного массива целых чисел удалить строку и столбец, 
//на пересечении которых расположен наименьший элемент.

 int[,] ChangedArray(int[,] array)
 {
    int [,] result = new int[array.GetLength(0)-1, array.GetLength(1)-1 ];
    int min = array[0,0];
    int minI = 0;
    int minJ = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(min > array[i,j] )
            {
                minI = i;
                minJ = j;
            }

        }
    }
    for(int i = 0; i < result.GetLength(0); i++)
    {
        for(int j = 0; j < result.GetLength(1); j++)
        {
            if(i < minI && j < minJ)
            {
                result[i,j]= array[i,j];
            }
            if(i < minI && j > minJ)
            {
                result[i,j] = array[i,j+1];
            }
             if(i > minI && j < minJ)
            {
                result[i,j] = array[i+1,j];
            }
            if(i > minI && j > minJ)
            {
                result[i,j] = array[i+1,j+1];
            }

        }

    }
    return result;
 }   