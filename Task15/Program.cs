// Задача 15: Напишите программу, которая 
// 1. принимает на вход цифру, обозначающую день недели, и 
// 2. проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет				



// Console.WriteLine("Пользователь, введите день недели: ");
// int dayWeek = Convert.ToInt32(Console.ReadLine());

// if (dayWeek == 6 || dayWeek == 7) Console.Write("Сегодня выходной, расслабляйтесь...");
// else if (dayWeek < 1 || dayWeek > 7) Console.Write("Введите другое число: от 1 до 7.");
// else Console.Write("Боюсь сегодня вам необходимо пойти на работу.");

Console.WriteLine("Пользователь, введите день недели: ");
int dayWeek = Convert.ToInt32(Console.ReadLine());

int DayOff (int day)
{
    return day;
}
int daysOff = DayOff(dayWeek);
string result = daysOff == 6 || daysOff == 7 ? "Сегодня выходной, отдохните в свое удовольствие." 
: daysOff > 0 && daysOff < 6 ? "Похоже сегодня вам необходимо пойти на работу."
: "Введите другое число: от 1 до 7.";

Console.WriteLine(result);