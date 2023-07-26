int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
int rotationNumber = int.Parse(Console.ReadLine());

for (int i = 1; i <= rotationNumber; i++)
{
    int firstElement = numbers[0];

    for (int j = 0; j < numbers.Length - 1; j++)
    {
        numbers[j] = numbers[j + 1];
    }

    numbers[numbers.Length - 1] = firstElement;
}

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}