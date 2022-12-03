// Задача 44: Не используя рекурсию, 
// выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


int[] Fibonacci(int numN, int num1, int num2)
{
    int[] array = new int[numN];
    array[0] = num1;
    array[1] = num2;
    for (int i = 2; i < numN; i++)
    {
        array[i] = array[i - 2] + array[i - 1];
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int[] fibonacci = Fibonacci(7, 0, 1);
PrintArray(fibonacci);
