// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] GenArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(leftRange, rightRange + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}
int CountElements(int[] array, int leftRange, int rightRange)
{
    int sum = 0;
    int max = array[0];
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        { max = array[i];}
        else if (array[i] < min)
        { min = array[i];}
    sum = max - min;   
    }
    return sum;
}

var myArray = GenArray(8, 0, 100);
PrintArray(myArray);
Console.WriteLine(CountElements(myArray, 1, 100));







