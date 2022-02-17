// Задача 34: Написать программу для замены элементов массива на противоположные.
int n = new Random().Next(3, 10);
int[] array = new int[n];
Random rnd1 = new Random();
Console.Write("Исходный массив: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd1.Next(-100, 100);
    Console.Write(array[i] + " ");
    array[i] = array[i] * -1;
}
Console.WriteLine(" ");
Console.Write("Массив после обработки: ");
for (int j = 0; j < array.Length; j++)
    Console.Write(array[j] + " ");
