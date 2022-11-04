using System;
					
public class Program
{
	public Sword swordOne;
	pubilc Sword swordtwo;
	
	public void Main()
	{
		swordOne = new Sword();
		swordTwo = new Sword();
		
		swordOne.power = 5;
		swordOne.durability = 10;
		
		swordTwo.power = 8;
		swordTwo.durability = 6;
		
		Console.Writeline(swordOne.power);
		Console.Writeline(swordOne.durability);
		
		Console.Writeline(swordTwo.power);
		Console.Writeline(swordTwo.durability);
	}
}

public class sword {
	public int power;
	public int durability;
}
		