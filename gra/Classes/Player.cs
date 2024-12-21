using gra.Interfaces;

namespace gra.Classes;

public class Player : IPlayer
{
    public string Name { get; set; }
    public int Position { get; set; }
    public int Score { get; set; }

    public virtual void Rusz()
    {
        Random r = new Random();
        int rInt = r.Next(0, 6);
        Console.WriteLine($"\nkostka wylosowała: {rInt}");

        Position += rInt;
        Score += rInt; //pozycja = punkty

        Console.WriteLine($"Gracz: {Name} znajdje się na pozycji: {Position}");

    }

    public void Punkty()
    {
        Console.WriteLine($"Gracz {Name} ma {Score} punktów");
    }

    public Player(string name, int position = 0, int score = 0)
    {
        Name = name;
        Position = position;
        Score = score;
    }
}