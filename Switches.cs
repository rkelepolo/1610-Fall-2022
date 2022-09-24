using System;

public class Program
{
    public GamesStates gameStates;

    public void Main()
    {   
        gameStates = new GameStates();
        gameStates.currentState = GameStates.States.Ending;
        gameStates.CheckState();
    }
} 

public class GameStates {


   pulbic enum States {
        Starting,
        Playing,
        Ending
    }

    public States currentState = States.Starting;
    
    public void CheckState () {
        swtich (currentState) {
            case States.Starting:
                Console.Writeline("Starting");
                break;
            case States.Playing:
                Console.Writeline("Playing");
                break;
            case States.Endin:
                Console.Writeline("Endind");
                break;  
        }
    }
}