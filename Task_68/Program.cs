/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
*/

Console.Clear();
int numberFromUser1 = GetNumberFromUser("Введите число: ", "Ошибка ввода");
int numberFromUser2 = GetNumberFromUser("Введите число: ", "Ошибка ввода");

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int number) && number >= 0)
            return number;
        Console.WriteLine(errorMessage);
    }
}

int Accerman(int a, int b)
{
    if(a == 0)
    {
        return b + 1;
    }
    if(a > 0 && b == 0) 
    {
        return Accerman(a - 1, 1);
    }
    if(a > 0 && b > 0) 
    {
        return Accerman(a - 1, Accerman(a, b - 1));
    }
    return 0;
}

Console.WriteLine(Accerman(numberFromUser1, numberFromUser2));