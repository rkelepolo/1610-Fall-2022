using System;

public class Program
{
    public static void Main()
    {
        string[] playerTypes = {"Pawn", "Pawn", "Pawn"};
        playerTypes[1] = "Queen";

        foreach(var playerTyper in playerTypes) {
            Console.Writeline(playerType);
        }
    }
}