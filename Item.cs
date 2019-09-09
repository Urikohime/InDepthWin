/*
 * Code Written by: Patrik Schodrowski
 * All rights reserved
*/
using System;
namespace InDepthWin
{
	public class Item
	{
		public String Name;
		public bool Usable;
		public int ItIndex;
		public String Desc;
		public String Type;
		public int HReffect;
		public int Value;
		public int Amount;

		public Item()
		{
		}

		public Item(int index,String name, String type, int effect, int value, String desc)
		{
			ItIndex = index;
			Name = name;
			Type = type;
			HReffect = effect;
			Value = value;
			Desc = desc;
			switch(Type)
			{
				case "AMMO":
				Usable = false;
				break;

				case "CONSU":
				Usable = true;
				break;
			}
		}
	}
}
