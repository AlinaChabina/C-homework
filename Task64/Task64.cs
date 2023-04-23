// Task 64
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.Write($"N = {N} -> ");
Console.WriteLine(PrintNumbers(N,1));

string PrintNumbers (int start, int end)
{
    if (start == end) return Convert.ToString(start);
    return (start + ", " + PrintNumbers(start - 1, end));
}

