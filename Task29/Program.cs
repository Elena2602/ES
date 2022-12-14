//Задача 29: Напишите программу, которая спрашивает у пользователя кол-во элементов и спрaшивает сами элементы.
// После записи элементов в массив, необходимо его вывести на экран.
//1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
Console.Clear();
Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите элементы: ");
int[] array = new int[n];

for (int i = 0; i < array.Length; i++)
{
    
     int m = Convert.ToInt32(Console.ReadLine());
    array[i] = m; 
}
Console.Write($"[{string.Join(", ", array)}]");