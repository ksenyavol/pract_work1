// Напишите программу, которая принимает на вход число и выдает, 
// является ли оно четным

Console.WriteLine("Введите число x: ");
int x = Convert.ToInt32(Console.ReadLine());
if ((x % 2) == 0)
{
    Console.WriteLine("четное");
}
else
{
    Console.WriteLine("нечетное");
}
