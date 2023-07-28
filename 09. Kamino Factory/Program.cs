int dnaLength = int.Parse(Console.ReadLine());
string input = Console.ReadLine();
int[] bestDNA = new int[dnaLength];
int length = 0;
int index = 0;
int sum = 0;
int sample = 0;
int bestSample = 0;

while (input != "Clone them!")
{
    int[] currentDNA = input.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

    sample++;
    int currentSum = 0;

    for (int i = 0; i < currentDNA.Length; i++)
    {
        if (currentDNA[i] == 1)
        {
            currentSum++;
        }
    }

    int currentLength = 0;
    int currentIndex = 0;

    for (int i = 0; i < currentDNA.Length; i++)
    {
        if (currentDNA[i] == 1)
        {
            currentLength++;

            if (currentLength == 1)
            {
                currentIndex = i;
            }

            if (currentLength > length || currentLength == length && (currentIndex < index || currentSum > sum))
            {
                length = currentLength;
                index = currentIndex;
                bestSample = sample;
                bestDNA = currentDNA;
                sum = currentSum;
            }
        }
        else
        {
            currentIndex = 0;
            currentLength = 0;
        }
    }

    input = Console.ReadLine();
}

if (bestSample == 0)
{
    bestSample = 1;
}

Console.WriteLine($"Best DNA sample {bestSample} with sum: {sum}.");
Console.WriteLine(string.Join(" ", bestDNA));