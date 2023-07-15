//Функция ввода
int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

//функция подсчёта
int SumNumbers(int M, int N)
{
    if (M == N) return M;
    return N + SumNumbers(M, N - 1);
}



int FuncAckerman(int M, int N)
{
    if (M == 0) return N + 1;
    else if (N == 0) return FuncAckerman(M - 1, 1);
    else
    {
        return FuncAckerman(M - 1, FuncAckerman(M, N - 1));
    }
}

void Main()
{
    point:
    Console.WriteLine("выберете номер задания:66 или 68");
    string task = Console.ReadLine();
    if (task!="66" & task!="68")
    {
    Console.WriteLine("введите корректное значение");
    goto point;
    }

switch (task)
{
case "66":
{
    int N = ReadInt("Введите начальное число M: ");
    int M = ReadInt("Введите конечное число N: ");

    if (M < N)
    {
        SumNumbers(M, N);
        System.Console.WriteLine($"Сумма всех натуральных чисел в заданном диапазоне равна: {SumNumbers(M, N)}");
    }
    else
    {
        SumNumbers(N, M);
        System.Console.WriteLine($"Сумма всех натуральных чисел в заданном диапазоне равна: {SumNumbers(N, M)}");
    }
    break;
}
case "68":
{
    int M = ReadInt("Введите начальное число M: ");
    int N = ReadInt("Введите конечное число N: ");
    if (M < 0 || N < 0)
    {
        System.Console.WriteLine("Вы ввели некорректные числа.");
        return;
    }
    System.Console.WriteLine($"Число, определённое функцией Аккермана по введённым параметрам равно: {FuncAckerman(M, N)}");
break;
}
}
}

Main();

