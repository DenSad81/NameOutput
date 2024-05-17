using System;

class Program
{
    static void Main(string[] args) {
        string character;
        string name;
        string frame = "";
        int frameLenght;

        Console.Write("Выберете символ: ");
        character = Console.ReadLine();
        Console.Write("Выберете Имя: ");
        name = Console.ReadLine();

        frameLenght = character.Length + name.Length + character.Length;

        for (int i = 0; i < frameLenght; i++)
            frame += character;

        Console.WriteLine(frame);
        Console.WriteLine(character + name + character);
        Console.WriteLine(frame);
    }
}
