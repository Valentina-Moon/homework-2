// По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("Ведите значение числа A:");
int A = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Ведите значение числа B:");
int B = int.Parse(Console.ReadLine() ?? "0");

int C = B * B;

if (A < C)
{
    Console.WriteLine("первое число не является квадратом второго");
}
else if (A > C)
{
    Console.WriteLine("первое число не является квадратом второго");
}
else
{
    Console.WriteLine("первое число является квадратом второго");
}

