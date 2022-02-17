// Задача 38: Найти сумму чисел одномерного массива, стоящих на нечётной позиции.
int n = new Random().Next(3, 15);
int[] array = new int[n];
Random rnd1 = new Random();
Console.Write("Задан массив: ");
int sum_od_pos = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd1.Next(0, 999);
    Console.Write(array[i] + " ");
    if (i % 2 == 0)
        sum_od_pos = sum_od_pos + array[i];
}
Console.WriteLine(" ");
Console.Write("Сумма чисел, стоящих на нечётной позиции: " + sum_od_pos);