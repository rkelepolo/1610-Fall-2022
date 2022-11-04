using System;

public class Program
{
    public Hero heroOne;
    public Hero heroTwo;
    public Hero heroThree;
    public Hero heroFour;
    
    public void Main()
    {
        heroOne = new Hero();
        heroTwo = new Hero();
        heroThree = new Hero();
        heroFour = new Hero();
        
        heroOne.health = 5;
        heroOne.powerLevel = 10;
        heroOne.attackspeed = 2;
        
        heroTwo.health = 7;
        heroTwo.powerlevel = 15;
        heroTwo.attackspeed = 1;
        
        heroThree.health = 6;
        heroThree.powerlevel = 11;
        heroThree.attackspeed = 3;
        
        heroFour.health = 4;
        heroFour.powerlevel = 20;
        heroFour.attackspeed = 5;
        
        Console.Writeline(heroOne.health);
        Console.Writeline(heroOne.powerlevel);
        Console.Writeline(heroOne.attackspeed);
        
        Console.Writeline(heroTwo.health);
        Console.Writeline(heroTwo.powerlevel);
        Console.Writeline(heroTwo.attackspeed);
        
        Console.Writeline(heroThree.health);
        Console.Writeline(heroThree.powerlevel);
        Console.Writeline(heroThree.attackspeed);
        
        Console.Writeline(heroFour.health);
        Console.Writeline(heroFour.powerlevel);
        Console.Writeline(heroFour.attackspeed);
    }
}  

public class Hero {
    public int health;
    public int powerlevel;
    public int attackspeed;