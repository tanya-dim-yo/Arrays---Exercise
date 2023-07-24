int wagons = int.Parse(Console.ReadLine());
int[] train = new int[wagons];
int totalPassengersNumber = 0;

for (int i = 0; i < train.Length; i++)
{
    train[i] = int.Parse(Console.ReadLine());
    totalPassengersNumber += train[i];
}

for (int i = 0; i < train.Length; i++)
{
    Console.Write($"{train[i]} ");
}

Console.WriteLine();
Console.WriteLine(totalPassengersNumber);