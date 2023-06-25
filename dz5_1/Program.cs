//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);

int[] array = GetArray(size);
//Console.WriteLine($"[{String.Join(", ", array)}]");

Console.WriteLine($"В массиве [{String.Join(", ", array)}] -> четных элементов = {GetNumbers(array)}");


//Метод сравнения чисел. Через for, т.к. foreach не любит арифметику
int GetNumbers(int[] array)
{
    int SumEven = 0;
    for (int i = 0; i < size; i++)
    {
        SumEven += array[i]%2==0 ? 1 : 0;
    }
    return SumEven;
}


// Функция заполнения массива
int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(100, 1000);
    }
    return result;
}