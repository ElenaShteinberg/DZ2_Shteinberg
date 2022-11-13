// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1 && number <= 5)
    Console.WriteLine("Рабочий день");
if (number > 5 && number <= 7)
    Console.WriteLine("Выходной");
if (number > 7 || number <= 0)
    Console.WriteLine("Введено неверное значение");