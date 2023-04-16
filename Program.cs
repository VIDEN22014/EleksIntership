using System.Text;

int index = 0;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Введіть індекс числа Фібоначчі:");
index = Convert.ToInt32(Console.ReadLine());

int fibNum = fib(index);

Console.WriteLine($"{index} - те число Фібоначчі = {fibNum}");


int fib(int n)
{
    if (n <= 1)
    {
        return n;
    }

    return fib(n - 1) + fib(n - 2);
}
