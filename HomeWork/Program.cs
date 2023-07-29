
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