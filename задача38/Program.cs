int [] array = {3,7,22,2,78};
int Max = array [0];
int Min = array [0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > Max) Max = array[i] ;
    if (array[i] < Min) Min =array[i] ;
}

Console.WriteLine($"максимальное число:{Max}");
Console.WriteLine($"минимальное число: {Min}");
Console.WriteLine($"{"\n"} разница между максимальным и минимальным числом: {Max - Min}");
