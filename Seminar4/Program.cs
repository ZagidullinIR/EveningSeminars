//   Напишите программу, которая принимает на вход число (А) 
//   и выдаёт сумму чисел от 1 до А.
/*
int sum (int a)
{
    int result = 0;
    for(int i = 1; i <= a; i++)
      result += i;
    return result;
}
 Console.WriteLine ("input the number: ");
 
 int number = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine(sum(number)); 
*/


//   Напишите программу, которая принимает на вход число и выдаёт
//   количество цифр в числе.

/*
    int CountNumbers(int N)
    {   
        int count = 1;
        for (; 10 <= N; count ++)
           N = N/10;
        return count;    
    }
    Console.WriteLine("Input the number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(CountNumbers(number));

*/

//   Напишите программу, которая принимает на вход число N и выдаёт 
//   произведение нечетных чисел от 1 до N.

/*
int prov (int a)
{
    int result = 1;
    for(int i = 1; i <= a; i = i+2)
        result *= i;
    return result;
}
Console.WriteLine("input the number:  ");

int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(prov(number));

*/