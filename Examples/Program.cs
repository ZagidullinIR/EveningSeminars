﻿// Example001_HelloWorld
/*
    Console.WriteLine("Hello, World!");

*/

// Example002_HelloUser Приветствие
/*
Console.WriteLine("Введите ваше имя ")
string username = Console.ReadLine();
Console.WriteLine("Привет, ");
Console.WriteLine(username);
*/

//Example003_Sum Сложение чисел
/*
   int numberA = 31;
   int numberB = 5;
   int result = numberA + numberB;
   Console.WriteLine(result);
*/

/* 
int numberA = new Random().Next(1,10); //1 2 3 4 
  Console.WriteLine(numberA);  // Отображает строку в  терминале со своим значением.
   int number B = new Random().Next (1,10);
   Console.WriteLine(numberB);
   int result = numberA + numberB;
   Console.WriteLine (result);
*/

//Example004_Div Деление
/*
doble numberA = 12; //int - деление целых данных
doble numberB = 5;  // doble - деление с остатком
Console.WriteLine(numberA / numberB); 
*/

//Example005_Condition_if_Else

/*

Console.Write("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "маша")  //Команда все буквы уводит в нижний регистр (ToLower)
{
    Console.WriteLine("Ура, это же МАШУНЯ!!!");
}
else 
{
    Console.Write("Привет ");
    Console.WriteLine(username);
}
*/

//Example006_Base

/*
int a = 1;
int b = 2;
int c = 6;
int d = 9;
int e = 4;

int max = a

if(a > max ) max = a;
if(b > max ) max = b;
if(c > max ) max = c;
if(d > max ) max = d;
if(e > max ) max = e;

Console.WriteLine("max = ");
Console.WriteLine(max);
*/

//Example007_Magic_Цикл
/*
using System.Runtime.Intrinsics.X86;

Console.Clear();
Console.SetCursorPosition(10,4);
Console.WriteLine("+");

int xa = 40, ya = 1
    xb = 1, yb = 30
    xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");  

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

 int x = xa, y = xb;
 int count = 0; 
while(count < 1000); //Счетчик колличества раз
{
    int what = new Random().Next(0, 3);
    if(what == 0)
    {
        x = (x+xa)/2;
        y = (y+ya)/2;
    }
    if(what == 1)
    {
        x = (x+xb)/2;
        y = (y+yb)/2;
    }
    if(what == 2)
    {
        x = (x+xc)/2;
        y = (y+yc)/2;
    }
     Console.SetCursorPosition(x, y);
     Console.WriteLine("+");
     count++;
}

*/

//Example008_IntroMethod

/*
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 23;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 33;
*/

/*
int max = a1;
if(b1 > max) max = b1;
if(c1 > max) max = c1;

if(a2 > max) max = a2;
if(b2 > max) max = b2;
if(c2 > max) max = c2;

if(a3 > max) max = a3;
if(b3 > max) max = b3;
if(c3 > max) max = c3;
*/

/*
int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max2, max3); // Ниже другой вариант решения
*/

/*
 int max = Max(
    Max(a1, b1, c1), 
    Max(a2, b2, c2)
    Max(a3, b3, c3));        
 Console.WriteLine(max);
 */

//Example009_IntroArrey

/*
//             0    1   2   3   4  5   6   7   8
int[] array = {11, 21, 31, 41, 51, 61, 71, 81, 91,};

 int n = array.Length;
 int find = 4;

 int index = 0;

 while (index < n)
 {

       if (array[index] == find)
       {
           Console.WriteLine(index);
           break;
       } 
       index ++;  
 }
*/

//using System.Collections.ObjectModel;
//using System.Runtime.CompilerServices;
//using Microsoft.VisualBasic;

/*
 void FillArray(int[] collection)
 {
    int length = Collection.Length;
    int index = 0;
    while (index < length)
    {
        Collection[index] = new Random().Next(1, 10);
        index++;
    }
 }
 void PrintArray(int[] col)
 {
      int count = col.Length;
      int position = 0;
      while (position < count)  
      {
          Console.WriteLine(col[position]);
          position++; 
      }
 } 
 
 int IndexOf(int[] collection, int find)
  {
     int count = collection.Length;
     int index = 0;
     int position = -1;
     while (index < count)
     {
       if(collection[index] == find)
       {
          position = index;
          break;
       }
       index++;
     }
      return position;
  }

 int[] array = new int[10];

 FillArray(array);
 PrintArray(array);
 Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
*/

