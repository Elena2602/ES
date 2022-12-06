//Задача 13
Console.Clear();

Console.WriteLine("Введите трехзначное число:  ");
int n = Convert.ToInt32(Console.ReadLine());
if (n / 100 == 0)
{
    Console.WriteLine("Нет третьей цифры");
    Console.WriteLine(n / 100);
}
if (n / 100 > 0)
{
    int n1 = 1000;
    while (n / n1 > 0)
    {
        n1 = n1 * 10;
    }
    int n4 = n / (n1 / 1000);
    int n3 = n4 % 10;
    Console.WriteLine(n3);

}