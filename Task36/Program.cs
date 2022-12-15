//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
//стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
//int m = 4;
int[] n = new int[4];
ReleaseArray(n);
InputArray(n);

int sum = 0;

for (int i = 1; i < n.Length; i += 2)
{
    sum += n[i];
}
Console.Write(($"Сумма элементов: {sum}"));


void ReleaseArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
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
