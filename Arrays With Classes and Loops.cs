using System;

public class Program{
    public static void Main()
    {
        weapon[] weaponsObjs = {new weapon(), new weapon()};
        weaponsObjs[1].weaponName = "sword";

        foreach(var item in weaponsObjs){
            Console.Writeline(item.weaponName);
        }
    }
}

public class weapon {
    public string weapnName = "Axe";
    public int powerLevel = 1;
}