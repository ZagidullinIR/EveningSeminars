//Task 1. Задайте двумерный массив. Напишите программу, которая
// меняет местами строки массива на выбор.

/*
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

void ChangeRows(int[,] array, int r1, int r2)
{
    if(r1 >= 0 && r1 < array.GetLength(0) &&
       r2 >= 0 && r2 < array.GetLength(0) &&
       r1 != r2)
    {
        for(int j = 0; j < array.GetLength(1); j++) // j - это столбец, а не строка
        {
            int temp = array[r1, j] //r1 - строка, j - столбец
            array[r1, j] = array[r2, j];
            array[r2, j] = temp;
        }
    }
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
Show2dArray(myArray); //вывели массив на экран

Console.WriteLine("Input a number of the first row to change: ");
int row1 = Convert.ToInt32(Console.ReadLine()) - 1; //Юзер будет видеть нормальную строку,
// а не наши данные. у нас с 0 начинается отчет, у Юзера с 1.
Console.WriteLine("Input a number of the second row to change: ");
int row2 = Convert.ToInt32(Console.ReadLine()) - 1;

ChangeRows(myArray, row1, row2);
Show2dArray(myArray);
*/

//Task 2.
//Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы.

/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WritLine(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] ChangeRowsToColoumns(int[,] array) //значение столбца встает в строку
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i + 1; j < array.GetLength(1); j++)
        {
            int temp = array[j, i];
            array[j, i] = array[j, i];
            array[j, i] = temp;
        }
    }
    return reverseArray;
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

ChangeRowsToColoumns(myArray);
Show2dArray(myArray);
*/

//Task 3.
//Из двумерного массива целых чисел удалить строку и столбец, 
//на пересечении которых расположен наименьший элемент.

/*

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}


void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,] DelteRowAndColoumnWithMinValue (int[,] array)
{
    int minI = 0;
    int minJ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < array[minI, minJ])
            {
                minI = i;
                minJ = j;
            } 
        }
    }

    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            if (i < minI && j < minJ) result[i, j] = array[i, j]; 
            if (i < minI && j >= minJ) result[i, j] = array[i, j + 1];
            if (i >= minI && j < minJ) result[i, j] = array[i + 1, j];
            if (i >= minI && j >= minJ) result[i, j] = array[i + 1, j + 1];
        }
    }
    return result;
}

Console.Write("Input a quantity of rows: "); 
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a quantity of columns: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(row, col, min, max);
Show2dArray(myArray);

int[,] newArray = DelteRowAndColoumnWithMinValue(myArray);
Show2dArray(newArray);
*/

//-----------E-N-D-----------------