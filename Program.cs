/* **Задача 32:** Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] */
using static System.Console;
Clear();

int[] array = GetArray(8);
WriteLine($"{String.Join(" ", array)}");

for (int i = 0; i < array.Length; i++)
{
    array[i] *= (-1);
}
WriteLine($"{String.Join(" ", array)}");




int[] GetArray(int L)
{
    int[] result = new int[L];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(-9, 10);
    }

    return result;
}
