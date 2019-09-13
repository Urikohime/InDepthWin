using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace InDepthWin
{
    public partial class Form1 : Form
    {
        String[] Alliance = { "UEDF", "CONM", "AOBO", "TSIB", "NLFD", "RUOP", "CPMC" };
        String[] Commands = { "MOVE", "LAND", "SHOP", "TALK", "INFO", "QUEST", "DONE", "HELP" };
        Player player = new Player();
        Worldplaces world = new Worldplaces();
        String INNFO;
        int talkingto;
        int CurrentPlaceID;
        bool inshop = false;
        bool landed = false;
        bool talking = false;

        public void AddToBar()
        {
            progressBarStart.Maximum = 8;

            Thread.Sleep(1000);
            world.CreatePlacesONE();
            progressBarStart.Increment(1);
            Thread.Sleep(1000);

            world.CreatePlacesTWO();
            progressBarStart.Increment(1);
            Thread.Sleep(1000);

            world.CreatePlacesTHREE();
            progressBarStart.Increment(1);
            Thread.Sleep(1000);

            world.CreatePeopleONE();
            progressBarStart.Increment(1);
            Thread.Sleep(1000);

            world.CreatePeopleTWO();
            progressBarStart.Increment(1);
            Thread.Sleep(1000);

            world.CreatePeopleTHREE();
            progressBarStart.Increment(1);
            Thread.Sleep(1000);

            world.CreatePeopleFOUR();
            progressBarStart.Increment(1);
            Thread.Sleep(1000);

            world.CreateEnemiesONE();
            progressBarStart.Increment(1);
            Thread.Sleep(1000);
        }

        public Form1()
        {
            InitializeComponent();
            On_Load();
        }

        private void On_Load()
        {
            this.Size = new Size(415, 338);
            StartWindow.Visible = true;
            StartWindow.Location = new Point(0,0);
        }

        private async void LoadWorld()
        {
            AddToBar();
            await Task.Delay(1);
        }

        protected async void OnPressedStart(object sender, EventArgs e)
        {
            INVISIBLE();
            await Task.Delay(10);
            LoadWorld();
            await Task.Delay(10);
            VISIBLE();
            await Task.Delay(10);
            SCAN();
            if (PlayerNameIN.Text != "")
            {
                player.Pname = PlayerNameIN.Text;
            }
            else
            {
                player.Pname = "X. Odak";
            }

            if (PlayerShipIN.Text != "")
            {
                player.Sname = PlayerShipIN.Text;
            }
            else
            {
                player.Sname = "Firebird VI";
            }
            player.Alliance(SelectedAll());
            Stats.Text = player.ShowClearStats();
            INSTR();
        }

        private async void INVISIBLE()
        {
            PnameLabel.Text = "Please wait while the world is being created and filled!";
            PnameLabel.Location = new Point(5, 100);
            SnameLabel.Visible = false;
            progressBarStart.Visible = true;
            PlayerNameIN.Visible = false;
            PlayerShipIN.Visible = false;
            UEDFselect.Visible = false;
            TSIBselect.Visible = false;
            AOBOselect.Visible = false;
            RUOPselect.Visible = false;
            CONMselect.Visible = false;
            CPMCselect.Visible = false;
            NLFDselect.Visible = false;
            StartBtn.Visible = false;
            await Task.Delay(1);
        }

        private async void VISIBLE()
        {
            StartWindow.Location = new Point(605, 805);
            StartWindow.Visible = false;

            this.Size = new Size(815, 638);

            StatsWindow.Visible = true;
            TerminalWindow.Visible = true;
            LoggingWindow.Visible = true;
            MapWindow.Visible = true;
            await Task.Delay(1);
        }

        private String SelectedAll()
        {
            String selection = "UEDF";
            if (UEDFselect.Checked)
                selection = "UEDF";
            if (AOBOselect.Checked)
                selection = "AOBO";
            if (CONMselect.Checked)
                selection = "CONM";
            if (NLFDselect.Checked)
                selection = "NLFD";
            if (TSIBselect.Checked)
                selection = "TSIB";
            if (RUOPselect.Checked)
                selection = "RUOP";
            if (CPMCselect.Checked)
                selection = "CPMC";

            return selection;
        }

        private async void SendCommando(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                SendCommand();
            }
            await Task.Delay(1);
        }

        private async void AutoComplete(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey && TerminalIN.TextLength != 0)
            {
                for (int i = 0; i < Commands.Length; i++)
                {
                    if (Commands[i].StartsWith(TerminalIN.Text.ToUpper()))
                    {
                        TerminalIN.Text = Commands[i];
                        TerminalIN.Focus();
                        TerminalIN.SelectionStart = TerminalIN.Text.Length;
                    }
                }
            }
            await Task.Delay(1);
        }

        protected async void SendCommand()
        {
            try
            {
                String[] INP = TerminalIN.Text.ToUpper().Split(' ');
                if (INP[0].Trim() == "MOVE" && talking == false && landed == false)
                {
                    if (INP[1].Trim().Length == 13)
                    {
                        String[] inpx = INP[1].Split(':');
                        if (int.Parse(inpx[0]) <= (player.PXY.X + 1000) && int.Parse(inpx[0]) >= (player.PXY.X - 1000) && int.Parse(inpx[1]) <= (player.PXY.Y + 1000) && int.Parse(inpx[1]) >= (player.PXY.Y - 1000))
                        {
                            player.PXY.X = int.Parse(inpx[0]);
                            player.PXY.Y = int.Parse(inpx[1]);
                        }
                        for (int i = 0; i < world.ListPlaces.Count; i++)
                        {
                            if (INP[1] == world.ListPlaces[i].placeXY.CurrentC())
                            {
                                player.PXY.X = int.Parse(inpx[0]);
                                player.PXY.Y = int.Parse(inpx[1]);
                                CommandLog.Text = CommandLog.Text + "";
                                CurrentPlaceID = world.ListPlaces[i].plindex;
                            }
                        }
                        CommandLog.Text = INP[0] + ": " + INP[1];
                        if (player.questactive)
                        {
                            player.Checkquest(world.ListPlaces[CurrentPlaceID].placename);
                        }
                    }
                }
                if (TerminalIN.Text.ToUpper() == "LAND" && landed == false)
                {
                    MapWindow.Visible = false;
                    PlaceWindow.Location = new Point(400, 0);
                    PeopleOnPlace.Text = "";
                    for (int i = 0; i < world.ListPlaces.Count; i++)
                    {
                        if (player.PXY.CurrentC() == world.ListPlaces[i].placeXY.CurrentC())
                        {
                            CurrentPlaceID = world.ListPlaces[i].plindex;
                            MapWindow.Visible = false;
                            PlaceTitle.Text = world.ListPlaces[i].placename;
                            PlaceWindow.Visible = true;
                            CommandLog.Text = "YOU'VE LANDED!\nINSERT THE NUMBER OF THE NPC YOU WISH TO INTERACT WITH";
                            landed = true;
                            for (int o = 0; o < world.ListPeople.Count; o++)
                            {
                                if (world.ListPeople[o].Plindex == world.ListPlaces[i].plindex)
                                {
                                    if (world.ListPeople[o].hasQuest == true)
                                        if (world.ListPeople[o].isQuestInProg)
                                            PeopleOnPlace.Text = PeopleOnPlace.Text + world.ListPeople[o].PlInIndex + " - " + world.ListPeople[o].name + " [!] " + "\n";
                                        else
                                            PeopleOnPlace.Text = PeopleOnPlace.Text + world.ListPeople[o].PlInIndex + " - " + world.ListPeople[o].name + " [Q] " + "\n";
                                    if (world.ListPeople[o].hasQuest == false)
                                        PeopleOnPlace.Text = PeopleOnPlace.Text + world.ListPeople[o].PlInIndex + " - " + world.ListPeople[o].name + "\n";
                                }
                            }
                        }
                    }
                }

                try
                {
                    if (int.Parse(TerminalIN.Text) > 0 && landed == true)
                    {
                        for (int i = 0; i < world.ListPeople.Count; i++)
                        {
                            if (int.Parse(TerminalIN.Text) == world.ListPeople[i].PlInIndex && world.ListPeople[i].Plindex == world.ListPlaces[CurrentPlaceID].plindex)
                            {
                                talkingto = world.ListPeople[i].pindex;
                                TALKTO(talkingto, "");
                            }
                        }
                    }
                }
                catch (Exception) { }

                try
                {
                    INP = TerminalIN.Text.ToUpper().Split(' ');
                    if (int.Parse(INP[1]) > 0 && inshop == true)
                    {
                        for (int i = 0; i < world.ListPeople.Count; i++)
                        {
                            if (INP[0].ToUpper() == world.ListPeople[talkingto].INNV.InInv[i].Name.ToUpper() && player.pmoney >= (world.ListPeople[talkingto].INNV.InInv[i].Value * int.Parse(INP[1])))
                            {
                                if (int.Parse(INP[1]) >= world.ListPeople[talkingto].INNV.InInv[i].Amount)
                                {
                                    INP[1] = world.ListPeople[talkingto].INNV.InInv[i].Amount.ToString();
                                }
                                player.INV.ADDITEM(INP[0], int.Parse(INP[1]));
                                player.pmoney -= (world.ListPeople[talkingto].INNV.InInv[i].Value * int.Parse(INP[1]));
                                world.ListPeople[talkingto].INNV.REMOVEITEM(INP[0], int.Parse(INP[1]));
                                SHOPTO(talkingto);
                            }
                        }
                    }
                }
                catch (Exception) { }

                if (TerminalIN.Text.ToUpper() == "QUEST" && talking == true)
                {
                    INNFO = "TALK | INFO | BACK\n";
                    if (player.questReady && player.questfrom == world.ListPeople[talkingto].pindex)
                    {
                        PeopleOnPlace.Text = INNFO + "DONE - TO FINISH THE QUEST: " + world.ListPeople[talkingto].questname;
                    }
                    else if (!player.questReady && player.questactive && player.questfrom == world.ListPeople[talkingto].pindex)
                    {
                        PeopleOnPlace.Text = INNFO + "QUEST IS IN PROGRESS: " + world.ListPeople[talkingto].questname;
                    }
                    else
                    {
                        PeopleOnPlace.Text = INNFO + "GO - TO ACCEPT THE QUEST: " + world.ListPeople[talkingto].questname;
                    }
                }

                if (TerminalIN.Text.ToUpper() == "INFO" && talking == true)
                {
                    PeopleOnPlace.Text = "TALK | INFO | BACK\n" + world.ListPeople[talkingto].Info();
                }

                if (TerminalIN.Text.ToUpper() == "GO" && talking == true)
                {
                    TALKTO(talkingto, "");
                    player.Setcurrentquest(world.ListPeople[talkingto].questname, world.ListPeople[talkingto].questplace, talkingto);
                    world.ListPeople[talkingto].isQuestInProg = true;
                }

                if (TerminalIN.Text.ToUpper() == "BACK" && talking == true)
                {
                    TerminalIN.Text = "";
                    PeopleOnPlace.Text = "";
                    for (int i = 0; i < world.ListPlaces.Count; i++)
                    {
                        if (player.PXY.CurrentC() == world.ListPlaces[i].placeXY.CurrentC())
                        {
                            PlaceTitle.Text = world.ListPlaces[i].placename;
                            CommandLog.Text = "YOU'VE LANDED!\nINSERT THE NUMBER OF THE NPC\nYOU WISH TO INTERACT WITH";
                            talking = false;
                            inshop = false;
                            for (int o = 0; o < world.ListPeople.Count; o++)
                            {
                                if (world.ListPeople[o].Plindex == world.ListPlaces[i].plindex)
                                {
                                    PeopleOnPlace.ReadOnly = false;
                                    if (world.ListPeople[o].hasQuest == true)
                                        PeopleOnPlace.Text = PeopleOnPlace.Text + world.ListPeople[o].PlInIndex + " - " + world.ListPeople[o].name + " [Q] " + "\n";
                                    if (world.ListPeople[o].hasQuest == false)
                                        PeopleOnPlace.Text = PeopleOnPlace.Text + world.ListPeople[o].PlInIndex + " - " + world.ListPeople[o].name + "\n";
                                    PeopleOnPlace.ReadOnly = true;
                                }
                            }
                        }
                    }
                }

                else if (TerminalIN.Text.ToUpper() == "TALK" && talking == true)
                {
                    TALKTO(talkingto, world.ListPeople[talkingto].Talk());
                }

                else if (TerminalIN.Text.ToUpper() == "INFO" && talking == true)
                {
                    TALKTO(talkingto, world.ListPeople[talkingto].Info());
                }

                if (TerminalIN.Text.ToUpper() == "DONE" && talking == true && player.questReady == true && player.questfrom == talkingto)
                {
                    world.ListPeople[talkingto].hasQuest = false;
                    player.Questdone(world.r.Next(50, 100));
                    TALKTO(talkingto, world.ListPeople[talkingto].QuestDone());

                }

                else if (TerminalIN.Text.ToUpper() == "SHOP" && talking == true && world.ListPeople[talkingto].IsTrader)
                {
                    SHOPTO(talkingto);
                }

                else if (TerminalIN.Text.ToUpper() == "BACK" && landed == true)
                {
                    PlaceWindow.Visible = false;
                    MapWindow.Visible = true;
                    CommandLog.Text = "TAKEOFF!";
                    landed = false;
                }
                Stats.Text = player.ShowClearStats();
                SCAN();
                ////////////////////////////////////////
                //////////////////////////////////////////////////
                ////////////////////////////////////////////////////////////
                if (TerminalIN.Text.ToUpper() == "DEBUG")
                {
                    CommandLog.Text = "";
                    foreach (Enemies EN in world.ListEnemies)
                    {
                        CommandLog.Text = CommandLog.Text + "\n" +
                            EN.Ename + " | " + EN.Allegiance + " | " + EN.EXY.CurrentC();
                    }

                    //CommandLog.Text = player.questacitvename + " | " +
                    //player.questacitvetarget + " | " +
                    //world.ListPeople[player.questfrom].name + " | " + world.ListPeople[player.questfrom].pindex;

                    //for (int pp = 0; pp < world.ListPeople.Count; pp++)
                    //{
                    //    CommandLog.Text = CommandLog.Text + "\n" +
                    //        world.ListPeople[pp].name + " | " +
                    //        world.ListPeople[pp].pindex + " | " +
                    //        world.ListPeople[pp].hasQuest.ToString() + " | " +
                    //        world.ListPeople[pp].questplace + " | " +
                    //        world.ListPeople[pp].Plindex + " | " +
                    //        world.ListPeople[pp].IsTrader.ToString();
                    //}

                    //for (int i = 0; i < world.ListPlaces.Count; i++)
                    //{
                    //    CommandLog.Text = CommandLog.Text + "\n" +
                    //        world.ListPlaces[i].placename + " | " +
                    //        world.ListPlaces[i].plindex + " | " +
                    //        world.ListPlaces[i].placeXY.CurrentC();
                    //}
                }
                ////////////////////////////////////////////////////////////
                //////////////////////////////////////////////////
                ////////////////////////////////////////
                if (TerminalIN.Text.ToUpper() == "INV")
                {
                    CommandLog.Text = "INVENTORY:";
                    for (int inv = 0; inv < player.INV.InInv.Count; inv++)
                    {
                        if (player.INV.InInv[inv].Amount > 0)
                        {
                            CommandLog.Text = CommandLog.Text + "\n" +
                                player.INV.InInv[inv].Name + "  |  " +
                                player.INV.InInv[inv].Amount + "  |  " +
                                player.INV.InInv[inv].Desc;
                        }
                    }
                }

                foreach(Enemies EN in world.ListEnemies)
                {
                    Random R = new Random();
                    if(R.Next(0, 2) == 1)
                    {
                        EN.Move();
                    }
                }

            }
            catch (Exception) { CommandLog.Text = CommandLog.Text + "\nCOMMAND INCORRECT!"; }
            TerminalIN.Text = "";
            await Task.Delay(1);
        }

        public async void INSTR()
        {
            LogText1.Text =
                "MOVE ######:###### | Move to the given coordinates.\n" +
                "LAND | Land on the planet underneath you, if possible.\n" +
                "INV | Shows the inventory.\n" +
                "SHOP | Open the shop with the person you are talking to.\n" +
                "QUEST | Accept quest if the person you are talking to has one.\n" +
                "--------------------------------\n" +
                "This is your LOG, you can write here whatever you want.";
            for (int i = 0; i < world.ListPlaces.Count; i++)
            {
                if (world.ListPlaces[i].placename == "HQ")
                    LogText2.Text = "HQ: " + world.ListPlaces[i].placeXY.CurrentC() + "\n";
            }
            await Task.Delay(1);
        }

        public async void SCAN()
        {
            NearbyPlaces.Text = "Places Nearby:\n";
            for (int i = 0; i < world.ListPlaces.Count; i++)
            {
                if (player.PXY.X - 1000 <= world.ListPlaces[i].placeXY.X && player.PXY.X + 1000 >= world.ListPlaces[i].placeXY.X &&
                    player.PXY.Y - 1000 <= world.ListPlaces[i].placeXY.Y && player.PXY.Y + 1000 >= world.ListPlaces[i].placeXY.Y)
                {
                    NearbyPlaces.Text = NearbyPlaces.Text + world.ListPlaces[i].placename + " at: " + world.ListPlaces[i].placeXY.CurrentC() + "\n";
                }
            }
            NearbyPlaces.Text = NearbyPlaces.Text + "\nNearby Enemies:";
            for (int i = 0; i < world.ListEnemies.Count; i++)
            {
                if (player.PXY.X - 1000 <= world.ListEnemies[i].EXY.X && player.PXY.X + 1000 >= world.ListEnemies[i].EXY.X &&
                    player.PXY.Y - 1000 <= world.ListEnemies[i].EXY.Y && player.PXY.Y + 1000 >= world.ListEnemies[i].EXY.Y)
                {
                    NearbyPlaces.Text = NearbyPlaces.Text + world.ListEnemies[i].Ename + " " + world.ListEnemies[i].Allegiance + " at: " + world.ListEnemies[i].EXY.CurrentC() + "\n";
                }
            }
            await Task.Delay(1);
        }

        public async void TALKTO(int i, String text)
        {
            talkingto = world.ListPeople[i].pindex;
            PlaceTitle.Text = world.ListPeople[i].name;
            CommandLog.Text = "PLEASE ENTER YOUR ACTION!";
            talking = true;
            PeopleOnPlace.ReadOnly = false;
            if (world.ListPeople[i].hasQuest == true)
            { PeopleOnPlace.Text = "TALK | INFO | BACK" + "\nQUEST | " + world.ListPeople[i].questname + "\n" + text; }
            else if (world.ListPeople[i].IsTrader == true)
            { PeopleOnPlace.Text = "TALK | INFO | BACK" + "\nSHOP" + "\n" + text; }
            else
            { PeopleOnPlace.Text = "TALK | INFO | BACK\n" + text; }
            PeopleOnPlace.ReadOnly = true;
            await Task.Delay(1);
        }

        public async void SHOPTO(int i)
        {
            PlaceTitle.Text = world.ListPeople[i].name;
            CommandLog.Text = "PLEASE ENTER YOUR ACTION!\n{ITEM} {AMOUNT} | TO BUY THE DESIRED ITEM\n";
            CommandLog.Text = CommandLog.Text + "\nINVENTORY:";
            for (int inv = 0; inv < player.INV.InInv.Count; inv++)
            {
                if (player.INV.InInv[inv].Amount > 0)
                {
                    CommandLog.Text = CommandLog.Text + "\n" +
                        player.INV.InInv[inv].Name + "  |  " +
                        player.INV.InInv[inv].Amount + "  |  " +
                        player.INV.InInv[inv].Desc;
                }
            }
            talking = true;
            inshop = true;
            PeopleOnPlace.ReadOnly = false;
            PeopleOnPlace.Text = "TALK | INFO | BACK\n";
            PeopleOnPlace.Text = PeopleOnPlace.Text + "NAME  |  IN STOCK  |  VALUE  |  DESCRIPTION\n";
            for (int io = 0; io < world.ListPeople[i].INNV.InInv.Count; io++)
            {
                PeopleOnPlace.Text = PeopleOnPlace.Text + world.ListPeople[i].INNV.InInv[io].Name + "  |  " +
                    world.ListPeople[i].INNV.InInv[io].Amount + "  |  " + world.ListPeople[i].INNV.InInv[io].Value + "  |  " +
                    world.ListPeople[i].INNV.InInv[io].Desc + "\n";
            }
            PeopleOnPlace.ReadOnly = true;
            await Task.Delay(1);
        }
    }
}
