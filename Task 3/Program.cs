Console.Clear();
Console.WriteLine("Введите номер число от 1 до 7");
int DayNumber = Convert.ToInt32(Console.ReadLine());

if (DayNumber == 1)
{
  Console.Write("День недели: ");
  Console.WriteLine("Понедельник");
}
else if (DayNumber == 2)
{
  Console.Write("День недели: ");
  Console.WriteLine("Вторник");
}
else if (DayNumber == 3)
{
  Console.Write("День недели: ");
  Console.WriteLine("Среда");
}
else if (DayNumber == 4)
{
  Console.Write("День недели: ");
  Console.WriteLine("Четверг");
}
else if (DayNumber == 5)
{
  Console.Write("День недели: ");
  Console.WriteLine("Пятница");
}
else if (DayNumber == 6)
{
  Console.Write("День недели: ");
  Console.WriteLine("Суббота");
}
else if (DayNumber == 7)
{
  Console.Write("День недели: ");
  Console.WriteLine("Воскресенье");
}
else 
{
  Console.WriteLine("Вы ввели число не от 1 до 7");
}
