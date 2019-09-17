/*
 * Code Written by: Patrik Schodrowski
 * All rights reserved
*/
using System;
using System.Collections.Generic;

namespace InDepthWin
{
	class Player
	{
		public int exp = 0;
		public int lvlup = 100;
		public int lvl = 1;
		public String Pname;
		public String Sname;
		public String Allegiance;
		private Random rand = new Random();
		public int questfrom;
		public String questacitvename;
		public String questacitvetarget;
		public bool questReady = false;
		public bool questactive = false;
		public int pmoney = 0;
		public int phealth;
		public int pattack;
		public int pdefence;
		public int pstorage;
		public int pfirerate;
		public int pcooldown = 2;
		public String pability;
		public Inventory INV = new Inventory();
		public Coordinates PXY = new Coordinates(0, 0);

		public Player()
		{
			PXY.X = rand.Next(1000, 9999);
			PXY.Y = rand.Next(1000, 9999);
			Pname = "X. Odak";
			Sname = "Firebird IV";
			Allegiance = "UEDF";
			phealth = 200000; pattack = 100; pdefence = 60; pstorage = 30;
			pfirerate = 1; pability = "ShieldBoost"; pcooldown = 2;
			INV.INITIALISE();
			pmoney = 5000;

			foreach(Item II in INV.InInv)
			{
				if(II.Name == "Cartridge")
					II.Amount = 100;
				if(II.Name == "Nanites")
					II.Amount = 2;
				if(II.Name == "Energy")
					II.Amount = 2;
			}
		}

		public void Alliance(String alli)
		{
			switch(alli)
			{
				case "CONM":
				    phealth = 100000; pattack = 200; pdefence = 30; pstorage = 3000;
				    pfirerate = 5; pability = "Overcharge"; Allegiance = "CONM";
				    break;

				case "AOBO":
				    phealth = 150000; pattack = 150; pdefence = 40; pstorage = 3000;
				    pfirerate = 3; pability = "EnergyFlow"; Allegiance = "AOBO";
				    break;

				case "TSIB":
				    phealth = 175000; pattack = 125; pdefence = 50; pstorage = 4000;
				    pfirerate = 3; pability = "LightBreak"; Allegiance = "TSIB";
				    break;

				case "NLFD":
				    phealth = 150000; pattack = 175; pdefence = 40; pstorage = 6000;
				    pfirerate = 4; pability = "Scavenge"; Allegiance = "NLFD";
				    break;

				case "RUOP":
				    phealth = 100000; pattack = 150; pdefence = 50; pstorage = 5000;
				    pfirerate = 3; pability = "Commerce"; Allegiance = "RUOP";
				    break;

				case "CPMC":
				    phealth = 175000; pattack = 190; pdefence = 40; pstorage = 3000;
				    pfirerate = 4; pability = "ShieldFlow"; Allegiance = "CPMC";
				    break;

				default:
				    Allegiance = "UEDF";
				    phealth = 200000; pattack = 100; pdefence = 60; pstorage = 3000;
				    pfirerate = 1; pability = "ShieldBoost"; Allegiance = "UEDF";
				    break;
			}
		}

		public String ShowClearStats()
		{
			return "Cpt. " + Pname + " of the '" + Sname + "' from the " + Allegiance +
			"\nCredits: " + pmoney + "  |  LVL: " + lvl + "  |  EXP: " + exp +
			"\nHull: " + phealth + "  |  Shield: " + pdefence +
			"\nStrength: " + pattack + "  |  FireRate: " + pfirerate +
			"\nAbility: " + pability + "  |  " + Getcurrentquest() +
			"\nCoordinates: " + PXY.CurrentC();
		}

		public void Setcurrentquest(String qname, String qtarget, int qfrom)
		{
			questactive = true;
			questacitvename = qname;
			questacitvetarget = qtarget;
			questfrom = qfrom;
		}

		public void Questdone(int Cearn)
		{
			questactive = false;
			questacitvename = null;
			questacitvetarget = null;
			questReady = false;
			questfrom = -1;
			pmoney += Cearn;
			exp += (Cearn / 2);
			if(lvlup == exp)
			{
				exp = exp - lvlup;
				lvl += 1;
				lvlup += 50;
				pmoney += lvl * 100;
			}
		}

		public void Checkquest(String pname)
		{
			questReady |= questacitvetarget == pname;
		}

		public String Getcurrentquest()
		{
			if(questactive)
			{
				if(questReady)
				{
					return "Quest: " + questacitvename + " [X]";
				}
				return "Quest: " + questacitvename + " [ ]";
			}
			else
			{
				return "Quest: [ ]";
			}
		}
	}
}
