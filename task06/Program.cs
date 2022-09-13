// Напишите программу, которая на вход
// принимает число и выдаёт, является ли число чётным
// (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num % 2;
if (num1 > 0 || num1 < 0)
{
    Console.WriteLine("нет");
}
else 
{ Console.WriteLine("да"); }