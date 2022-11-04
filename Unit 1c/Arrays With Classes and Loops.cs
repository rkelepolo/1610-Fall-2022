using System;

public class Program{
    public static void Main()
    {
        weapon[] weaponsObjs = {new weapon(), new weapon(), new weapon()};
        weaponsObjs[1].weaponName = "sword";
        weaponsObjs[2].weaponName = "Hammer";

        for(var i=0;i<weaponsObjs.Length;i++) {
            weaponsObjs[i].powerLevel = 2;

        }

        foreach(var item in weaponsObjs){
            Console.Writeline(item.weaponName);
            Console.WritLine(item.powerLevel);
        }
    }
}

public class weapon {
    public string weapnName = "Axe";
    public int powerLevel = 1;
}