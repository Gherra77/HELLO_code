№2. Напишите программу, которая на вход принимает два числа и выдает
какое число большее, а какое меньшее.


Console.Write("Enter first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int b = Convert.ToInt32(Console.ReadLine());
if(a > b)
{
    Console.WriteLine($"max = {a}");
}
else
{
    Console.WriteLine($"max = {b}");
}

№4. Напишите программу, которая принимает на вход три числа 
и выдает максимальное из этих чисел.

Console.Write("Enter first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter third number: ");
int c = Convert.ToInt32(Console.ReadLine());

if(a > b && a > c)
{
    Console.WriteLine($"max = {a}");
}
else
{
    if( b > a && b > c)
    {
    Console.WriteLine($"max = {b}");
    }
    else
    {
    Console.WriteLine($"max = {c}");
    }
}


№6. Напишите программу, которая на вход принимает число и выдает, является ли
число четным (делится ли оно на два без остатка)

System.Console.Write("Input number:  ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
  System.Console.WriteLine($"Число {num} -> является четным");
}
else
{
    System.Console.WriteLine($"Число {num} -> является нечетным");
}

№8. Напишите программу, которая на вход принимает число (N),
а на выходе показывает все целые числа от 1 до N.


System.Console.Write("Input N: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    number = (number * (-1));
    int index = 1;
while (index <= number)
{
   System.Console.Write(index++);
}
}
else 
{
int index = 1;
while (index <= number)
{
   System.Console.Write(index++);
}
}// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


// void SecondDigit ()
// {    
//     int num = Convert.ToInt32(Console.ReadLine());
//     if (num > 99 && num < 1000) 
//     {        
//     num = ((num / 10) % 10);
//     System.Console.WriteLine(num);
//     }
//     else
//     {
//      System.Console.WriteLine("Введенное число не является трехзначным");
//     }      
// }
// System.Console.WriteLine("Введите трехзначное число: ");
// SecondDigit ();



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// void ThirdDigit ()
// {
//     int num = Convert.ToInt32(Console.ReadLine());
//     int size = 0;
//     if (num / 100 < 1)
//     {
//     System.Console.WriteLine("Введенное число двухзначное");
//     System.Console.WriteLine("Невозможно вывести третью цифру числа");
//     }
//     else
//     {  
//         while (num >= 1)
//         {
//         num = num / 10;          
//         size = size + 1;
//             if (num > 99 && num < 1000)
//             {
//             System.Console.WriteLine($"Третья цифра данного числа = {num % 10}");
//             }
//         }
//     }
            
// }
// System.Console.WriteLine("Введите число: ");
// ThirdDigit ();




// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


// void DayOff ()
// {    
//     int num = Convert.ToInt32(Console.ReadLine());
//     if (num > 1 && num < 8)
//     {
//            if (num > 1 && num < 6)
//            {
//             System.Console.WriteLine("Не выходной день");
//            }
//            else
//            {
//             System.Console.WriteLine("Выходной день");
//            }

//         }
//     else
//     {
//      System.Console.WriteLine("Данное число не является днем недели");
//     }      
// }
// System.Console.WriteLine("Введите день недели");
// DayOff ();




//   !!!! Определение количества символов в введенной цифре.

//    System.Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int size = 0;
// while (num >= 1)
// {
// num = num / 10;          
//  size = size + 1;
// }
// System.Console.WriteLine(size);
// System.Console.WriteLine("Stop"); 
