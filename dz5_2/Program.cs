//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных ИНДЕКСАХ.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);

int[] array = GetArray(size);
Console.WriteLine($"Сумму элементов, стоящих на нечётных индексах в массиве [{String.Join(", ", array)}] = {GetSumm(array)}");


//Метод поиска суммы элементов, стоящих на нечётных индексах
int GetSumm(int[] array)
{
    int Summ = 0;
    for(int i = 0; i<size; i++)
    {
        Summ += i%2!=0 ? array[i] : 0;
    }
    return Summ;
}




// Функция заполнения массива
int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(-100, 101);
    }
    return result;
}