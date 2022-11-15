// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

double[] array = new double [5];
Random random = new Random();

double diff = 0;


for (int i = 0; i < array.Length; i++)
{
        array [i] = random.NextDouble() * 10;
        Console.WriteLine("{0,2:F1}", array[i]);
}



for (int i = 0; i < array.Length; i++)
{

    double max = array[i];
    double min = array[i];
    
    if(array[i]>max)
{    max = array[i];   }


    else if(array[i]<min)
{    min = array[i];   }
diff = max-min;
Console.WriteLine(diff);
}
