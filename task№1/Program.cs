//Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine("Введите число обозначабщее день недели");
string number = Console.ReadLine() ?? "0";
int рабочии = 1;
int выходные = 2;
if (number.ToLower() == "1")
{
    Console.WriteLine("являетсь рабочим днем недели");
}
else if (number.ToLower() == "2")
{
    Console.WriteLine("являетсь выходным днем недели");
}
else
{
     Console.WriteLine("По номеру не выявлено значения дня недели, введите 1 или 2");
}