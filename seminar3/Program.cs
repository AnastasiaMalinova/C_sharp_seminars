// Напишите программу, которая принимает на вход координаты точки (X и Y), при чем X != 0 Y !=0 и выдает номр четверти плоскости, в которой находится эта точка

// 1е решение без метода
// запрашиваем координаты
// Console.WriteLine("Введите координаты x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// if ( x > 0 && y > 0)
// {
//     Console.WriteLine("Первая четверть");
// }
// else if ( x < 0 && y > 0)
// {
//     Console.WriteLine("Вторая четверть");
// }
// else if ( x < 0 && y < 0)
// {
//     Console.WriteLine("Третья четверть");
// }
// else if ( x > 0 && y < 0)
// {
//     Console.WriteLine("Четвертая четверть");
// }
// else 
// {
//     Console.WriteLine("Определить четверть не возможно")
// }


// 2-е решение с методом

// Пример с методом void
// void - метод ничего не возвращает, будет что-то проверять, какие-то действия может выполнить сам
// написали название метода void
// придумали название этого метода: printQuarter
// передали  в него два значения, две переменных a и b
// программа делится на две части, в первой будет описан метод void, во второй сама программа

// void printQuarter(int a, int b)
// {
// if ( a > 0 && b > 0)
// {
//     Console.WriteLine("Первая четверть");
// }
// else if ( a < 0 && b > 0)
// {
//     Console.WriteLine("Вторая четверть");
// }
// else if ( a < 0 && b < 0)
// {
//     Console.WriteLine("Третья четверть");
// }
// else if ( a > 0 && b < 0)
// {
//     Console.WriteLine("Четвертая четверть");
// }
// else 
// {
//     Console.WriteLine("Определить четверть не возможно");
// }
// }


// Console.WriteLine("Введите координаты x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// // последней строкой вызываем метод, описанный выше
// printQuarter(x, y);
// // вызываем метод, чтобы он взял значения x y и сохранил в свои переменные a b
// // и с этими переменными продолжил работу внутри метода
// // передвать в метод мы можем разные значения, он всегда будет преобразовывать это в свои переменные



// // Пример с методом int, который возвращает значения

// // в данному случае была бы другая функция, которая бы принимала значения, но делала return
// // этот метод бы что-то возвращад, н-р return 1; и т.д.

// int returnQuarter(int a, int b)
// {
//    if ( a > 0 && b > 0)
// {
//     return 1;
// }
// else if ( a < 0 && b > 0)
// {
//     return 2;
// }
// else if ( a < 0 && b < 0)
// {
//     return 3;
// }
// else if ( a > 0 && b < 0)
// {
//     return 4;
// }
// else 
// {
//     return 0;
// } 
// }
// // в этому случе метод нужно сохранить в какую-то переменную, потому что функция что-то вернет
// // или вывести ее на экран

// Console.WriteLine("Введите координаты x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// // можно вывести значение функции на экран, чтобы увидеть // Console.WriteLine(returnQuarter(x, y));
// // можно сохранить значение метода в переменную
// // эту переменную потом можно тоже вывести на экран
// int quater = returnQuarter(x, y);
// // // выводим переменную на экран (если нужно) или производим с ней какие-то другие действия
// Console.WriteLine($"Четверть: {quater}");


// в качестве возвращающего метода используем int т.к работаем с целыми числами.
// название метода в зависимости от типа данных 

// Напишите программу, которая по заданному номеру четверти 
// показывает возможный  диапазон координат точек в этой четверти (x и y)

// 1й вариант

// void searchRange(int a)
// {
//     if (a == 1)
// {
//     Console.WriteLine("x > 0, y > 0");
// }
// else if (a == 2)
// {
//     Console.WriteLine("x < 0, y > 0");
// }
// else if (a == 3)
// {
//     Console.WriteLine("x < 0, y < 0");
// }
// else if (a == 4)
// {
//     Console.WriteLine("x < 0, y < 0");
// }
// else 
// {
//     Console.WriteLine("Введено не корректное значение");
// }

// }
// Console.WriteLine("Введите название четверти координат от 1 до 4: ");
// int quarter = Convert.ToInt32(Console.ReadLine());
// searchRange(quarter);

// 2й вариант

// void diapason (int q)
// {
//     switch (q)
//     {
//         case 1: Console.Write("x > 0, y > 0"); break;
//         case 2: Console.Write("x > 0, y < 0"); break;
//         case 3: Console.Write("x < 0, y < 0"); break;
//         case 4: Console.Write("x < 0, y > 0"); break;
//         default: Console.Write("Введено не корректное значение"); break;

//     }
// }

// Console.WriteLine("Введите название четверти координат от 1 до 4: ");
// int quarter = Convert.ToInt32(Console.ReadLine());
// diapason(quarter);

// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
// Math.sqrt поможет найти квадратный корень
// Math.Pow найти степень

// вводим переменную double тк квадратный корень дробное число из целого числа
double lengthOtr(int a, int b, int c, int d)
{
    double l = Math.Sqrt(Math.Pow(a-c,2) + Math.Pow(b-d,2));
    return l;
} 
Console.WriteLine("Зададим координаты двух точек A и B на координатах x и y.");
Console.WriteLine("Введите координаты точки Xa: ");
int Xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки Ya: ");
int Ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки Xb: ");
int Xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки Yb: ");
int Yb = Convert.ToInt32(Console.ReadLine());
lengthOtr(Xa, Xb, Ya, Yb);
Console.WriteLine($"Расстояние между двумя точками равно: {lengthOtr(Xa, Xb, Ya, Yb):f2}");

// если я хочу вывести две цифры после запятой, то f:2, если пять цифр после запятой то пишу F:5

// Напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1, 4.


// void findQuarters(int a)
// {
//     int b = 1;
//     while (b <= a)
//     {
//         Console.WriteLine(Math.Pow(b, 2));
//         b++;
//     }
// }

// Console.WriteLine("Введите любое число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// findQuarters(N);
// Console.WriteLine($"Квадраты от 1 до заданного числа: {findQuarters}");

// 2й вариант
// Console.WriteLine("Введите число N: ");
// int N = int.Parse(Console.ReadLine());

// // (от какого значения, до какого значения, с каким шагом)
// for (int i=1; i <= N; i++)
// {
//     Console.WriteLine(i*i);
// }




