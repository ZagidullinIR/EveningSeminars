
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