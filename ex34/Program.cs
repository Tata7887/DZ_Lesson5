// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


const int Size = 10;

int[] randomArray = CreatRandomArray(Size);

PrintArray(randomArray);

int countEven = FindEven(randomArray);

Console.WriteLine ($"Количество четных чисел в массиве равно {countEven}");



int[] CreatRandomArray(int size)
{
    int[] numbers = new int[size];

    for (int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(100, 1000);

    }
    return numbers;
}

void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");

}

int FindEven(int[] array)
{
    int countEven = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            countEven = countEven + 1;

    }
    return countEven;
}