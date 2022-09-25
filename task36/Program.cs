// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях. [3, 7, 23, 12] -> 19, [-4, -6, 89, 6] -> 0

Console.Write("Введите число, обозначающее количество элементов в массиве: ");
int count = int.Parse(Console.ReadLine()!);

int[] array = new int[count]; 

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-1000, 1001);
}

Console.WriteLine($"[{string.Join(", ", array)}]");


int Difference = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0)
    {
        Difference += array[i];
    }
}
Console.WriteLine($"Сумма элементов, находящихся на нечетных позициях -> {Difference}");
Console.WriteLine();