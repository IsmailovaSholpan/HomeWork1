// Напишите программу, которая выводит случайное число трехзначное число 
// и удаляет вторую цифру числа.

int number = new Random().Next(100, 1000);

int Digit(int num)
{
int firstDigit = (number / 100 )* 10;
int secondDigit = number % 10;
return(firstDigit + secondDigit);
}
int result = Digit(number);
Console.WriteLine($"{number}->{Digit(number)}");

