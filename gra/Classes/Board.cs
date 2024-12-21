using gra.Interfaces;

namespace gra.Classes;

public class Board
{
    //public int Rozmiar = 15;

    public static void Nagroda(IPlayer player)
    {
        Random r2 = new Random();
        int rInt2 = r2.Next(1, 5);
        player.Score += rInt2;
        Console.WriteLine($"Nagroda! Gracz {player.Name} otrzymuje {rInt2} punktów.");
    }
    
    public static void SprawdzNagrode(IPlayer player)
    {
        if (player.Position % 4 == 0) //co 4 pole daje nagrode
        {
            Nagroda(player);
        }
    }
}
