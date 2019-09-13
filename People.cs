/*
 * Code Written by: Patrik Schodrowski
 * All rights reserved
*/
using System;
using System.Collections.Generic;

namespace InDepthWin
{
	class People
	{
		public Inventory INNV = new Inventory();
		public int shopinv;
		public Speeches sp = new Speeches();
		public bool hasCoordInfo = false;
		public bool isQuestInProg = false;
		public String hasInfoCoord;
		public bool isImportant = false;
		public String questname = null;
		public bool questdone;
		public String questplace;
		public String[] questnames = new String[] { "Go to" };
		public int pindex;
		public int Plindex;
		public int PlInIndex;
		public String name;
		public bool hasQuest;
		public bool HasRandom = false;
		public int RandCoordsX;
		public int RandCoordsY;
		public bool IsTrader = false;

		public Random r = new Random();

		public People(int ind, String n, bool yesno, int PI)
		{
			shopinv = r.Next(100, 200);
			pindex = ind;
			name = n;
			hasQuest = yesno;
			Plindex = PI;
		}

		public String Talk()
		{
			String sent = "Hmm...?";
			sent = sp.randomtalk[r.Next(0, sp.randomtalk.Length)];
			return sent;
		}

		public String Info()
		{
			String sent = "Hmm...?";
			if(HasRandom == false)
			{
				sent = "\n" + sp.randomnoinfo[r.Next(0, sp.randomnoinfo.Length)];
			}
			if(HasRandom == true)
			{
				sent = "\n" + sp.randomhasinfo[r.Next(0, sp.randomhasinfo.Length)] + "\n" +
				(RandCoordsX - 1000) + ":" + (RandCoordsY - 1000) + " - " + (RandCoordsX + 1000) + ":" + (RandCoordsY + 1000);
			}
			if(hasCoordInfo)
			{
				sent = "Your target should be here: " + hasInfoCoord;
			}
			return sent;
		}

		public String QuestStart()
		{
			String sent = "Really ?";
			sent = sp.randomGoToStart[r.Next(0, sp.randomGoToStart.Length)];
			return sent;
		}

		public String QuestDone()
		{
			String sent = "Thanks";
			sent = sp.randomGoToDone[r.Next(0, sp.randomGoToDone.Length)];
			return sent;
		}

		public void Setquest(String name, String toreach)
		{
			questname = name + ": " + toreach;
			questplace = toreach;
			questdone = false;
		}

		public void Setcoordinfo(List<Place> pl)
		{
			int i = 10;
			if(i < r.Next(0, 20))
			{
				for(int k = 0; k < pl.Count; k++)
				{
					if(r.Next(0, pl.Count) == k)
					{
						hasInfoCoord = pl[k].placeXY.ToString();
					}
				}
				hasCoordInfo = true;
			}
			else
			{
				hasCoordInfo = false;
			}
		}
	}
}
