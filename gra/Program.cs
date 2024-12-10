using gra.Classes;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj liczbe rzutow kostka: ");
        int turCount = int.Parse(Console.ReadLine());
        
        Console.Write("Podaj nazwę gracza: ");
        string playerName = Console.ReadLine();
        
        // Wybór typu gracza
        Console.Write("Wybierz typ gracza (1 - Zwykły, 2 - Wojownik): ");
        int typGracza = int.Parse(Console.ReadLine());
        
        Player gracz = new Player("gracz1", 0, 0);
        
        // Wybór odpowiedniego typu gracza
        if (typGracza == 1)
        {
            gracz = new Player(playerName);
        }
        else
        {
            gracz = new Warior(playerName);
        }
        
        for (int i = 0; i < turCount; i++) //15 to ilosc pozycji na planszy
        {
            Console.WriteLine($"\nTura {i+1}:");
            gracz.Punkty();
            
            Console.WriteLine("Naciśnij Enter, aby rzucić kostką...");
            Console.ReadKey();
            
            gracz.Rusz();
            Board.SprawdzNagrode(gracz);


        }
        Console.WriteLine("gra sie zakonczyla");
    }
}

