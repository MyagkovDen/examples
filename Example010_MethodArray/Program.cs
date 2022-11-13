// Имеется однородный массив array  из n элементов, требуется найти элемент массива, равный find

int[] array = { 11, 12, 31, 14, 51, 16, 71, 14 };

int n = array.Length;
int find = 14;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; // чтобы остановить поиск после первого найденного элемента (в случае, если их несколько)
    }
        

    // index = index + 1
    index++;
}
