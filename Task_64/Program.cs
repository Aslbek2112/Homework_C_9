/*Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
*/

Console.Clear();
int numberFromUser = GetNumberFromUser("Введите число: ", "Ошибка ввода");

void PoserRec(int a)
{
    if (a > 0)
    {
        Console.Write($"{a}, ");
        PoserRec(a - 1);
    }
}

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int number))
            return number;
        Console.WriteLine(errorMessage);
    }
}

PoserRec(numberFromUser);
