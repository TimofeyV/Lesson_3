// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Coordinate(string coorName, string pointName) // Фунцкия чтобы считывать координаты
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}


double segment(double x1, double y1, double z1, double x2, double y2, double z2) // Функция для вычисления длины отрезка
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
}

int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");

Console.WriteLine("Ответ:");
Console.WriteLine($"Длина отрезка {Math.Round(segment(x1, y1, z1, x2, y2, z2), 2)}");
