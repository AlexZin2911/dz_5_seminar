// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2

Console.Write("Введите число, обозначающее количество элементов в массиве: ");
int count1 = int.Parse(Console.ReadLine()!);

int[] array = new int[count1];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
}

Console.WriteLine($"[{string.Join(", ", array)}]");

int Count2 = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        Count2++;
    }
}
Console.WriteLine($"Четных элементов в массиве -> {Count2}");
Console.WriteLine();
