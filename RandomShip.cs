using System;
namespace InDepthWin
{
	class RandomShip
	{
        public int lvl = 1;
        public String Ename;
        public String Allegiance;
        private Random rand = new Random();
        public int emoney = 0;
        public int ehealth;
        public int eattack;
        public int edefence;
        public int estorage;
        public int efirerate;
        public Inventory INV = new Inventory();
        public Coordinates EXY = new Coordinates(0, 0);
        public int Eindex;
        public bool Hostile;
        public bool Active;

        public RandomShip(int IND, String NAME, Coordinates COORDS, int ALLI)
        {
            Active = true;
            Eindex = IND;
            Ename = NAME;
            EXY = COORDS;
            Alliance(ALLI);
            foreach (Item II in INV.InInv)
            {
                if (II.Type == "AMMO")
                {
                    II.Amount = rand.Next(90, 150);
                }
                else if (II.Type == "CONSU")
                {
                    II.Amount = rand.Next(1, 10);
                }
            }
        }

        public String IsHostile()
        {
            if (Hostile == true)
            {
                return "Hostile";
            }
            else
            {
                return null;
            }
        }

        public void HOSTILEYN(int hst)
        {
            if(hst == 0)
            { Hostile = false; }
            else
            { Hostile = true; }
        }

        public void Alliance(int alli)
        {
            switch (alli)
            {
                case 0:
                    ehealth = 100000; eattack = 200; edefence = 30; estorage = 3000;
                    efirerate = 5; Allegiance = "CONM";
                    break;

                case 1:
                    ehealth = 150000; eattack = 150; edefence = 40; estorage = 3000;
                    efirerate = 3; Allegiance = "AOBO";
                    break;

                case 2:
                    ehealth = 150000; eattack = 175; edefence = 40; estorage = 6000;
                    efirerate = 4; Allegiance = "NLFD";
                    break;

                case 3:
                    ehealth = 100000; eattack = 150; edefence = 50; estorage = 5000;
                    efirerate = 3; Allegiance = "RUOP";
                    break;

                case 4:
                    ehealth = 175000; eattack = 190; edefence = 40; estorage = 3000;
                    efirerate = 4; Allegiance = "CPMC";
                    break;

                default:
                    Allegiance = "UEDF";
                    ehealth = 200000; eattack = 100; edefence = 60; estorage = 3000;
                    efirerate = 1; Allegiance = "UEDF";
                    break;
            }
        }
    }
}
