using gra.Interfaces;

namespace gra.Classes;
using gra.Classes;

public class Game
{
    public IPlayer gracz1;
    public IPlayer gracz2;
    
    // Konstruktor klasy Game
    public Game(IPlayer player1, IPlayer player2)
    {
        gracz1 = player1;
        gracz2 = player2;
    }
    
    public static void SprawdzNagrode(IPlayer player)
    {
        if (player.Position % 4 == 0) //co 4 pole daje nagrode
        {
            Classes.Board.Nagroda(player);
        }
    }

    public void Wyniki()
    {
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