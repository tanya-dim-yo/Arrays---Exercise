int n = int.Parse(Console.ReadLine());
int[] firstArray = new int[n];
int[] secondArray = new int[n];

for (int i = 0; i < n; i++)
{
    int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

    if (i % 2 == 0)
    {
        firstArray[i] = numbers[0];
        secondArray[i] = numbers[1];
    }
    else
    {
        firstArray[i] = numbers[1];
        secondArray[i] = numbers[0];
    }
}

for (int i = 0; i < firstArray.Length; i++)
{
    Console.Write(firstArray[i] + " ");
}

Console.WriteLine();

for (int i = 0; i < secondArray.Length; i++)
{
    Console.Write(secondArray[i] + " ");
}