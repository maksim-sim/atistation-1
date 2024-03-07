Console.Write("Введите количество строк в массиве: ");
int n = int.Parse(Console.ReadLine());
string[] array = new string[n];

Console.WriteLine("введите строки массива:");
for (int i = 0; i < n; i++)
{
    array[i] = Console.ReadLine();
}

string[] newarray = FilterStrings(array);

Console.WriteLine("\nНовый массив строк, длина которых меньше или равна 3 символам:");
for (int i = 0; i < newarray.Length; i++)
{
    Console.WriteLine(newarray[i]);
}

static string[] FilterStrings(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }

string[] newarray = new string[count];
int index = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        newarray[index] = array[i];
        index++;
    }
}
return newarray;
}