using gra.Classes;
using gra.Interfaces;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj liczbe tur: ");
        int turCount = int.Parse(Console.ReadLine());

        Console.Write("Podaj nazwę gracza 1: ");
        string playerName1 = Console.ReadLine();

        Console.Write("Podaj nazwę gracza 2: ");
        string playerName2 = Console.ReadLine();

        // Wybór typu gracza
        Console.Write("Wybierz typ gracza 1: (1 - Zwykły, 2 - Wojownik): ");
        int typGracza1 = int.Parse(Console.ReadLine());

        Console.Write("Wybierz typ gracza 2: (1 - Zwykły, 2 - Wojownik): ");
        int typGracza2 = int.Parse(Console.ReadLine());

        // Deklaracja graczy jako IPlayer
        IPlayer gracz1, gracz2;

        // Wybór odpowiedniego typu gracza
        if (typGracza1 == 1)
        {
            gracz1 = new Player(playerName1);
        }
        else
        {
            gracz1 = new Warior(playerName1);
        }


        if (typGracza2 == 1)
        {
            gracz2 = new Player(playerName2);
        }
        else
        {
            gracz2 = new Warior(playerName2);
        }


        for (int i = 0; i < turCount; i++)
        {
            //tura gracza 1
            Console.WriteLine($"\nTura {i + 1} - Gracz 1 ({gracz1.Name}):");
            gracz1.Punkty();
            Console.WriteLine("Naciśnij Enter, aby rzucić kostką...");
            Console.ReadKey();
            gracz1.Rusz();
            Board.SprawdzNagrode(gracz1);

            //tura gracza 2
            Console.WriteLine($"\nTura {i + 1} - Gracz 2 ({gracz2.Name}):");
            gracz2.Punkty();
            Console.WriteLine("Naciśnij Enter, aby rzucić kostką...");
            Console.ReadKey();
            gracz2.Rusz();
            Board.SprawdzNagrode(gracz2);

        }

        Console.WriteLine("\ngra sie zakonczyla!");

        if (gracz1.Score > gracz2.Score)
        {
            Console.WriteLine($"Zwycięzcą jest {gracz1.Name} z {gracz1.Score} punktami!. {gracz1.Name} miał {(gracz1.Score - gracz2.Score)-1} punktów przewagi!.");
        }
        else if (gracz2.Score > gracz1.Score)
        {
            Console.WriteLine($"Zwycięzcą jest {gracz2.Name} z {gracz2.Score} punktami!. {gracz2.Name} miał {(gracz2.Score - gracz1.Score)-1} punktów przewagi!.");
        }
        else
        {
            Console.WriteLine("Gra zakończyła się remisem!");
        }
    }
}

