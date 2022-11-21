// Задача 19
// Напишите программу, которая 
// 1. принимает на вход пятизначное число и 
// 2.проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да

int fiveDigitNumber = -1;

while (fiveDigitNumber < 10000 || fiveDigitNumber > 99999)
{
    Console.WriteLine("Пользователь введите пятизначное число: ");
    fiveDigitNumber = Convert.ToInt32(Console.ReadLine());
    if (fiveDigitNumber < 10000 || fiveDigitNumber > 99999) Console.WriteLine("Пожалуйста введите другое число!");
}

int FiveDigitNumber(int value)
{
    int firstDigitNumber = value / 10000;
    int secondDigitNumber = value % 10000 / 1000;
    int thirdigitNumber = value % 10000 % 1000 / 100;
    int fourthDigitNumber = value % 10000 % 1000 % 100 / 10;
    int fifthDigitNumber = value % 10;
    return fifthDigitNumber * 10000 + fourthDigitNumber * 1000 + thirdigitNumber * 100 + secondDigitNumber * 10 + firstDigitNumber;
}
int result = FiveDigitNumber(fiveDigitNumber);
Console.WriteLine(result == fiveDigitNumber ? $"Число {result} является палиндромом числа {fiveDigitNumber}." :
$"Число {result} не является палиндромом числа {fiveDigitNumber}, попробуйте другое число.");
