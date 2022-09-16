// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

Console.Write("Введите положительное первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите положительное второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1<num2 || num1 <0 || num2 <0) 
// {
//     Console.WriteLine("Числа должны быть положительными и второе число должно быть меньше первого");
// }
// else 
// {
// int result = num1 % num2;
// if (result == 0)
// {
//     Console.WriteLine($"{num1}, {num2} -> кратно");
// }
// else Console.WriteLine($"{num1}, {num2} -> не кратно, остаток от деления {result}");}


bool Multiple(int num1, int num2)
{
return(num1 % num2)==0;
}
bool result = Multiple(num1, num2);
if (result) {Console.WriteLine($"{num1} кратно {num2}");} 
else Console.WriteLine($"{num1} не кратно {num2} -> остаток от деления {num1 % num2}");
