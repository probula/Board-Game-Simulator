class Player()
{
    public string Name;
    public int Position;
    public int Score;

    public void Rusz()
    {
        Random r = new Random();
        int rInt = r.Next(1, 7);
        Console.WriteLine($"\nkostka wylosowała: {rInt}");

        Position += rInt;
        Score += rInt; //pozycja = punkty
        
        Console.WriteLine($"Gracz: {Name} znajdje się na pozycji: {Position}");
    }
    
    public void Punkty()
    {
        Console.WriteLine($"Gracz {Name} ma {Score} punktów");
    }

    public Player(string name, int position, int score) : this()
    {
        Name = name;
        Position = position;
        Score = score;
    }
}

class Board()
{
    public int Rozmiar = 15;

    public void Nagroda()
    {
        Random r2 = new Random();
        int rInt2 = r2.Next(1, 5);
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        Player gracz = new Player("gracz1", 0, 0);
        for (int i = 0; i < 15; i++) //15 to ilosc pozycji na planszy
        {
            Console.WriteLine($"\nTura {i+1}:");
            gracz.Punkty();

            
            Console.WriteLine("Naciśnij Enter, aby rzucić kostką...");
            Console.ReadKey();
            
            gracz.Rusz();
            
            
        }
        Console.WriteLine("gra sie zakonczyla");
    }
}

