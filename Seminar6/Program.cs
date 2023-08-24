
//Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)

//2. Task

//Напишите программу, которая принимает на вход три числа и проверяет, может
// ли существовать треугольник с сторонами такой длины.

/*
bool Proverka(int a, int b, int c)
{
    if(a < (b + c) && b < (a + c) && c < (a + b)) return true;
    else return false;
}
 
Console.WriteLine("Input num 1: ");
int a = Conver.ToInt32(Console.ReadLine());
Console.WriteLine("Input num 2: ");
int b = Conver.ToInt32(Console.ReadLine());
Console.WriteLine("Input num 3: ");
int c = Conver.ToInt32(Console.ReadLine());

*/


//Task 3. Не используя рекурсию, выведите первые N чисел фибоначи
// Первые два числа фибоначи: 0 и 1.
/*
int[] Fibonachi(int length)
{
    int[] array = new int[length];
    array[0] = 0;
    array[1] = 1;
    for ( int i = 2; i < length; i++)
        {
            array[i] = array[i-2] + array[i-1];
        }
    return array;
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
Console.Write("Input length: ");
int a = Convert.ToInt32(Console.ReadLine());

int[] myArray = Fibonachi(a);
WriteArray(myArray);
*/

//Task 4. Напишите программу, которая будет создавать копию 
//      заданного массива с помощью поэлементного копирования.

/*
void PrintArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] CreateRamdomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue,maxValue+1);
    return array;
}

int[] CopyArray(int size, int[] first_array)
{
    int[] second_array = new int[size];
    for(int i = 0; i < size; i++)
    {
        second_array[i] = first_array[i];
    }
    return second_array;
}

Console.Write("Input a lenght of array: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min possible value: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a max possible value: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRamdomArray(m, a, b);
PrintArray(myArray);
int[] CopyMyArray = CopyArray(m, myArray);
PrintArray(CopyMyArray);
*/

