// Задача 19
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.


Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number > 9999 && number < 100000)
{
    if ((number % 10 == number / 10000 % 10) && (number / 10 % 10 == number / 1000 % 10))
    {
        System.Console.WriteLine($"Число {number} - палиндром");
    }
    else
    {
        System.Console.WriteLine($"Число {number} - не палиндром");
    }
}
else
{
    System.Console.WriteLine("Введите пятизначное число");
}
