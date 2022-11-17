// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых <= 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


string[] array1 = new string[] { "hello", "2", "world", ";-)" };
string[] array2 = new string[Size(array1)];


void PrintArray(string[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int Size(string[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            count++;
        }
    }

    return count;
}

void DiffArr(string[] array1, string[] array2)
{
    for (int i = 0, j = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[j] = array1[i];
            j++;
        }
    }
}

PrintArray(array1);
DiffArr(array1, array2);
PrintArray(array2);




