/*
 * Code Written by: Patrik Schodrowski
 * All rights reserved
*/
using System;
using System.Collections.Generic;

namespace InDepthWin
{
	public class Inventory
	{
		// NAME | INDEX | TYPE | AMOUNT
		public List<Item> InInv = new List<Item>();
		AllItemsList AIL = new AllItemsList();

		public Inventory()
		{
			for(int f = 0; f < AIL.AllItems.Length; f++)
			{
				String[] info = AIL.AllItems[f].Split('|');
				InInv.Add(new Item(f, info[0], info[1], int.Parse(info[2]), int.Parse(info[3]), info[4]));
			}
		}

		public void INITIALISE()
		{
			for(int i = 0; i < AIL.AllItems.Length; i++)
			{
				InInv[i].Amount = 0;
			}
		}

		public void ADDITEM(String I, int amount)
		{
			foreach(Item II in InInv)
			{
				if(I.ToUpper() == II.Name.ToUpper())
				{
					II.Amount += amount;	
				}
			}
		}

		public void REMOVEITEM(String I, int amount)
		{
			foreach(Item II in InInv)
			{
				if(I.ToUpper() == II.Name.ToUpper())
				{
					II.Amount -= amount;
					if(II.Amount <= 0)
						II.Amount = 0;
				}
			}
		}
	}
}
