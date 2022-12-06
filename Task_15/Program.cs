// Задача 15
Console.Clear();
Console.Write("Введите день недели: ");
  int n = Convert.ToInt32(Console.ReadLine());

  while (n < 1 || n > 7)
  {
    Console.Write("Вы ошиблись!\nВведитете день недели: ");
    n = Convert.ToInt32(Console.ReadLine());
  }
if (n == 6 || n == 7)
Console.WriteLine("Выходной");
else  
Console.WriteLine("Рабочий");

