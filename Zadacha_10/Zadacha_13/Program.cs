/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number>100 && number<100000)
{
    int x= number%100;
    System.Console.Write(x);
}
else
{
    System.Console.Write("Третьей цифры нет");
}
