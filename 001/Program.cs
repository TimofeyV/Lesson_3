Console.Write("Введите число: ");
string number = Console.ReadLine();
if (number.Length != 5) Console.WriteLine("Введите правильно число");
else
{
    if (number[0] == number[4] && number[1] == number[3]) Console.WriteLine("Ваше число палиндром");
    else Console.WriteLine("Число не является палиндромом");
}
    