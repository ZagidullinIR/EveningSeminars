﻿
//Задача №2
//    Напишите программу, которая на вход принимает два числа и выдаёт,какое число большее, а какое меньшее
/*
Console.Write("Input a furst number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a second number: ");
int b = Convert.ToInt32(Console.ReadLine());

 if (a > b)
    Console.WriteLine("{0} наибольшее", a);
else
    Console.WriteLine("{0} наибольшее", b);
*/

//Задача №4
//    Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
/*
Console.Write("Input a furst number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a second number: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a third number: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b)
 {
    if (a > c)
    {
       Console.WriteLine("{0} наибольшее", a);
    }
    else
    {
        Console.WriteLine("{0} наибольшее", c);
    }
 }
 else if (b > c)
    Console.WriteLine("{0} наибольшее", b);
 else
     Console.Write("{0} наибольшее", c);
*/

//Задача №6
//    Напишите программу, которая на вход принимает число и выдает,является ли число чётным(делиться ли оно на два без остатка).
/*
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0) Console.WriteLine("Да!");
else System.Console.WriteLine("Нет!");
 */

//Задача №8
//   Напишите программу, которая на вход принимает число(N), а на выходе показывает все все числа от 1 до N.
/*
 Console.Write("Введите число: ");
 int num = Convert.ToInt32(Console.ReadLine());

 int count =1;

 while(count <= num)
    {
    if(count % 2 == 0)
    Console.Write(count + " ");
    count ++;
    }
*/


//===============================================================================



//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int WriteWait(string outLine)
{
    Console.Write(outLine);
    int inNumber = Convert.ToInt32(Console.ReadLine());
    return inNumber;
}
   Repeat:
int number = WriteWait("Пожалуйста, введите трёхзначное число: ");

    if (number < 100 || number >= 1000)
     {
      Console.WriteLine("Вы ошиблись!");
      goto Repeat;
     }

Console.WriteLine($"В введённом числе {number} вторая цифра: {number / 10 % 10}");

*/

//----------------------------------

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа ( или -1, если третьей цифры нет).
/*
int WriteWait(string outLine)
{
    Console.Write(outLine);
    int inNumber = Convert.ToInt32(Console.ReadLine());
    return inNumber;
}
bool CheсkDigNum(int inNum)
{
    if (inNum < 100)
    {
        Console.WriteLine($"В этом числе {inNum} третья цифра отсутствует.");
        return false;
    }
    return true;
}
int ThirdDigit(int inNum)
{
    while (inNum >= 1000)
    {
        inNum /= 10;
    }
    return inNum % 10;
}

int number = WriteWait("Пожалуйста, введите число: ");

if (CheсkDigNum(number))
{
    Console.WriteLine($"В числе {number} третья цифра {ThirdDigit(number)}.");
}
*/

//----------------------------------

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
int WriteWait(string outLine)
{
    Console.Write(outLine);
    int inNumber = Convert.ToInt32(Console.ReadLine());
    return inNumber;
}

bool Weekend(int digit)
{
    if (digit < 6)
    {
        return false;
    }
    return true;
}
Repeat:
int day = WriteWait("Введите день недели от 1 до 7: ");

   if (day < 1 || day > 7)
      {
       Console.WriteLine("Будьте внимательнее.");
       goto Repeat;
      }
   if (Weekend(day))
     {
      Console.WriteLine("Сегодня выходной. Можно дальше спать.");
     }
else
   {
       Console.WriteLine("Обычный рабочий день.");
   }

*/

//------------------------------------
//Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*
Console.WriteLine("Введите число: ");        //Запрос числа
string number = Console.ReadLine();          // Строка ввода числа
int len = number.Length;

if (len == 5)
{      
    if (number[0] == number[4] && number[1] == number[3])       //Сравнивает 1-е и 5-е, 2-е и 4-е число.
    {
        Console.WriteLine($"{number} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{number} - НЕ палиндром");
    }
}
else
{
    Console.WriteLine($"ОШИБКА: {number} - введите пятизначное число");
}

*/

//Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
int x1 = ReadInt("Введите координату X первой точки: ");
int y1 = ReadInt("Введите координату Y первой точки: ");
int z1 = ReadInt("Введите координату Z первой точки: ");
int x2 = ReadInt("Введите координату X второй точки: ");
int y2 = ReadInt("Введите координату Y второй точки: ");
int z2 = ReadInt("Введите координату Z второй точки: ");

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Длинна отрезка {length}");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/


//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*
int number = ReadInt("Введите число N: ");

