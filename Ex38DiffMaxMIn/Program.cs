// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

using System.Threading.Tasks.Dataflow;

double[] FullArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Put the {i+1} position");
        double userInput = Convert.ToDouble(Console.ReadLine());
        array[i] = userInput;
    }
    return array;
}

double Difference(double[] array)
{
    int firstPosition = 0;
    double min = array[firstPosition];
    double max = array[firstPosition];
    double residual = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
    }
    residual = max - min;
    return residual;
}

double[] expArray = FullArray(5);
string joinArray = string.Join(", ", expArray);
Console.WriteLine(joinArray);

double diffArray = Difference(expArray);
Console.WriteLine(diffArray);