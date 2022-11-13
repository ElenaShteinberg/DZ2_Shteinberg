// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1000 || number <= 99)
{
    Console.WriteLine("Число не соответствует условию");
}
else
{
    int reducedNumber = number / 10;
    int secondNumber = reducedNumber % 10;
    Console.WriteLine("Вторая цифра вашего числа равна " + secondNumber);
}
