/* **Задача 33:** Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да */

using static System.Console;
Clear();

int[] array = GetArray(8);
WriteLine($"{String.Join(" ", array)}");
Write("Введите число ");
int number = int.Parse(ReadLine());

bool result = FindElement(array,number);
WriteLine($"Присутствует ли заданное число в массиве? {result}");
bool FindElement(int[] mass, int element)
{
for (int i = 0; i < mass.Length; i++)
{
    if(mass[i] == element)
    {
        return true;
    }
  
}
return false;
}

int[] GetArray(int L)
{
    int[] result = new int[L];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(-9, 10);
    }

    return result;
}
