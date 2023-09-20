using System;
					
public class Program
{
	public void Main()
	{
		weapon[] weaponObjs = {new weapon(), new weapon(), new weapon()};
		weaponObjs[1].weaponName = "Sword";
		weaponObjs[2].weaponName = "Hammer";
		
		for(var i = 0; i < weaponObjs.Length; i++) {
			weaponObjs[i].powerLevel = 2;
		}
		
		foreach(var item in weaponObjs) {
			Console.WriteLine(item.weaponName);
			Console.WriteLine(item.powerLevel);
		}
	}
}

public class weapon {
	public string weaponName = "Axe";
	public int powerLevel = 1;
}