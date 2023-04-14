// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
string text = Console.ReadLine();
int number = Convert.ToInt32(text);
int count = 1;

while (count <= number)
{
    Console.Write($"{Math.Pow(count, 3)} ");
    count++;
}
