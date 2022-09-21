// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Enter a three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
int a = num/100;
int b = num%100;
int c = b/10;
Console.WriteLine($"{c} is the second digit");