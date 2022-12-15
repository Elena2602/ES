//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

int[] n = new int[10];
ReleaseArray(n);
InputArray(n);

int max = n[0];
int min = n[0];

for (int i = 0; i < n.Length; i++)
{
    if (n[i] > max)
    {
        max = n[i];
    }
    else if (n[i] < min)
    {
        min = n[i];
    }
}

Console.WriteLine($"Минимальное число: {min}");
Console.WriteLine($"Максимальное число: {max}");
Console.WriteLine($"Разница между числами: {max - min}");



void ReleaseArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 101);
    }
}


void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}