/*Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/


Console.Clear();


int GetNumberByUser(string text)
{
    Console.Write(text + "  ");
    return int.Parse(Console.ReadLine());
}

void GapNumberSum (int number1, int number2, int sum)
{
    if (number1 > number2) 
    {
        Console.WriteLine($"Сумма элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (number1++);
    GapNumberSum(number1, number2, sum);
}

int number1 = GetNumberByUser("Введите число M которое больше 0:" );
int number2 = GetNumberByUser("Введите число N которое больше 0:" );
GapNumberSum(number1, number2, 0);