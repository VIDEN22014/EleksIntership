using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Random rnd = new Random();
int[] array1 = new int[rnd.Next(5, 10)];
int[] array2 = new int[rnd.Next(5, 10)];

Console.WriteLine("Масив 1:");

for (int i = 0; i < array1.Length; i++)
{
    array1[i] = rnd.Next(1, 101);
    Console.Write($"{array1[i]} ");
}

Console.WriteLine("\nМасив 2:");
for (int i = 0; i < array2.Length; i++)
{
    array2[i] = rnd.Next(1, 101);
    Console.Write($"{array2[i]} ");
}
Console.WriteLine();
Console.WriteLine();

var tempArray = array1.Union(array2).ToArray();

int[] resultArray = new int[0];

for (int i = 0; i < tempArray.Length; i++)
{
    if (tempArray[i] % 5 != 0)
    {
        Array.Resize(ref resultArray, resultArray.Length + 1);
        resultArray[resultArray.Length - 1] = tempArray[i];
    }
}

Array.Sort(resultArray);

Console.WriteLine("Результуючий масив:");
for (int i = 0; i < resultArray.Length; i++)
{
    Console.Write($"{resultArray[i]} ");
}
Console.WriteLine();