/* Пользователь с клавиатуры вводит M чисел, посчитайте сколько чисел больше 0 ввел пользователь. 
*/ 

int GetNumber(string msg)
{
    Console.WriteLine(msg);
    int number = int.Parse(Console.ReadLine());
return number;
}

int m = 10;
int count = 0;
for (int i = 0; i < m ; i++)
{
    int number = GetNumber("Введите число: ");

    if (number > 0)
        {
            count++;
        }   
}
Console.WriteLine($"Пользователь ввел {count} положительных чисел");