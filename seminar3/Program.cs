// Напишите программу, которая принимает на вход координаты точки (X и Y), при чем X != 0 Y !=0 и выдает номр четверти плоскости, в которой находится эта точка

// 1е решение без метода
// запрашиваем координаты
Console.WriteLine("Введите координаты x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты y: ");
int y = Convert.ToInt32(Console.ReadLine());

if ( x > 0 && y > 0)
{
    Console.WriteLine("Первая четверть");
}
else if ( x < 0 && y > 0)
{
    Console.WriteLine("Вторая четверть");
}
else if ( x < 0 && y < 0)
{
    Console.WriteLine("Третья четверть");
}
else ( x > 0 && y < 0)
{
    Console.WriteLine("Четвертая четверть");
}