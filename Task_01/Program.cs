using System;
using static System.Console;

internal class Program
{
    static void Main()
    {
        WriteLine("Введите предложение:");
        WriteList(GetList(ReadLine()));
        ReadKey(true);
    }

    //Создает список
    static string[] GetList(string text)
    {
        return text.Split(' ');
    }

    //Выводит список
    static void WriteList(string[] list)
    {
        WriteLine("\nСписок слов: ");
        foreach (string item in list)
            WriteLine(item);
    }
}