for (int i = 1; i <= number; i++)
{ 
    Console.Write($"{i*i*i} ");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/




// //  Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

/*
int numA = ReadInt("Введите первое число: ");
int numB = ReadInt("Введите второе число: ");
ToDegree(numA, numB);


// Функция возведения в степень
void ToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(a + " в степени " + b + " = " + result);
}


int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

*/
// //  Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// //452 -> 11
// //82 -> 10
// //9012 -> 12
/*
int number = ReadInt("Введите число: ");

int len = NumberLen(number);
SumNumbers(number, len);

int NumberLen(int a)
  {
    int index = 0;
    while (a > 0)
    {
        a /= 10;index++;
    }
    return index;
  }
  
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
void SumNumbers(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine($"сумма цифр {sum}");
}

*/

// //  Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

/*
int[] CreateArr(int m, int minValue, int maxValue)
{
    int[] arr = new int[m]; //Выделяем ячейку памяти int[]

    for(int i = 0; i < m; i++)
        arr[i] = new Random().Next(minValue, maxValue +1);
    return arr;
}
void WriteArr(int[] arr)
{
    Console.Write(arr[0]);
    for (int i = 1; i < arr.Length; i++)
    {
        Console.Write($", {arr[i]}");
    }
    Console.Write($" - > [{arr[0]}");
    for (int i = 1; i < arr.Length; i++)
    {
        Console.Write($", {arr[i]}");
    }
    Console.Write("]");
    Console.WriteLine();
}
Console.Write("Your m: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Your value min: ");
int valMin = Convert.ToInt32(Console.ReadLine());
Console.Write("Your value max: ");
int valMax = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArr(n, valMin, valMax);
WriteArr(myArray);

*/



//Task 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

/*
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] num = new int[size];
FillArrayRandomNumbers(num);
Console.WriteLine("Вот наш массив: ");
PrintArray(num);
int count = 0;

for (int z = 0; z < num.Length; z++)
if (num[z] % 2 == 0)
count++;

Console.WriteLine($"всего {num.Length} чисел, {count} из них чётные");

void FillArrayRandomNumbers(int[] num)
{
    for(int i = 0; i < num.Length; i++)
    {
        num[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] num)
{
    Console.Write("[ ");
    for(int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

*/


//Task 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

/*
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] num = new int[size];
FillArrayRandomNumbers(num);
Console.WriteLine("Вот массив: ");
PrintArray(num);
int sum = 0;

for (int z = 0; z < num.Length; z+=2)
    sum = sum + num[z];

    Console.WriteLine($"всего {num.Length} чисел, сумма элементов на нечётных позициях = {sum}");

void FillArrayRandomNumbers(int[] num)
{
    for(int i = 0; i < num.Length; i++)
        {
            num[i] = new Random().Next(1,10);
        }
}
void PrintArray(int[] num)
{
    Console.Write("[ ");
    for(int i = 0; i < num.Length; i++)
        {
            Console.Write(num[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

/*
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] num = new double[size];
FillArrayRandomNumbers(num);
Console.WriteLine("Вот наш массив: ");
PrintArray(num);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < num.Length; z++)
{
    if (num[z] > max)
        {
            max = num[z];
        }
    if (num[z] < min)
        {
            min = num[z];
        }
}

Console.WriteLine($"всего {num.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayRandomNumbers(double[] num)
{
    for(int i = 0; i < num.Length; i++)
        {
            num[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] num)
{
    Console.Write("[ ");
    for(int i = 0; i < num.Length; i++)
        {
            Console.Write(num[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}
*/


//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 4

/*
int WriteWait(string inGenius)
   {
    Console.Write(inGenius);
    int Numbers = Convert.ToInt32(Console.ReadLine());
   
    return Numbers;
   }

void Counting (int inTotal)
{
    int count = 0;
    for (int i = 0; i< inTotal; i++)
    {
        Console.Write($"Введите {i + 1} -e число: ");

        if ((Convert.ToInt32(Console.ReadLine()) > 0))
        count++;
    }
    Console.WriteLine("Вы ввели положительных чисел: " + count);
}
 Console.WriteLine("Обрабатываю данные.... .");
 int tutu =  WriteWait("Введите числа: ");
Counting (tutu);
*/
//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
/*
Console.WriteLine("Введите переменную b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите переменную k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите переменную b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите переменную k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = x * k1 + b1;

Console.Write($"Точка пересечения двух прямых: ( {x}; {y}).");
*/


//Задача 47. Задайте двумерный массив размером m × n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

/*
Console.WriteLine("Задайте количество строк двумерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int n = Convert.ToInt32(Console.ReadLine());
double[,] twoDimArray = new double[m, n];
Random rand = new Random();
void PrintArray(double[,] matrix)
{ 
   for (int i = 0; i < m; i++)
  { 
   for (int j = 0; j < n; j++)
   { 
      Console.Write($"{matrix[i, j]} ");
   }
      Console.WriteLine();
  }
}

void FillArray(double[,] matrix)
{ 
    for (int i = 0; i < m; i++)
  { 
     for (int j = 0; j < n; j++)
    {
       matrix[i,j] = Convert.ToDouble(rand.Next(-100, 100)/10.0);
    }
  }
}
FillArray(twoDimArray);
Console.WriteLine();
PrintArray(twoDimArray);
*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 
//этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет

/*
Console.Write("Введите номер строки: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[6, 8];
FillArray2D(numbers);
PrintArray2D(numbers);

if 
    (rows < numbers.GetLength(0) && colums < numbers.GetLength(1)) 
     Console.WriteLine(numbers[rows, colums]);
else
     Console.WriteLine($"{rows},{colums} -> такого числа c такими индексами нет");


// Заполнение массива рандомными числами от 1 до 9
void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
//  Функция вывода массива в терминал
void PrintArray2D(int[,] array)
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
return;
*/


//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

/*
Console.Write("введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[n, m];
FillArrayRandomNumbers(numbers);

void FillArrayRandomNumbers(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(0, 10);
    }
  }
}

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine("");
  }
}
Console.WriteLine();
PrintArray(numbers);
Console.WriteLine();

for (int j = 0; j < numbers.GetLength(1); j++)
{
  double avarage = 0;
  for (int i = 0; i < numbers.GetLength(0); i++)
  {
    avarage = (avarage + numbers[i, j]);
  }
  avarage = avarage / n;
  Console.Write(avarage + "; ");
}
*/

//---------------------------------


// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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


// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

/*
Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows , columns, 0, 10);
PrintArray(array);

Console.WriteLine($"Строка с наименьшей суммой - {GetRowNumber(array)}");

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0;j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int GetRowNumber(int[,]array)
{
    int row = 0; //Фиксация индекса строки, что строка содержит мин сумму
    int minSum = 0;
    for(int i = 0; i < array.GetLength(1); i++)
    {
        minSum += array[0, i];
    }
    Console.Write($"{minSum} ");
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        Console.Write($"{sum} ");
        if(minSum > sum)
        {
            minSum = sum;
            row = i;
        }
    }
    return row + 1;
}

*/



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

/*
int[,] GetArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
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

int[,] MatrixMult(int[,] matrixA, int[,] matrixB)
{
    int rowsA = matrixA.GetLength(0);
    int columnsB = matrixB.GetLength(1);
    int[,] result = new int[rowsA, columnsB];
    if (matrixA.GetLength(1) == matrixB.GetLength(0))
    {
        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < columnsB; j++)
            {
                for (int n = 0; n < matrixA.GetLength(1); n++)
                {
                    result[i, j] += matrixA[i, n] * matrixB[n, j];
                }
            }
        }
    }
    return result;
}

int[,] matrixA = GetArray(2, 2);
Console.WriteLine($"Первая матрица: ");
PrintArray(matrixA);
int[,] matrixB = GetArray(2, 3);
Console.WriteLine($"Вторая матрица: ");
PrintArray(matrixB);

*/

//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

/*
Console.Clear();

int[,,] array3D = new int[2, 2, 2]; //Тут указываем размер массива

CreateArray(array3D);
PrintArray(array3D);

void PrintArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]}({j},{k},{i})\t");
            }
            Console.WriteLine();
        }
    }
}

void CreateArray(int[,,] array3D)
{
    int[] temp = new int[array3D.Length];
    for (int i = 0; i < temp.Length; i++)
    {
        temp[i] = new Random().Next(10, 100);
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                }
            }
        }
    }
    int count = 0;
    for (int x = 0; x < array3D.GetLength(0); x++)
    {
        for (int y = 0; y < array3D.GetLength(1); y++)
        {
            for (int z = 0; z < array3D.GetLength(2); z++)
            {
                array3D[x, y, z] = temp[count];
                count++;
            }
        }
    }
}

*/


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// Задача 64: Задайте значение N. Напишите программу, которая 
//выведет все натуральные числа в промежутке от N до 1. Выполнить
// с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*

string PrintNumber(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + " " + PrintNumber(start + 1, end));
}
Console.WriteLine(PrintNumber(1,8));

*/


// Задача 66: Задайте значения M и N. Напишите программу, которая
// найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

/*
int m = InputNumbers("Введите M: ");
int n = InputNumbers("Введите N: ");
int temp = m;

if (m > n)
{
    m = n;
    n = temp;
}

PrintSum(m, n, temp = 0);

void PrintSum(int m, int n, int sum)
{
    sum = sum + n;
    if (n <= m)
    {
        Console.Write($"Сумма элементов = {sum} ");
        return;
    }
    PrintSum(m, n - 1, sum);
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
*/


// Задача 68: Напишите программу вычисления функции Аккермана 
//с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

/*

int m = InputNumbers("Введите M: ");
int n = InputNumbers("Введите N: ");

int funAkk = Akk(m, n);

Console.Write($"Функция Аккермана = {funAkk} ");

int Akk(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Akk(m - 1, 1);
    else return Akk(m - 1, Akk(m, n - 1));
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
*/


