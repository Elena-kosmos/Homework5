int [] array = {3,7,23,12};
int sum =0;
for (int i = 1; i < array.Length; i+=2)
{
    sum+=array[i];
}
Console.WriteLine($"сумма позиций нечетных чисел: {sum}");