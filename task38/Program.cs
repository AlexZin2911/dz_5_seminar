// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3 7 22 2 78] -> 76

Console.WriteLine();
Console.Write("Введите число, обозначающее количество элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];

FillArrayRandomNumbers(numbers);
Console.WriteLine("массив: ");

PrintArray(numbers);

double minimum = Int32.MaxValue;
double maximum = Int32.MinValue;

for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] > maximum)
    {
        maximum = numbers[z];
    }
    if (numbers[z] < minimum)
    {
        minimum = numbers[z];
    }
}

Console.WriteLine($"Всего {numbers.Length} чисел. Максимальное значение = {maximum}, минимальное значение = {minimum}");
Console.WriteLine($"Разница между максимальным и минимальным значениями = {maximum - minimum}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
    }
}

void PrintArray(double[] numbers)
{
    Console.Write("[");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}