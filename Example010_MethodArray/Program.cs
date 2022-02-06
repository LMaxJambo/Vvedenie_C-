int[] array = { 16, 29, 37, 44, 15, 26, 75, 81 };

int n = array.Length;
int find = 15;
int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
    }
    index = index++;
}