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