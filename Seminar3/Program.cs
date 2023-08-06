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




/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; //Выделяем ячейку памяти int[],
    // new int -указываем сколько элементов у нас будет. В случае 
       инициализации обязательно нужно указать размер,в данном случае 
       размер это *size*. 

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue +1);
    
return array;
}
void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
       Console.while (array[i] + " ");

   Console.WriteLine();
}
Console.Write("Input a length of an array; ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value": );
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateRandomArray(length, min, max);
WriteArray(myArray);
*/




