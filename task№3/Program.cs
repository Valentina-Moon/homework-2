// Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Введите номер четверти:");
string number = Console.ReadLine() ?? "0";

if (number.ToLower() == "1")
{
    Console.WriteLine("диапозоном для возможных координат в 1 четверти является x > 0 y > 0");
}

else if (number.ToLower() == "2")
{
    Console.WriteLine("диапозоном для возможных координат в 2 четверти является x < 0 y > 0");
}

else if (number.ToLower() == "3")
{
    Console.WriteLine("диапозоном для возможных координат в 3 четверти является x < 0 y < 0");
}

else if (number.ToLower() == "4")
{
    Console.WriteLine("диапозоном для возможных координат в 4 четверти является x > 0 y < 0");
}

else
{
     Console.WriteLine("такой четверти не существует");
}