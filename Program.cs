/* Задача 35: Задайте одномерный массив случайных чисел. Найдите количество элементов массива, 
значения которых лежат в отрезке [10,99].
 */


using static System.Console;
Clear();
WriteLine("Введите число ");
int numb = Convert.ToInt32(ReadLine());
int[] mass = GetArray(numb);
WriteLine($"{String.Join(" ",mass)}");
WriteLine($"Количество элементов в отрезке {GetCountNumber(mass,10,99)}");



int[] GetArray(int L)
{
    int[] result = new int[L];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(0, 1000);
    }

    return result;
}

int GetCountNumber(int[] array, int minCount, int maxCount)
{
    int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i]>=minCount && array[i]<=maxCount)
    {
        count+=1;
    }
}

    return count;
}