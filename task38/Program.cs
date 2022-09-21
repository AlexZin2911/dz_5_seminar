// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3 7 22 2 78] -> 76

Console.WriteLine();
Console.Write("Введите число, обозначающее количество элементов в массиве: ");
int count = int.Parse(Console.ReadLine()!);
Double [] array = new Double[count];

Double Maximum = array[0];
Double Minimum = array[0];

for (int i = 0; i < array.Length; i++) 
{
    array[i] = Math.Round(new Random().NextDouble() * 100, 2, MidpointRounding.AwayFromZero);
}

foreach (var value in array)
{
    if (value < Minimum)
    {
        Minimum = value;
    }
    if (value > Maximum)
    {
        Maximum = value;
    }
}

Console.WriteLine($"[{string.Join(" ; ", array)}]");
Console.WriteLine();
Console.WriteLine($"Максимальный элемент -> {Maximum}");
Console.WriteLine();
Console.WriteLine($"Минимальный элемент -> {Minimum}");
Console.WriteLine();
Console.WriteLine($"Разница между максимумом и минимумом {Maximum} - {Minimum} = {Maximum - Minimum}");
Console.WriteLine();
