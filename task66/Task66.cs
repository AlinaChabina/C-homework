// Task 66
Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.Write($"M = {M}; N = {N} -> ");
Console.WriteLine(SumNaturElemets(M,N));

int SumNaturElemets (int first, int last)
{
    if (first == last) return first;
    return first + SumNaturElemets(first + 1, last);
}
