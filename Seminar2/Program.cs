// Seminar 2.

// Theory

// Task1. Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа.
/*
int CutNumber(int num)
{
    int hundreds = num / 100;
    int units = num % 10;

   // int res = hundreds * 10 + units; Один из вариантов решения
   // return res;
   return hundreds * 10 + units;
}

// 351 -> 3 1 -> 31  Этим методом мы убрали 5-ку.

int randNum = new Random().Next(100, 1000);
int cuttedNum =  CutNumber (randNum);
*/

//CutNumber(randNumber);  Сейчас не сохраняет результат работы и не выводит его на экран

//Console.WriteLine(CutNumber(randNumber)); //Один из вариантов вывода результата
//Console.WriteLine($"New version of {randNumber} is {nerNumber}");

//----------------------------------------------------------------------------

// Task 2. Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно a и b.
/*
bool IsDividable(int num , int div1, int div2)
{
    if (num % div1 == 0 && num % div2 == 0)
            return true;
        else
            return false;
}

Console.Write("Input a number for checking: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a first divider: ");
int divider1 = Convert.ToInt32(Console.ReadLine());
*/

//-----------------------------------------------------------------------------

// Task 3. Напишите программу, которая выводит случайное число 
// из отрезка [10, 99] и показывает наибольшую цифру числа.

/*
int Maxnum(int num)
{
    int num1 = num % 10;
    int num2 = num / 10;
    if (num1 > num2) return num1;
     else return num2;
}
int number = new Random().Next(10, 100); 
Console.WriteLine(number);
int res = Maxnum(number);
Console.WriteLine(res);
*/

//-----------------------------------------------------------------------------

// Task 4. Напишите программу , которая принимает  на вход два числа и проверяет
// является ли одно число квадратом другого.
/*
bool KvadratChisla(int num1, int num2)
{
    retern num1 == num2 *num2 || num2 == num1 * num1;
}
Console.Write("Input a number 1 for checking: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number 2 for checking: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool res = KvadratChisla (num1, num2);

if (res) Console.Write("Yes");
else Console.Write("No");
*/