Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] arr1 = new string[size];
string[] arr2 = new string[arr1.Length];

void InitArray(string[] array, int size)
{
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1} эллемент массива: ");
        array[i] =  Convert.ToString(Console.ReadLine());
    }
}

void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
    if (count == 0)  array2[count] = "В пердидущем массиве нет значений менше или равных 3 (по длинне)";

}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

InitArray(arr1,size);
Console.WriteLine();
Console.WriteLine($"Ваш массив:");
PrintArray(arr1);
Console.WriteLine();
SecondArrayWithIF(arr1, arr2);
Console.WriteLine($"Значения из пердидущего массива, которые меньше или равны 3 (по длинне):");
PrintArray(arr2);