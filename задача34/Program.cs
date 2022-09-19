int size = 4;
int [] array = new int [size];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100);//[0,999]
    Console.Write(array[i] + "\t");
    if (array[i] %2 == 0)
    count++;
   
}
Console.WriteLine($"{"\n"} количество четных чисел: {count}");
