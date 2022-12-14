// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и
// возводит число A в натуральную степень B.
//Нельзя использовать функцию Math.Pow
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
Console.Clear();
Console.Write("Введите число A: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int m = Convert.ToInt32(Console.ReadLine());
int array = n;

for (int i = 1; i < m; i++)
{
array = array * n;
}
Console.WriteLine("A в степени B равно: " + array);