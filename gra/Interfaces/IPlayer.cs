namespace gra.Interfaces;

public interface IPlayer
{
    string Name { get; set; }
    int Position { get; set; }
    int Score { get; set; }

    void Rusz();
    void Punkty();
}