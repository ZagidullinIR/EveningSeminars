﻿// Example001_HelloWorld
/*
    Console.WriteLine("Hello, World!");

*/

// Example002_HelloUser Приветствие
/*
Console.WriteLine("Введите ваше имя ");
string username = Console.ReadLine();
Console.WriteLine("Привет, " + username);
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

// Else Приветствие с Именем Машуня

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

// Пузырьковый метод перебора МАКС значения числа.

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

// Цикл
/*

Console.Clear();
Console.SetCursorPosition(10,4);
Console.WriteLine("+");

int xa = 40, ya = 1,
    xb = 1, yb = 30,
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

// МЕТОДЫ VOID

// Первый метод - Вывод информации

/* 
void Method1()
{
    Console.WriteLine("Автор ...") 
}
 Method1();
 */

// Второй метод - Только принимает данные, без возврата.
/*
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");

void Method21(string msg, int count)
{
    int i =0
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg"Текст", count: 4);
Method21(count: 4, msg: "новый текст");

*/

// Третий метод  - Только выдает информацию

/*
int Method3()
{
    return DateTime.Now.Year;
}
 int  year = Method3();
 Console.WriteLine(year);

 */

// Четвертый метод - Принимает и выдает информацию

/*
string Method4(int count, string text)
{
   int i = 0;
   string result = String.Empty;
   while (i < count)
   {
       result = result + text;
       i++;
   }
   return result;
}
string res = Method4(10, "asdf");
Console.WriteLine(res);

*/

// Четвертый метод сокращенный.
/*
 string Method4(int count, string text)
 {

    string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
 }
 string res = Method4(10, "z");
 Console.WriteLine(res);
*/

// Возможности методов.

// Таблица умножения

/*
for(int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}
*/

//Example011 Работа с текстом

// Дан текст.В тексте нужно все пробелы заменить черточками,
//  маленькие буквы "к" заменить большими "К",
//  а большие "С" заменить маленькими "с".

// Начало текста

/*
string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";


*/
//string s = "qwerty"
//            012345
// s[3] // r - по счету получается что буква третья на клавиатуре

/*
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int lenfth = text.Length;
    for (int i = 0; i < lenfth; i++)
    {
         if(text[i] == oldValue) result = result + $"{newValue}";
         else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '_' );

Console.WriteLine(newText);
Console.WriteLine(); //Условно делит текст
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'с' , 'С');
Console.WriteLine(newText);
*/

// Сортировка Массива

/*
int[] arr = {1, 5, 4, 3, 2, 7, 6, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} "); //Вывод в одну строку
    }
 Console.WriteLine();   
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1 ; i++)
    {
        int minPosition = i;
        
        for (int j = i+1; j < array.Length; j++) 
        {
            if(array[j] < array[minPosition]) minPosition = j; //Ищем минимальный элемент
        }
        int temporary = array[i];
        array[i] = array[minPosition];        //обен двух переменных местами
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr); //Вызвали упорядочивание массива

PrintArray(arr);
*/

//-------------------------------------

// Двумерные массивы

/* Вывод текста в консоли.

string[,] table = new string[2, 5];

table[1, 2] = "слово";

for (int rows = 0; rows < 2; rows++)
    {   
        for (int columns; columns < 5; columns++)
        {
            Console.WriteLine($"-{table[rows, columns]}-");    
        }
    }   
*/

/*
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < 3; i++) // matrix.Getlength(0) = можно юзать вместо 3-ки 
    {
        for (int j = 0; j < 4; j++) //matrix.Getlength(0) = можно юзать вмето 4-ки
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();  //Принудительный перевод на новую строку    
    }
}

void FillArray(int[,] matrix)//Заполняет матрицу случайными числами
{
    for (int i =0; i < 3; i++)
    {
        for(int j = 0; j < 4; j++)
        {
            matrix[i, j] = new Random().Next(1,10);
            //Создали Рандомайзер
        }
    }
}

int[,] matrix = new int[3, 4]; //Задаем колличество памяти,
                               // сколько будет выделенно ячеек
PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);  //Выводит рандомные числа
PrintArray(matrix);
*/

// Рука рисунок(не реализован, сложно реализовать).

/*
int[,] pic = new int[,]
{
    { 0, 0,}
}
void PrintImage(int[,] image)
{
    for(int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; i < image.GetLength(1); j++)
       { 
            //Console.WriteLine($"{matrix[i, j]}");
            if(image[i, j] == 0) Console.Write($" "); //Если ноль, то печатаем пробел
            else Console.Write($"+"); //Если не ноль то печатаем +
       }
    }
    Console.WriteLine();
}
void FillImage(int row,int col)
{
    if (pic[row,col] ==0)
    {
        pic[row,col] = 1;
        FillImage(row - 1; col);
        FillImage(row; col - 1);
        FillImage(row + 1; col);
        FillImage(row; col + 1);
    }
}

PrintImage(pic);
FillImage(13,13);
PrintImage(pic);
*/

//--------------------------------------

// Факториал

/*
double Factorial (int n)
{
    if (n ==1) return 1;
    else return n * Factorial(n - 1);
}
for(int i = 1; i < 10; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
*/

//--------------------------------------

// Fibonachi

/*
int Fibonacci(int n)
 {
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
 }

for (int i =1 ; i < 10; i++)
{
    Console.WriteLine(Fibonacci(i));
}
*/

//----------------------------------------

//Треугольник Паскаля --- Что-то не работает(((

/* 
int row = 5;
int[,] triangle = new int[row, row];
const int cellWidth = 1;

void FillTriangle()
{
    for (int i = 0; i < row; i++)
    {
        triangle[i, 0] = 1;
        triangle[i, i] = 1;
    }

    for (int i = 2; i < row; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
        }
    }
}


void PrintTriangle()
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < row; j++)
        {
            if (triangle[i, j] != 0)
                Console.Write($"{triangle[i ,j],cellWidth}");
        }
        Console.WriteLine();
    }
}

void Magic()
{
    int col = cellWidth * row;
    for (int i = 0; i < row; i++)
    {
        for(int j = 0; j <= i; j++)
        {
            Console.SetCursorPosition(col, i + 1);
            //if(triangle[i,j] != 0) Console.WriteLine($"{triangle[i, j],cellWidth}");
            if (triangle[i, j] != 0) Console.WriteLine("*");
            col += cellWidth * 2;
        }
        col = cellWidth * row - cellWidth * (i + 1);
        
        Console.WriteLine();
    }

}

Console.ReadLine();
FillTriangle();
//PrintTriagle();
Console.ReadLine();
Magic();
*/

//-----------------------------------------