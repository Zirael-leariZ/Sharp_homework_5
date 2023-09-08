// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] digits = FullArray(4, 1, 99);
Console.WriteLine(string.Join(", ", digits));


int[] FullArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    Random random = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}

int SumOnEvenPosition(int[] sequence)
{
    int sum = 0;
    for(int i = 0; i < sequence.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum = sum + sequence[i];
        }
    }
    return sum;
}
int[] whatever = digits;
int sum = SumOnEvenPosition(whatever);
Console.WriteLine(sum);