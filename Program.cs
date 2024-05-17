using System;

class Program
{
    static void Main(string[] args) {
        char symbol;
        string name;
        string frameName;
        string frameBorder = "";

        Console.Write("Выберете символ: ");
        symbol = Console.ReadKey(true).KeyChar;
        Console.WriteLine(symbol);
        Console.Write("Выберете Имя: ");
        name = Console.ReadLine();

        frameName = symbol + name + symbol;

        for (int i = 0; i < frameName.Length; i++)
            frameBorder += symbol;

        Console.WriteLine(frameBorder);
        Console.WriteLine(frameName);
        Console.WriteLine(frameBorder);
    }
}
