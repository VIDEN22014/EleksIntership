using System.Text;

string filename = "";

StreamReader? reader = null;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Введіть шлях до файлу:");
filename = Console.ReadLine();

try
{
    reader = new StreamReader(filename);
    string text = reader.ReadToEnd();
    string reversedText = ReverseText(text);

    using (StreamWriter writer = new StreamWriter("out.txt", false, Encoding.UTF8))
    {
        writer.WriteLine(reversedText);
    }
}
catch
{
    Console.WriteLine("Файл не існує");
}
finally
{
    reader?.Close();
}

string ReverseText(string text)
{
    char[] array = text.ToCharArray();
    Array.Reverse(array);
    return new String(array);
}
