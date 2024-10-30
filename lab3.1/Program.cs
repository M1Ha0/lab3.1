try
{
    Console.WriteLine("Введите n");
    int n = int.Parse(Console.ReadLine());
    double sum = 0;
    for (int k = 1; k <= n; k++)
    {
        if (k == 0) continue;
        int P = 1;
        for (int j = 1; j <= k; j++) P *= j;
        double result = (Math.Pow(k - 4, 3) * (k + 7))/P;
        if (result != 0 && result != double.PositiveInfinity && result != double.NegativeInfinity)
        {
            sum += result;
        }
    }
    Console.WriteLine($"Сумма ряда: {sum}");
}
catch
{
    Console.WriteLine("Введите корректные данные");
}
