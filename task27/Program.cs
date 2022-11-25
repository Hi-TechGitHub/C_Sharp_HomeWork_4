// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int Task27(int a) 
{
    int res = 0;
    int i = 1;
    while (i > 0) //123
    {  
        res += a % 10;
        a = a / 10;
        if (a == 0) i = -1;
    }
    return res;

}
 Console.WriteLine("Напишите число");
 int enter = Convert.ToInt32(Console.ReadLine());
 int result = Task27(enter);
Console.WriteLine(result);

