int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

bool noEqualSums = true;

for (int i = 0; i < numbers.Length; i++)
{
    int leftSum = 0;
    int rightSum = 0;

    if (numbers.Length == 1)
    {
        Console.WriteLine(i);
        noEqualSums = false;
        break;
    }

    for (int l = i - 1; l >= 0; l-- )
    {
        leftSum += numbers[l];
    }

    for (int r = i + 1; r < numbers.Length; r++ )
    {

        rightSum += numbers[r];
    }


    if (leftSum == rightSum)
    {
        Console.WriteLine(i);
        noEqualSums = false;
    }
}

if (noEqualSums)
{
    Console.WriteLine("no");
}