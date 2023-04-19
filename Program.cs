using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Random rnd = new Random();
int[] array1 = new int[rnd.Next(5, 10)];
int[] array2 = new int[rnd.Next(5, 10)];
int[] array3 = new int[rnd.Next(5, 10)];

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
Console.WriteLine("\nМасив 3:");
for (int i = 0; i < array3.Length; i++)
{
    array3[i] = rnd.Next(1, 101);
    Console.Write($"{array3[i]} ");
}
Console.WriteLine();
Console.WriteLine();


int[] resultArray = uniteArrays(array1, array2, array3);

Console.WriteLine("Результуючий масив:");
for (int i = 0; i < resultArray.Length; i++)
{
    Console.Write($"{resultArray[i]} ");
}
Console.WriteLine();

int[] uniteArrays(params int[][] arrays)
{
    List<int> tempList = new List<int>();
    for (int i = 0; i < arrays.Length; i++)
    {
        for (int j = 0; j < arrays[i].Length; j++)
        {
            if (arrays[i][j] % 5 != 0 && !tempList.Contains(arrays[i][j]))
            {
                tempList.Add(arrays[i][j]);
            }
        }
    }
    tempList.Sort();
    return tempList.ToArray();
}