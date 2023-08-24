//Seminar 3.

//Theory 
        // Console.WriteLine(Math.Pow(5 ,2));
        // Console.WriteLine(Math.Sqrt(24));
        // Console.WriteLine(Math.Round(Math.Sqrt(24), 2));


//Task 1. Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти(X и Y).
/*
void WriteRange(int qadrant)
{
    if(qadrant < 1 || qadrant > 4) Console.WriteLine("Uncorrect data!");
    else if(qadrant == 1) Console.WriteLine("x > 0 and y > 0");
    else if(qadrant == 2) Console.WriteLine("x < 0 and y > 0");
    else if(qadrant == 3) Console.WriteLine("x > 0 and y < 0");
    else Console.WriteLine("x < 0 and y > 0");
    //return; //можно использовать возврат, но не обязательно. БЕЗ ВОЗВРАТА МЕТОДА
}

Console.Write("Input a number of qadrant: ");
int quad = Convert.ToInt32(Console.ReadLine());

WriteRange(quad);
*/

//Task 2.Напишите программу, которая принимает на вход координаты 
    // точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
    // в которой находится эта точка.
 /*  
   int Quadrant(int x, int y)
   {
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
   }

Console.Write("Input x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y: ");
int y = Convert.ToInt32(Console.ReadLine());

int quad = Quadrant(x, y);
if (quad == 0) Console.WriteLine("Uncorrect data");
else Console.Write("Quadrant number is: " + quad);
*/


//Task 3.Напишите программу, которая принимает на вход число (N) и 
   //  выдаёт квадраты чисел от 1 до N.
/*
   void WriteQuad(int number)
   {
        int current = 1;
        while(current <= number)
        {
         Console.WriteLine($"{current} - {current * current}");
            current++;    
        } 
   }

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

WriteQuad(number);
*/

//Task 4.Напишите программу, которая принимает на вход координаты 
    // двух точек и находит расстояние между ними в 2D пространстве.

/*
double Distance(double x1 , double y1 , double x2 , double y2)   
{
    double deltaX = x2 - x1;
    double deltaY = y2 - y1;

    return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
}
Console.Write("Input x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Distance (x1 , y1 , x2 , y2 ));
*/
