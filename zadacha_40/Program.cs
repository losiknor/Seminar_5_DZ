// Задача 40: В указанном массиве вещественных чисел найти разницу между максимальным и минимальным элементами.
int n = new Random().Next(3, 15);
double[] array = new double[n];
Random rnd1 = new Random();
Console.Write("Задан массив: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd1.NextDouble() * 100;
    Console.Write(array[i] + " ");
}
double max = array[0];
double min = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (array[i] > max)
        max = array[i];
    if (array[i] < min)
        min = array[i];
}
Console.WriteLine(" ");
Console.Write("Разница между максимальным и минимальным элементами: " + (max - min));