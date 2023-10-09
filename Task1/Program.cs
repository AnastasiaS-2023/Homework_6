Console.Write("Введите элементы массива через пробел: ");
int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int count = 0;
for (int i = 0; i < array.Length; i++)
{    
    if(array[i] > 0)
        count ++;
}
Console.WriteLine($"Количество элементов > 0: {count}");