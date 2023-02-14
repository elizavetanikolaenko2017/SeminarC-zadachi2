/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/
Console.WriteLine("Введите число: ");
int day= Convert.ToInt32(Console.ReadLine());
if (day==1)
{
    System.Console.Write("Понедельник- рабочий день");
}
if (day==2)
{
    System.Console.Write("Вторник - рабочий день.");
}
if (day==3)
{
    System.Console.Write("Среда- середина рабочей недели.");
}
if (day==4)
{
    System.Console.Write("Четверг- рабочий день.");
}
if (day==5)
{
    System.Console.Write("Пятница-конец рабочей недели.");
}
if (day==6)
{
    System.Console.Write("Суббота -выходной! отдыхаем).");
}
if (day==7)
{
    System.Console.Write("Воскресенье- выходной!");
}
