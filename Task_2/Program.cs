/* Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, x = k2 * x + b2; значения b1, k1, b2, k2 задаются пользователем. 
*/ // x = (b2 - b1) / (k1 - k2) - формула пересечения двух прямых

double GetNumber(string msg)
{
    Console.WriteLine(msg);
    double number = double.Parse(Console.ReadLine());
return number;
}

double k1 = GetNumber("Введите число для точки k1: ");
double b1 = GetNumber("Введите число для точки b1: ");
double k2 = GetNumber("Введите число для точки k2: ");
double b2 = GetNumber("Введите число для точки b2: ");

if(k1 == k2)
{
    Console.WriteLine("Прямые не пересекаются");
return;        
}

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"Точка пересечения ({x}, {y})");