/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

int GetNumber(string message)
{
    int result;

    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число.");
        }
    }
    return result;
}

//метод инициализации массива
int[] InitArray(int dimension)
{
    int[] array = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
    return array;
}

//Метод печати массива
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");

    }
    Console.WriteLine();
}

int ParityCheck(int[] array)
{
    int evenNumbers = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 100 && array[i] <= 1000)
        {
            if (array[i] % 2 == 0)
                evenNumbers++;
        }
    }
    return evenNumbers;
}

int dimension = GetNumber("Введите размерность массива: ");
int[] array = InitArray(dimension);
PrintArray(array);
Console.WriteLine($"Количество четных чисел в массиве {ParityCheck(array)}");
