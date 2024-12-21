namespace gra.Classes;
using gra.Interfaces;

public class Warior : IPlayer
{
    public string Name { get; set; }
    public int Position { get; set; }
    public int Score { get; set; }

    public Warior(string name)
    {
        Name = name;
        Position = 0;
        Score = 0;
    }
    public void Rusz()
    {
        Random r = new Random();
        int rInt = r.Next(1, 10);
        Console.WriteLine($"\nWojownik {Name} rzuca kostką. Kostka wylosowała: {rInt}");

        Position += rInt;
        Score += rInt; //pozycja = punkty
        
        Console.WriteLine($"Gracz: {Name} znajdje się na pozycji: {Position}");
    }
    
    public void Punkty()
    {
        Console.WriteLine($"Gracz {Name} ma {Score} punktów");
    }
}
