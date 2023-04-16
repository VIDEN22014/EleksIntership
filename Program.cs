using System.Text;

int index = 0;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Введіть індекс рядка Паскаля:");
index = Convert.ToInt32(Console.ReadLine());

int []pascalRow = new int[index+1];
pascalRow[0] = 1;
pascalRow[pascalRow.Length - 1] = 1;

Console.WriteLine($"{index} - ий рядок Паскаля:");
for (int i = 1; i < pascalRow.Length-1; i++) {
    pascalRow[i] = combinatorial_number(i, index);
}

for (int i = 0; i < pascalRow.Length; i++)
{
    Console.Write($"{pascalRow[i]} ");
}
Console.WriteLine();

int combinatorial_number(int k,int n)
{
    int result = (factorial(n)) / (factorial(k) * factorial(n - k));
    return result;
}

int factorial(int number)
{
    if (number == 1)
        return 1;
    else
        return number * factorial(number - 1);
}