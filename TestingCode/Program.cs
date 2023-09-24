//Методы работы функций
/*
void Method1() //Не возвращает и не принимает данные
   {
    Console.WriteLine("Автор ...");
   }
Method1();
*/

//----------------------

//Метод Второй, НЕ возвращает но может принимать данные
/*
void Method2(string msg) 
   {
    Console.WriteLine(msg);
   }
 Method2(msg: "Текст сообщения");
 */
/*
void Method21(string msg, int count)
{
  int i = 0;
  while (i < count) 
  {
    Console.WriteLine(msg);
    i++;
  }
}
//Method21("Текст" , 4);
Method21(count: 4, msg: "новый текст");
*/
//-------------------------------------

//Третий метод  Возращает данные
/*
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);
*/

//--------------------------------------

//Метод 4 Принимает и возвращает данные
/*
string Method4(int count, string text)
{
    int i = 0;
    string result = ""; // String.Empty; - Это аналог, без разницы что использовать 

    while(i < count)
    {
        result = result + text;
        i++;
    } 
    return result;
}
string res = Method4(10, "text: ");
Console.WriteLine(res);
*/

//---------------------------------------

//Метод с Циклом FOR
/*
string Method4(int count, string text)
{
    
    string result = ""; // String.Empty; - Это аналог, без разницы что использовать 
    for(int i = 0;i < count; ++i )
    {
        result = result + text;
    } 
    return result;
}
string res = Method4(10, "text: ");
Console.WriteLine(res);
*/







//Цикл с Пробелом между строк
/*
Console.Write("Введите размерность m массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность n массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[m, n];

void mas(int m, int n)
{
  int i, j;
  Random rand = new Random();
  for (i = 0; i < m; i++)
  {
    Console.WriteLine();
    for (j = 0; j < n; j++)
    {
      randomArray[i, j] = rand.Next(1, 9);
      Console.Write($"{randomArray[i, j]} ");
    }
    Console.WriteLine();
  }
}
void colomns(int m, int n)
{
  Console.Write("Среднее арифметическое каждого столбца: ");
  int i, j;
  Random rand = new Random();
  for (j = 0; j < n; j++)
  {
    double sum = 0;
    for (i = 0; i < m; i++)
    {
      sum = sum + randomArray[i, j];
    }
    Console.Write($"{sum / (i):F1}; ");
  }
}
mas(m, n);
colomns(m, n);
*/

/*
Console.Write("введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[n, m];
FillArrayRandomNumbers(numbers);



void FillArrayRandomNumbers(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(0, 10);
    }
  }
}

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine("");
  }
}
Console.WriteLine();
PrintArray(numbers);
Console.WriteLine();

for (int j = 0; j < numbers.GetLength(1); j++)
{
  double avarage = 0;
  for (int i = 0; i < numbers.GetLength(0); i++)
  {
    avarage = (avarage + numbers[i, j]);
  }
  avarage = avarage / n;
  Console.Write(avarage + "; ");
}
*/


 // game loop
        while (true)
        {
            for (int i = 0; i < 8; i++)
            {
                int mountainH = int.Parse(Console.ReadLine()); // represents the height of one mountain.
            }
    
            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");
            
            Console.WriteLine("0"); // The index of the mountain to fire on.
            
        }