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
