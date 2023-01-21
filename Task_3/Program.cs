//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29


Console.Clear();

double GetNumberByUser(string text)
{
    Console.Write(text + "  ");
    return double.Parse(Console.ReadLine());
}



double A(double m, double n)
{
    if (m == 0)
        return n + 1;

    else if (m > 0 && n == 0)
        return A(m - 1, 1);
    else return A(m - 1, A(m, n -1));
    
}

double m = GetNumberByUser("Введите первое не отрицательное число:");
double n = GetNumberByUser("Введите второе не отрицательное число:");
Console.WriteLine();
double res = A(m, n);
Console.WriteLine($"Результат вычислений равен: {res};");
Console.WriteLine();