// Задача 23

// Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();
System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Таблица кубов: ");

for (int i = 1; i <= N; i++)
    {
        System.Console.Write($"{Math.Pow(i, 3)} ");
    }
