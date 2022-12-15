/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

double GetNumber(string message)
{
    double result;

    while (true)
    {
        Console.WriteLine(message);
        if (double.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Вы ввели не число: ");
        }
    }
    return result;
}


double[] InitArray(double dimension)
{
    double[] array = new double[(int)dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        array[i] = rnd.NextDouble() * (100);
        array[i] = Math.Round(array[i], 2);
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

(double, double) GetDifference(double[] array)
{
    double min = Int32.MaxValue;
    double max = Int32.MinValue;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return (max, min);
}

double dimension = GetNumber("Введите размерность массива: ");
double[] array = InitArray(dimension);
PrintArray(array);
(double max, double min) = GetDifference(array);
double difference = max - min;
Console.WriteLine($"Разница между {max} и {min} элементом равна = {difference}.");