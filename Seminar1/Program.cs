
// Seminar 1
// Theory
/*
int intNumber = 25;
double dobleNumber = 12.12;
string text = "some text";
bool logicVar = true;
*/
/*
int num1 =5;
int num2 =10;
Console.WriteLine("My numbers are " + num1 + " and " + num2 + " and it is good!");
Console.WriteLine($"My numbers are {num1} and {num2} and it is good!");
*/
/*
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Your number is " + num);
*/

// Задание 1. Напишите программу, которая на вход принимает два числа и проверят,
// является ли первое число квадратом второго.

/*
Console.Write("Input a first number: "); //Вывести в этой строке фразу "Input a first number:
int num1 = Convert.ToInt32(Console.ReadLine()); //Выделить переменную, которая будет называться num1
 //в которую запишется конвертируемое в тип инт32, значение введеное пользователем.
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad2 = num2 * num2; // Объявить переменную куда мы записываем предыдущую переменную 
// на умноженную на себя.
if(num1 == quad2) // Если переменная 1 совпадает с переменной 2
{ // тогда выводим сообщение "Yes" 
   Console.WriteLine("Yes!");
} //Фигурные скобки можно не ставить, если одна команда в условии
else  // Иначе выводим сообщение "No"
{
    Console.WriteLine("No!");
}
 */

 // Задание 2. Напишите программу, которая на вход принимает одно положительное число (N),
 // а на выходе показывает все числа в промежутке от -N до N.

/*
Console.Write("Inpet a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = -num;

while(current <= num)
{
    Console.Write(current + " ");
    current++;
}
*/


