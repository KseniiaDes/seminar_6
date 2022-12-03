// Задача 42: Напишите программу, 
// которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


Console.Write("Введите натуральное десятичное число для преобразования его в двоичное: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] ConvertToBinary(int num)
{
    int size = 0;
    int numSize = num;
    while (numSize != 0)
    {
        numSize = numSize / 2;
        size++;
    }

    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[size - 1 - i] = num % 2;
        num = num / 2;
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
    }
}

int[] binary = ConvertToBinary(number);
PrintArray(binary);


// string ConvertToBinary(int num)
// {
//     string result = string.Empty;
//     while (num != 0)
//     {
//         result = num % 2 + result;
//         num = num / 2;
//     }
//     return result;
// }

Console.WriteLine(ConvertToBinary(number));