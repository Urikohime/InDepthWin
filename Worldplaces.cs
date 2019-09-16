/*
 * Code Written by: Patrik Schodrowski
 * All rights reserved
*/
using System;
using System.Collections.Generic;

namespace InDepthWin
{
	class Worldplaces
	{
        
		public Random r = new Random();
        private int maxcapa = 1;
        private int randplaces = 10;
        private int PInd;
        private int queind = 0;
        private String Qname = null;

        public List<People> ListPeople = new List<People>();
		public List<Place> ListPlaces = new List<Place>();
        public List<RandomShip> ListRandShips = new List<RandomShip>();
		AllItemsList AIL = new AllItemsList();

        private String[] NAMES = { "Robert", "Vulcan", "Texan", "QUS", "Spade", "Rattler", "Spider" };
        private String[] NUMBERS = { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X", "XI", "XII", "XIII", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13" };

        private String[] ShopPeople = { "Mehmet the Merchant", "Danskar" };
        private String[] MercPeople = { "Trader of Goods", "Merolico Guy", "Generic Trader", "Traveling Trader" };

        private String[] ShopPlaces = { "Embassy of Trade", "Marketplace", "Caravan" };

        private String[] RandPeople = { "Settler", "Engineer", "Officer", "Pilot", "Miner", "Civilian", "Explorer", "Traveler", "Scientist", "Guard", "Nurse", "Doctor"};
        private String[] MainPeople = { "Commander", "Leutnant", "Antonio", "Giz", "Saki", "Rose"};

        private String[] MainPlaces = { "HQ", "Centres", "The Vault", "Saturn VI", "Cripton", "Uranus", "Void", "Sanctuary", "H. Heaven", "Demons Rift", "Angels Tears" };
        private String[] RandPlaces1 = { "ATX ", "BVV ", "COF ", "DTP ", "EEE ", "FHJ " , "EPE ", "XAX ", "PNS ", "GOF ", "XZN "};
		private String[] RandPlaces2 = { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X", "XI", "XII", "XIII", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13" };

        public void CreatePlacesONE()
        {
            for (int i = 0; i < MainPlaces.Length; i++)
            {
                Coordinates coords = new Coordinates(0, 0);
                ListPlaces.Add(new Place(i, MainPlaces[i], coords, r.Next(15, 20)));
                ListPlaces[i].placeXY.X = r.Next(100000, 999999);
                ListPlaces[i].placeXY.Y = r.Next(100000, 999999);
                maxcapa += ListPlaces[i].PCapacity;
            }
        }

        public void CreatePlacesTWO()
        {
            for (int v = ListPlaces.Count; v < MainPlaces.Length + randplaces; v++)
            {
                Coordinates coords = new Coordinates(0, 0);
                ListPlaces.Add(new Place(v, RandPlaces1[r.Next(0, RandPlaces1.Length)] + RandPlaces2[r.Next(0, RandPlaces2.Length)], coords, r.Next(10, 15)));
                ListPlaces[v].placeXY.X = r.Next(100000, 999999);
                ListPlaces[v].placeXY.Y = r.Next(100000, 999999);
                for (int chk = 0; chk < ListPlaces.Count - 1; chk++)
                {
                    if (ListPlaces[chk].placeXY.CurrentC() == ListPlaces[v].placeXY.CurrentC())
                    {
                        ListPlaces[v].placeXY.X = r.Next(100000, 999999);
                        ListPlaces[v].placeXY.Y = r.Next(100000, 999999);
                    }
                }
                maxcapa += ListPlaces[v].PCapacity;
            }
        }

        public void CreatePlacesTHREE()
        {
            for (int ccc = 0; ccc < ShopPlaces.Length; ccc++)
            {
                for (int h = ListPlaces.Count; h < ShopPlaces.Length + MainPlaces.Length + randplaces; h++)
                {
                    Coordinates coords = new Coordinates(0, 0);
                    ListPlaces.Add(new Place(h, ShopPlaces[ccc], coords, r.Next(10, 18)));
                    ListPlaces[h].placeXY.X = r.Next(100000, 999999);
                    ListPlaces[h].placeXY.Y = r.Next(100000, 999999);
                    maxcapa += ListPlaces[h].PCapacity;
                }
            }
        }

        public void CreatePeopleONE()
        {
            
            for (int j = 0; j < MainPeople.Length; j++)
            {
                PInd = r.Next(0, ListPlaces.Count);
                bool placed = false;
                while (placed == false)
                {
                    PInd = r.Next(0, ListPlaces.Count);
                    if (MainPeople[j] == "Commander")
                    {
                        PInd = 0;
                        ListPlaces[0].PCounter += 1;
                        placed = true;
                    }
                    else
                    {
                        if (ListPlaces[PInd].PCapacity >= ListPlaces[PInd].PCounter)
                        {
                            placed = true;
                            ListPlaces[PInd].PCounter += 1;
                        }
                    }
                }
                placed = false;
                while (Qname == null)
                {
                    for (int m = 0; m < MainPlaces.Length; m++)
                    {
                        if (r.Next(0, MainPlaces.Length) == m && ListPlaces[PInd].placeXY.CurrentC() != ListPlaces[m].placeXY.CurrentC())
                        {
                            Qname = ListPlaces[m].placename;
                            queind = m;
                        }
                    }
                }
                ListPeople.Add(new People(j, MainPeople[j], true, PInd));
                ListPeople[j].Setquest("Go To", Qname);
                ListPeople[j].PlInIndex = ListPlaces[PInd].PCounter;
                Qname = null;
                ListPeople[j].isImportant = true;
                ListPeople[j].hasInfoCoord = ListPlaces[queind].placeXY.CurrentC();
                ListPeople[j].hasCoordInfo = true;
            }
        }

