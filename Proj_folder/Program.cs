// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.WriteLine("Введите длину массива");
int n = Convert.ToInt32(Console.ReadLine());
string[] newarray = new string[n];
FillArray(newarray);
Console.WriteLine("Сгенерированный массив:");
PrintArray(newarray);
Console.WriteLine("Массив после фильтрации:");
PrintArray(FilterArray(newarray));

void FillArray(string?[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите элемент №{i + 1}: ");
        array[i] = Console.ReadLine();
    }
}
void PrintArray(string[] array1)
{
    Console.Write("[");
    for (int i = 0; i < array1.Length - 1; i++)
    {
        Console.Write($"{array1[i]}, ");
    }
    Console.Write($"{array1[array1.Length - 1]}]");
    Console.WriteLine();
}
string[] FilterArray(string[] array2)
{
    string[] result = new string[array2.Length];
    int count = 0;
    for (int i = 0; i < array2.Length; i++)
    {
        if (array2[i].Length <= 3)
        {
            result[count] = array2[i];
            count += 1;
        }
    }
    Array.Resize(ref result, count);
    return result;
}