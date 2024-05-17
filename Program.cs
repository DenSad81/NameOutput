using System;

class Program
{
    static void Main(string[] args) {
        string character;
        int quantityAddictionalCharacter = 2;
        string name;
        int nameLenght;

        Console.Write("Выберете символ: ");
        character = Console.ReadLine();
        Console.Write("Выберете Имя: ");
        name = Console.ReadLine();
        nameLenght = name.Length;

        for (int i = 0; i < nameLenght + quantityAddictionalCharacter; i++)
            Console.Write(character);

        Console.WriteLine();
        Console.WriteLine(character + name + character);

        for (int i = 0; i < nameLenght + quantityAddictionalCharacter; i++)
            Console.Write(character);
    }
}
