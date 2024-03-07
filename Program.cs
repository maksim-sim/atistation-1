Console.Write("Введите количество строк в массиве: ");
int n = int.Parse(Console.ReadLine());
string[] array = new string[n];

Console.WriteLine("введите строки массива:");
for (int i = 0; i < n; i++)
{
    array[i] = Console.ReadLine();
}