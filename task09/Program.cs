// Напишите программу, которая выводит случайное число из отрезка [10; 99] 
// и показывает наибольшую цифру числа.

int number = new Random().Next(10, 100);
int FirstDigit = number / 10;
int SecondDigit = number % 10;

// if (FirstDigit > SecondDigit) Console.Write($"Наибольшая цифра числа {number} -> {FirstDigit}");
// else Console.Write($"Наибольшая цифра числа {number} -> {SecondDigit}");

int max = FirstDigit > SecondDigit ? FirstDigit : SecondDigit;
Console.Write($"Наибольшая цифра числа {number} -> {max}");