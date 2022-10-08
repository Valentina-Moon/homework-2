// Найти расстояние между точками в пространстве 2D/3D
//2d
Console.WriteLine("Введите координаты Xa: ");
double Xa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты Xb: ");
double Xb = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты Ya: ");
double Ya = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты Yb: ");
double Yb = Convert.ToDouble(Console.ReadLine());

double D = Math.Sqrt(Math.Pow(Xb - Xa, 2) + Math.Pow(Yb - Ya, 2));

Console.WriteLine($"Расстояние между двумя точками на плоскости равно {D}");
