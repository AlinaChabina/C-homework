// Task 68
Console.Write("Введите неотрицательное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите неотрицательное число n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"m = {m} и n = {n} -> ");
Console.WriteLine(Akkerman(m,n));

int Akkerman (int M, int N)
{
    if (M == 0) return N + 1;
    else if (N == 0) return Akkerman(M-1,1);
    return Akkerman(M-1, Akkerman(M, N-1));
}
