// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] array = new string[] { "task", "12%", "all", "v3*15", "at" };

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
void Сonvert(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    { 
        string element = arr[i];
        if (element.Length <= 3)
        {
            arr[i] = element;
        }
        else arr[i] = string.Empty;
    }
}
Console.Write("Исходный массив: ");
PrintArray(array);
Console.WriteLine();
Сonvert(array);
Console.Write("Преобразованный массив: ");
PrintArray(array);