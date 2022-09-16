// Напишите программу, которая принимает на вход 2 числа и проверяет, 
// является ли одно число квадратом другого.


Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool SquareNum(int num1, int num2)
{
    return (num1 * num1 == num2 || num2 * num2 == num1);
}
bool result = SquareNum(num1, num2);
if (result) { Console.WriteLine($"{num1}, {num2} -> да"); }
else Console.WriteLine($"{num1}, {num2} -> нет"); 