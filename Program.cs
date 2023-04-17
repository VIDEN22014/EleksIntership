using System.Text;
using System.Text.RegularExpressions;

string filename = "";
string word = "";
string mode = "";

StreamReader? reader = null;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Введіть слово для пошуку:");
word = Console.ReadLine();

Console.WriteLine("Введіть режим роботи: (1 - часткове співпадіння. 2 - повне співпадіння)");
mode = Console.ReadLine();
if (!mode.Equals("1") && !mode.Equals("2"))
{
    Console.WriteLine("Режим введено невірно");
    return;
}

Console.WriteLine("Введіть шлях до файлу:");
filename = Console.ReadLine();

try
{
    reader = new StreamReader(filename);
    string text = reader.ReadToEnd();

    string pattern1 = @""+word+"";
    string pattern2 = @"\b"+word+@"\b";
    RegexOptions options = RegexOptions.Multiline | RegexOptions.IgnoreCase;
    long matchesCount = Regex.Matches(text, (mode.Equals("1") ? pattern1 : pattern2), options).LongCount();

    Console.WriteLine($"Кількість співпадінь = {matchesCount}");
}
catch
{
    Console.WriteLine("Файл не існує");
}
finally
{
    reader?.Close();
}