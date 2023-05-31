/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number >= 10000 && number <= 99999)
{
    Console.WriteLine("Пятизначное число");
    int firstDigit = number / 10000;
    int secondDigit = (number / 1000) % 10;
    int fourthDigit = (number / 1000) % 10;
    int fifthDigit = number % 10;
    if(firstDigit == fifthDigit && secondDigit == fourthDigit)
    {
        Console.WriteLine($"Число {number} является паллиндромом");
    }
    else
    {
        Console.WriteLine($"Число {number} не является паллиндромом");
    }
}
else
{
    Console.WriteLine("Не пятизначное число");
}