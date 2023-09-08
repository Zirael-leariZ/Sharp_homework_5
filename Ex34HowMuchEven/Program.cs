// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int [] array = ThreeDigitArray(4, 100, 999);
Console.Write("Original array: ");
Console.WriteLine(string.Join(", ", array));

int[] ThreeDigitArray(int size, int MinValue, int MaxValue)
{
    int[] consequence = new int [size];
    Random random = new Random();
    for (int i = 0; i < consequence.Length; i++)
    {
        consequence[i] = random.Next(MinValue, MaxValue + 1);
    }
    return consequence;
}

int HowManyEven(int[] array)
{
    int even = 0;
    for(int i=0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            even++;
        }
    }
    
    return even;
}

int result = HowManyEven(array);

Console.WriteLine(result);