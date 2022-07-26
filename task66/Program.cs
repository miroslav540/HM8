Console.Clear();
Console.WriteLine("Введите первое число: "); int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите последнее число: "); int N = Convert.ToInt32(Console.ReadLine());
int SumNumbers(int M, int N)
{
    if (M == N) return M;
    return (M + SumNumbers(M + 1, N));
}
Console.WriteLine(SumNumbers(M, N));
