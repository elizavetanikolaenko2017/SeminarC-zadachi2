/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Random rand = new Random();
int randNumber = rand.Next(100,1000);
int leftNumber = randNumber/10;
int rightNumber = randNumber%10;
if (randNumber>99 && randNumber< 1000)
{
   Console.WriteLine(leftNumber); 
}
else
{
    Console.WriteLine("Введено неправильное число.");
}