// See Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

const int Size = 10;

int[] randomArray = CreatRandomArray(Size);

PrintArray(randomArray);

int findSumOdd = FindSumOdd(randomArray);

Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна {findSumOdd}");



int[] CreatRandomArray(int size)
{
    int[] numbers = new int[size];

    for (int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(1, 10);

    }
    return numbers;
}

void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");

}

int FindSumOdd(int[] array)
{
    int sumOdd = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sumOdd = sumOdd + array[i];

    }
    return sumOdd;
}