// Task 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();
Console.Write("Введите число: ");
string? n = Console.ReadLine();
int x = n.Length;

if (x == 5)
{
    if (n[0] == n[4] && n [1] == n[3])
    
    {
        Console.WriteLine($"{n} - палиндром");
    }
    else
    {
        Console.WriteLine($"{n} - не палиндром");
    }
}
else
{
    Console.WriteLine($"Не правильно: {n} - не является пятизначным");
}