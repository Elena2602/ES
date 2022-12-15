//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
 //Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
Console.Write("Введите размер массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] n = new int[m];
int count = 0;
ReleaseArray(n);
InputArray(n);


for (int i = 0; i < n.Length; i++)
{
    if (n[i] % 2 == 0)
    count++;
}


Console.WriteLine($"Количество чётных чисел в массиве: {count} ");

void ReleaseArray (int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}
void InputArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}