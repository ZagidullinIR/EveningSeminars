﻿
//Task 1.
//Задайте двумерный массив размером m × n, заполненный случайными целыми числами.
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
*/
//-----------------------------------
 
//Task 2.
//  Задайте двумерный массив размера m на n, каждый элемент 
//  в массиве находится по формуле: Aij = i+j. Выведите полученный 
//  массив на экран.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a rows of array: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a columns of array: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int [,] array =new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = i + j;
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

int[,] myArray = CreateRandom2dArray();
Print2dArray(myArray);
*/


//Task 3.
//  Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
//  и замените эти элементы на их квадраты.

/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a rows of array: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a columns of array: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int [,] array =new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = i + j;
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

int[,] myArray = CreateRandom2dArray();
Print2dArray(myArray);

for (int i = 0; i < array.GetLength(0); i++)
{    
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
void EvenToBe(int[,] array)
{
    for (int i = 2; i < array.GetLength(0); i += 2)
    {
        for (int j = 2; j < array.GetLength(1); j += 2 )
        {
            array[i,j] = array[i,j] * array[i,j];
        }
    }
}

int[,] myArray = CreateRandom2dArray();
Print2dArray(myArray);

Console.WriteLine();
EvenToBe(myArray);
Print2dArray(myArray);
*/

//-----------------------------------


//Task 4.
//  Задайте двумерный массив. Найдите сумму элементов, находящихся на главной 
//  диагонали с индексами (0,0); (1;1) и т.д.

/*
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
int SumOfMain(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
       {
        sum = sum + array[i, i];
        if (i == array.GetLength(0) - 1 && i < array.GetLength(1) - 1) Console.Write($"{array[i,i]} = ");
        else Console.Write($"{array[i,i]} + ");
       }
    return sum;

}

int[,] myArray = CreateRandom2dArray();
Print2dArray(myArray);

Console.WriteLine();
Console.WriteLine(SumOfMain(myArray));
*/

//-----------------------------------

// Task 5. Отсортировать по убываюнию строки массива.
 
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
void SortLine(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k =0; k < array.GetLength(1) - 1; k++)
            {
              if (array[i,k] < array[i,k + 1])
               {
                int temp = array[i,k];
                array[i,k] = array[i,k +1];
                array[i,k + 1] = temp;
               }
            }

        }
   } 
}

int[,] myArray = CreateRandom2dArray();
Print2dArray(myArray);

Console.WriteLine();
SortLine(myArray);
Print2dArray(myArray);
*/


Запись: int [] array = new int[size] создаст массив с именем array в котором будет size элементов и все они будут равны 0.z