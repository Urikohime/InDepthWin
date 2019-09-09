using System;
using System.Collections.Generic;
namespace InDepthWin
{
	public class ItemIndex
	{
		//public String[] I_00 = new string[] { "INDEX", "NAME", "TYPE", "IS USABLE", "EFFECT RATE", "VALUE", "DESCRIPTION"};
		public String[] ALLITEMS = new string[] { "" };


		//AMMO
		public Item AMMO_00 = new Item(1, "Cartridge", "AMMO", 1, 10, "Ok aginst Hull. Ok against Shield");
		public Item AMMO_01 = new Item(2, "Plasma", "AMMO", 2, 20, "Bad against Hull. Good against Shield");
		public Item AMMO_02 = new Item(3, "Laser", "AMMO", 2, 20, "Good against Hull. Bad against Shield.");
		public Item AMMO_03 = new Item(4, "Kinetic", "AMMO", 3, 30, "Strong against Hull. Ok against Shield.");

		//CONSUMABLE
		public String[] CONSU_00 = new string[] {"Hull parts", "CRAFT", "0", "50", "A material used for crafting." };
		public String[] CONSU_01 = new string[] {"NAME", "TYPE", "0", "50", "A material used for crafting." };

        //
        public String[] CRAFT_00 = new string[] { };
	}
}
