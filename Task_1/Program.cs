//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.Clear();

int GetNumberByUser(string text)
{
    Console.Write(text + "  ");
    return int.Parse(Console.ReadLine());
}

void NumberCounter (int number)
{
    if (number == 0) return;
    Console.Write($" {number}");
    NumberCounter (number - 1);

}   

int number = GetNumberByUser("Введите число больше 0:" );
NumberCounter(number);
