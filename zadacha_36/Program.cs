// Задача 36: Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечётных/чётных чисел.
int n = new Random().Next(3, 15);
int[] array = new int[n];
Random rnd1 = new Random();
Console.Write("Задан массив: ");
int num_ev = 0;
int num_od = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd1.Next(100, 999);
    Console.Write(array[i] + " ");
    if (array[i] % 2 == 0)
        num_ev = num_ev + 1;
    else num_od = num_od + 1;
}
Console.WriteLine(" ");
Console.Write("Четных чисел: " + num_ev);
Console.Write("   Нечетных чисел: " + num_od);