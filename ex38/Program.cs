// SЗадайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

const int Size = 10;

float[] randomArray = CreatRandomArray(Size);

PrintArray(randomArray);

float findMax = FindMax(randomArray);

float findMin = FindMin(randomArray);

Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {(findMax - findMin)}");



float[] CreatRandomArray(int size)
{
    float[] numbers = new float[size];

    for (int i = 0; i < size; i++)
    {
        numbers[i] = new Random().NextSingle();

    }
    return numbers;
}

void PrintArray(float[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

float FindMax(float[] array)
{
    float max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];

        }
    }
    return max;
}

float FindMin(float[] array)
{
    float min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];

        }
    }
    return min;
}