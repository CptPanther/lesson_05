using static System.Console;

internal class Program
{
    static void Main()
    {
        WriteLine("Введите предложение:");
        WriteLine(InvertText(ReadLine()));
        ReadKey(true);
    }

    //Создает список
    static string[] GetList(string text)
    {
        return text.Split(' ');
    }

    //Инвертирует текст
    static string InvertText(string text)
    {
        WriteLine("\nИнвертированный текст:");
        string[] list = GetList(text);
        string invText = "";

        for (int item=list.Length-1; item>=0; item--)
            invText += list[item]+" ";

        return invText;
    }
}
