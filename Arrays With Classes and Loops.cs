using System;

public class Program{
    public static void Main()
    {
        weapon[] weaponsObjs = {new weapon(), new weapon()};
        Console.Writeline(weaponsObjs[0].weaponsName);
    }
}

public class weapon {
    public string weapnName = "Axe";
    public int powerLevel = 1;
}