/*Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
*/

Console.Clear();
int numberFromUser1 = GetNumberFromUser("Введите число: ", "Ошибка ввода");
int numberFromUser2 = GetNumberFromUser("Введите число: ", "Ошибка ввода");



int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
            return number;
        Console.WriteLine(errorMessage);
    }
}

int SumFor(int a, int b)
{
    if (a <= b) return a + SumFor(a + 1, b);
    return 0;
}

Console.WriteLine(SumFor(numberFromUser1, numberFromUser2));
