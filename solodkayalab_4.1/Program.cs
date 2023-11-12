Random massive = new Random();
const int massiveSize = 30;
int[] max = new int[massiveSize];
for (int i = 0; i < max.Length; i++)
{
    max[i] = massive.Next(0, 100);
    Console.Write(max[i] + " ");
}
Console.WriteLine();
int count = 0;
for (int i = 1; i < massiveSize - 1; ++i)
{
    if (max[i - 1] < max[i] && max[i + 1] < max[i])
    {
        Console.WriteLine($"{max[i - 1]} {max[i]} {max[i + 1]}");
        count++;
    }
}
Console.WriteLine(count);

