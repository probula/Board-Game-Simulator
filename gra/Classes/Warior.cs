namespace gra.Classes;

public class Warior: Player
{
    public Warior(string name) : base(name) { }
    public override void Rusz()
    {
        Random r = new Random();
        int rInt = r.Next(1, 10);
        Console.WriteLine("$\nWojownik {Name} rzuca kostką. Kostka wylosowała: {rInt}");

        Position += rInt;
        Score += rInt; //pozycja = punkty
        
        Console.WriteLine($"Gracz: {playerName} znajdje się na pozycji: {Position}");
        
    }
}
