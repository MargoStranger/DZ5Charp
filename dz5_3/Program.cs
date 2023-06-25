//Задача 38: Задайте массив целых двухзначных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[22, 42, 15, 77, 65] => 77 - 15 = 62**

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);

int[] array = GetArray(size);
//Console.WriteLine($"Разница между максимальным и минимальным элементом в массиве [{String.Join(", ", array)}] = {GetDifference(array)}");

int Max = GetMax(array);
int Min = GetMin(array);
int Difference = Max - Min;

Console.WriteLine($"Разница между максимальным и минимальным элементом в массиве [{String.Join(", ", array)}] = {Max} - {Min} = {Difference}");

//Метод нахождения максимального элемента массива
int GetMax(int[] array)
{
    int Max = array[0];
    foreach(int el in array)
    {
        Max = el > Max ? el : Max;
    }
    return Max;
}

//Метод нахождения минимального элемента массива
int GetMin(int[] array)
{
    int Min = array[0];
    foreach(int el in array)
    {
        Min = el < Min ? el : Min;
    }
    return Min;
}

// Функция заполнения массива
int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(10, 100);
    }
    return result;
}