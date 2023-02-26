// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3 7 22 2 78] -> 76

// double GenArray(double[] array)
// {
 double[] array = new double[8];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 5 - rand.Next(11) + rand.NextDouble();
            }
//                 return array;
// }

void PrintArray(double[] array)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}
double CountElements(double[] array)
{
    double sum = 0;
    double max = array[0];
    double min = array[0];
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

// GenArray(array);
PrintArray(array);

Console.WriteLine(CountElements(array));

