/*// Задача 2
Console.WriteLine("Введите координату Х точки1: ");
int xa = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y точки1: ");
int ya = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Z точки1: ");
int za = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Х точки2: ");
int xb = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y точки2: ");
int yb = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Z точки2: ");
int zb = int.Parse(Console.ReadLine()!);
double res = Math.Sqrt(Math.Pow(xb - xa, 3) + Math.Pow(yb - ya, 3) + Math.Pow(zb - za, 3));
Console.WriteLine($"Расстояние между точками: {res:f3}");/*/



/*// Задача 3 
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
for (int i=1; i<=n; i++)
{
    Console.Write($"{Math.Pow (i,3)}");
}/*/

// Задача 1
Console.WriteLine("Является ли число палиндромом");
Console.Write("Введите число: ");
string? number = Console.ReadLine();

void CheckingNumber(string number)
{
    if (number[0]==number[4] || number[1]==number[3])
    {
    Console.WriteLine($"Ваше число: {number} - палиндром.");
    }
    else Console.WriteLine($"Ваше число: {number} - Не палиндром.");
}
if (number!.Length == 5)
{
    CheckingNumber(number);
}
else Console.WriteLine($"Введи правильное число");