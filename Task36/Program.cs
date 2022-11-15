// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

int[] arr = new int[7];
int sum = 0;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0,12);
    Console.WriteLine(arr[i]);
}

for (int i = 0; i < arr.Length; i++)
{
    if (i%2!=0)
    {
        sum+=arr[i];
    }
}
Console.WriteLine(sum);