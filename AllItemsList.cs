using System;
namespace InDepthWin
{
	public class AllItemsList
	{
		//NAME | TYPE | EFFECT | VALUE | DESCRIPTION
		public String[] AllItems = new String[] {
			///AMMO
			"Cartridge|AMMO|1|10|HULL: OK, SHIELD: OK",
			"Plasma|AMMO|2|20|HULL: BAD, SHIELD: GOOD",
			"Laser|AMMO|2|20|HULL: GOOD, SHIELD: BAD",
			"Kinetic|AMMO|3|30|HULL: BEST, SHIELD: BAD",

			///CONSU / CONSUMABLES
			"Nanites|CONSU|10|50|REPAIRS HULL BY 10",
			"Energy|CONSU|10|50|RECHARGE SHIELD BY 10"
			};
	}
}