        public void CreatePeopleTWO()
        {
            int sss = 0;
            for (int f = ListPeople.Count; f < MainPeople.Length + ShopPeople.Length; f++)
            {
                PInd = r.Next(0, ListPlaces.Count);
                bool placed = false;
                while (placed == false)
                {
                    PInd = r.Next(0, ListPlaces.Count);
                    if (ListPlaces[PInd].PCapacity >= ListPlaces[PInd].PCounter)
                    {
                        placed = true;
                        ListPlaces[PInd].PCounter += 1;
                    }
                }
                placed = false;
                ListPeople.Add(new People(f, ShopPeople[sss], false, PInd));
                ListPeople[f].PlInIndex = ListPlaces[PInd].PCounter;
                Qname = null;
                ListPeople[f].isImportant = true;
                ListPeople[f].hasCoordInfo = false;
                sss++;
            }

            Qname = null;
        }

        public void CreatePeopleTHREE()
        {
            int RandPeopleCounter = r.Next(maxcapa / 2, maxcapa - ListPlaces.Count);
            for (int k = 0; k < RandPeopleCounter; k++)
            {
                for (int l = ListPeople.Count; l < MainPeople.Length + ShopPeople.Length + RandPeople.Length + RandPeopleCounter; l++)
                {
                    bool yesno = false;
                    int i = 10;
                    if (i < r.Next(0, 20))
                    {
                        yesno = true;
                    }
                    else
                    {
                        yesno = false;
                    }

                    PInd = r.Next(0, ListPlaces.Count);
                    bool placed = false;
                    while (placed == false)
                    {
                        if (ListPlaces[PInd].PCapacity > ListPlaces[PInd].PCounter)
                        {
                            placed = true;
                            ListPlaces[PInd].PCounter += 1;
                        }
                        else
                        {
                            PInd = r.Next(0, ListPlaces.Count);
                        }
                    }
                    placed = false;

                    while (Qname == null)
                        for (int m = 0; m < ListPlaces.Count; m++)
                        {
                            if (r.Next(0, ListPlaces.Count) == m && ListPlaces[PInd].placeXY.CurrentC() != ListPlaces[m].placeXY.CurrentC())
                            {
                                Qname = ListPlaces[m].placename;
                                queind = m;
                            }
                        }

                    ListPeople.Add(new People(l, RandPeople[r.Next(0, RandPeople.Length)], yesno, PInd));
                    ListPeople[l].Setquest("Go To", Qname);
                    ListPeople[l].PlInIndex = ListPlaces[PInd].PCounter;
                    Qname = null;
                    ListPeople[l].isImportant = false;
                    if (r.Next(1, 100) <= 50)
                    {
                        ListPeople[l].HasRandom = true;
                        int A = r.Next(1, ListPlaces.Count);
                        ListPeople[l].RandCoordsX = ListPlaces[A].placeXY.X;
                        ListPeople[l].RandCoordsY = ListPlaces[A].placeXY.Y;
                    }
                    if (ListPeople[l].hasQuest == true)
                    {
                        ListPeople[l].hasInfoCoord = ListPlaces[queind].placeXY.CurrentC();
                        ListPeople[l].hasCoordInfo = true;
                    }
                    else
                    {
                        ListPeople[l].hasInfoCoord = "";
                        ListPeople[l].hasCoordInfo = false;
                    }
                }
            }
        }

        public void CreatePeopleFOUR()
        {
            for (int v = 0; v < ListPlaces.Count; v++)
            {
                foreach (String plc in ShopPlaces)
                {
                    ListPeople.Add(new People(ListPeople.Count + v, MercPeople[r.Next(0, MercPeople.Length)], false, v));
                    ListPeople[ListPeople.Count - 1].PlInIndex = ListPlaces[v].PCounter + 1;
                    ListPeople[ListPeople.Count - 1].isImportant = false;
                    ListPeople[ListPeople.Count - 1].IsTrader = true;
                    ListPeople[ListPeople.Count - 1].INNV.INITIALISE();

                    for (int kl = 0; kl < AIL.AllItems.Length; kl++)
                    {
                        ListPeople[ListPeople.Count - 1].INNV.InInv[kl].Amount = r.Next(100, 200);
                    }
                    ListPlaces[v].PCounter += 1;
                }
            }
        }

        public void CreateRandomShipsONE(String Alli)
        {
            for (int i = 0; i < r.Next(randplaces*10, randplaces*20); i++)
            {
                ListRandShips.Add(new RandomShip(i, NAMES[r.Next(0, NAMES.Length)] + " " + NUMBERS[r.Next(0, NUMBERS.Length)], new Coordinates(r.Next(100000, 999999), r.Next(100000, 999999)), r.Next(0, 5)));
            }
        }

        private void HOSTILES(String Alli)
        {
            foreach (RandomShip RS in ListRandShips)
            {
                if(RS.Allegiance == Alli)
                {
                    RS.Hostile = false;
                }

            }
        }

        public Worldplaces()
        {
        }
	}
}