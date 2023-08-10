
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++) 
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array; 
} 
 
void WriteArray(int[] array)    
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i]+ " ");
    
    Console.WriteLine();
}


int SumOfNegatives(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i] < 0)
            sum += array[i];
    
    return sum;
}
Console.Write("Input a length of array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(m, a, b);
WriteArray(myArray);
Console.WriteLine(SumOfNegatives(myArray));
*/

//Task 2. Напишите программу замена элементов массива: положительные элементы
// замените на соответствующие отрицательные и наоборот. 

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; //инициализирует элемент массива, не конкретный индекс

    for(int i = 0; i < size; i++) // Можно использовать и While
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array; 
} 
 
void WriteArray(int[] array)   //Вывоз массива
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i]+ " "); //Возврат массива
    
    Console.WriteLine();
}

int[] Replase (int[] array) // Кавдратные скобки возвращают массив
{
    
    for( int i = 0; i < array.Length; i++)
         array[i] = array[i] * (-1);        
    return array;
}

Console.Write("Input a length of array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(m, a, b);
WriteArray(Replase(myArray));
*/


//Task 3. Задайте массив. Напишите программу, которая определяет, присутствует 
//ли заданное число в массиве.

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++) 
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array; 
} 
 
void WriteArray(int[] array)    
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i]+ " ");
    
    Console.WriteLine();
}

bool Find(int [] array, int number)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(number == array[i])
          return true;
    }
    
    return false;
}

Console.Write("Input a length of array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(m, a, b); //создали массив
WriteArray(myArray); // Вывели массив

Console.WriteLine("Input num: "); //Вводим число которое хотим найти
int num = Convert.ToInt32(Console.ReadLine());

bool res = Find(myArray, num);
Console.WriteLine(res);
*/





Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int kvadr = num2 * num2;
if(num1 == kvadr)
{
    Console.WriteLine("Ваше число является квадратом ");
}
else
{
    Console.WriteLine("НЕТ");
}