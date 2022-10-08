// 3D
Console.WriteLine("Введите координаты Xa: ");
double Xa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты Xb: ");
double Xb = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты Ya: ");
double Ya = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты Yb: ");
double Yb = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты Ca: ");
double Ca = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты Cb: ");
double Cb = Convert.ToDouble(Console.ReadLine());


double D = Math.Sqrt(Math.Pow(Xb - Xa, 2) + Math.Pow(Yb - Ya, 2) + Math.Pow(Cb - Ca, 2));

Console.WriteLine($"Расстояние между двумя точками на пространстве равно {D}");
