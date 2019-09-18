namespace InDepthWin
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.StatsWindow = new System.Windows.Forms.Panel();
            this.Stats = new System.Windows.Forms.Label();
            this.MapWindow = new System.Windows.Forms.Panel();
            this.NearbyPlaces = new System.Windows.Forms.RichTextBox();
            this.MapTitle = new System.Windows.Forms.Label();
            this.LoggingWindow = new System.Windows.Forms.Panel();
            this.Log = new System.Windows.Forms.TabControl();
            this.Log1 = new System.Windows.Forms.TabPage();
            this.LogText1 = new System.Windows.Forms.RichTextBox();
            this.Log2 = new System.Windows.Forms.TabPage();
            this.LogText2 = new System.Windows.Forms.RichTextBox();
            this.LogTitle = new System.Windows.Forms.Label();
            this.TerminalWindow = new System.Windows.Forms.Panel();
            this.TerminalTitle = new System.Windows.Forms.Label();
            this.CommandLog = new System.Windows.Forms.RichTextBox();
            this.TerminalIN = new System.Windows.Forms.TextBox();
            this.StartWindow = new System.Windows.Forms.Panel();
            this.StartBtn = new System.Windows.Forms.Button();
            this.SnameLabel = new System.Windows.Forms.Label();
            this.PnameLabel = new System.Windows.Forms.Label();
            this.CPMCselect = new System.Windows.Forms.RadioButton();
            this.RUOPselect = new System.Windows.Forms.RadioButton();
            this.TSIBselect = new System.Windows.Forms.RadioButton();
            this.NLFDselect = new System.Windows.Forms.RadioButton();
            this.CONMselect = new System.Windows.Forms.RadioButton();
            this.AOBOselect = new System.Windows.Forms.RadioButton();
            this.UEDFselect = new System.Windows.Forms.RadioButton();
            this.PlayerShipIN = new System.Windows.Forms.TextBox();
            this.PlayerNameIN = new System.Windows.Forms.TextBox();
            this.progressBarStart = new System.Windows.Forms.ProgressBar();
            this.PlaceWindow = new System.Windows.Forms.Panel();
            this.PeopleOnPlace = new System.Windows.Forms.RichTextBox();
            this.PlaceTitle = new System.Windows.Forms.Label();
            this.BattleWindow = new System.Windows.Forms.Panel();
            this.TESTOBJ = new System.Windows.Forms.Label();
            this.BattleTitle = new System.Windows.Forms.Label();
            this.BattleTimer = new System.Windows.Forms.Timer(this.components);
            this.HostileLabel = new System.Windows.Forms.Label();
            this.ExplenationLabel = new System.Windows.Forms.Label();
            this.StatsWindow.SuspendLayout();
            this.MapWindow.SuspendLayout();
            this.LoggingWindow.SuspendLayout();
            this.Log.SuspendLayout();
            this.Log1.SuspendLayout();
            this.Log2.SuspendLayout();
            this.TerminalWindow.SuspendLayout();
            this.StartWindow.SuspendLayout();
            this.PlaceWindow.SuspendLayout();
            this.BattleWindow.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatsWindow
            // 
            this.StatsWindow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StatsWindow.Controls.Add(this.Stats);
            this.StatsWindow.Location = new System.Drawing.Point(0, 0);
            this.StatsWindow.Name = "StatsWindow";
            this.StatsWindow.Size = new System.Drawing.Size(400, 300);
            this.StatsWindow.TabIndex = 0;
            // 
            // Stats
            // 
            this.Stats.AutoSize = true;
            this.Stats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stats.Location = new System.Drawing.Point(0, 0);
            this.Stats.Name = "Stats";
            this.Stats.Size = new System.Drawing.Size(130, 16);
            this.Stats.TabIndex = 0;
            this.Stats.Text = "StatsPlaceHolder";
            // 
            // MapWindow
            // 
            this.MapWindow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MapWindow.Controls.Add(this.NearbyPlaces);
            this.MapWindow.Controls.Add(this.MapTitle);
            this.MapWindow.Location = new System.Drawing.Point(400, 0);
            this.MapWindow.Name = "MapWindow";
            this.MapWindow.Size = new System.Drawing.Size(400, 300);
            this.MapWindow.TabIndex = 0;
            // 
            // NearbyPlaces
            // 
            this.NearbyPlaces.BackColor = System.Drawing.Color.White;
            this.NearbyPlaces.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NearbyPlaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NearbyPlaces.Location = new System.Drawing.Point(3, 20);
            this.NearbyPlaces.Name = "NearbyPlaces";
            this.NearbyPlaces.ReadOnly = true;
            this.NearbyPlaces.Size = new System.Drawing.Size(390, 273);
            this.NearbyPlaces.TabIndex = 1;
            this.NearbyPlaces.Text = "";
            // 
            // MapTitle
            // 
            this.MapTitle.AutoSize = true;
            this.MapTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MapTitle.Location = new System.Drawing.Point(0, 0);
            this.MapTitle.Name = "MapTitle";
            this.MapTitle.Size = new System.Drawing.Size(38, 16);
            this.MapTitle.TabIndex = 0;
            this.MapTitle.Text = "Map";
            // 
            // LoggingWindow
            // 
            this.LoggingWindow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LoggingWindow.Controls.Add(this.Log);
            this.LoggingWindow.Controls.Add(this.LogTitle);
            this.LoggingWindow.Location = new System.Drawing.Point(0, 300);
            this.LoggingWindow.Name = "LoggingWindow";
            this.LoggingWindow.Size = new System.Drawing.Size(400, 300);
            this.LoggingWindow.TabIndex = 0;
            // 
            // Log
            // 
            this.Log.Controls.Add(this.Log1);
            this.Log.Controls.Add(this.Log2);
            this.Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log.Location = new System.Drawing.Point(3, 20);
            this.Log.Name = "Log";
            this.Log.SelectedIndex = 0;
            this.Log.Size = new System.Drawing.Size(395, 278);
            this.Log.TabIndex = 2;
            // 
            // Log1
            // 
            this.Log1.Controls.Add(this.LogText1);
            this.Log1.Location = new System.Drawing.Point(4, 22);
            this.Log1.Name = "Log1";
            this.Log1.Padding = new System.Windows.Forms.Padding(3);
            this.Log1.Size = new System.Drawing.Size(387, 252);
            this.Log1.TabIndex = 0;
            this.Log1.Text = "Log1";
            this.Log1.UseVisualStyleBackColor = true;
            // 
            // LogText1
            // 
            this.LogText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogText1.Location = new System.Drawing.Point(0, 0);
            this.LogText1.Name = "LogText1";
            this.LogText1.Size = new System.Drawing.Size(387, 252);
            this.LogText1.TabIndex = 1;
            this.LogText1.Text = "";
            // 
            // Log2
            // 
            this.Log2.Controls.Add(this.LogText2);
            this.Log2.Location = new System.Drawing.Point(4, 22);
            this.Log2.Name = "Log2";
            this.Log2.Padding = new System.Windows.Forms.Padding(3);
            this.Log2.Size = new System.Drawing.Size(387, 252);
            this.Log2.TabIndex = 1;
            this.Log2.Text = "Log2";
            this.Log2.UseVisualStyleBackColor = true;
            // 
            // LogText2
            // 
            this.LogText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogText2.Location = new System.Drawing.Point(0, 0);
            this.LogText2.Name = "LogText2";
            this.LogText2.Size = new System.Drawing.Size(387, 252);
            this.LogText2.TabIndex = 2;
            this.LogText2.Text = "";
            // 
            // LogTitle
            // 
            this.LogTitle.AutoSize = true;
            this.LogTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogTitle.Location = new System.Drawing.Point(0, 0);
            this.LogTitle.Name = "LogTitle";
            this.LogTitle.Size = new System.Drawing.Size(34, 16);
            this.LogTitle.TabIndex = 0;
            this.LogTitle.Text = "Log";
            // 
            // TerminalWindow
            // 
            this.TerminalWindow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TerminalWindow.Controls.Add(this.TerminalTitle);
            this.TerminalWindow.Controls.Add(this.CommandLog);
            this.TerminalWindow.Controls.Add(this.TerminalIN);
            this.TerminalWindow.Location = new System.Drawing.Point(400, 300);
            this.TerminalWindow.Name = "TerminalWindow";
            this.TerminalWindow.Size = new System.Drawing.Size(400, 300);
            this.TerminalWindow.TabIndex = 0;
            // 
            // TerminalTitle
            // 
            this.TerminalTitle.AutoSize = true;
            this.TerminalTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TerminalTitle.Location = new System.Drawing.Point(0, 0);
            this.TerminalTitle.Name = "TerminalTitle";
            this.TerminalTitle.Size = new System.Drawing.Size(69, 16);
            this.TerminalTitle.TabIndex = 0;
            this.TerminalTitle.Text = "Terminal";
            // 
            // CommandLog
            // 
            this.CommandLog.BackColor = System.Drawing.Color.White;
            this.CommandLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CommandLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommandLog.Location = new System.Drawing.Point(3, 20);
            this.CommandLog.Name = "CommandLog";
            this.CommandLog.ReadOnly = true;
            this.CommandLog.Size = new System.Drawing.Size(390, 247);
            this.CommandLog.TabIndex = 1;
            this.CommandLog.Text = "";
            // 
            // TerminalIN
            // 
            this.TerminalIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TerminalIN.Location = new System.Drawing.Point(4, 272);
            this.TerminalIN.Name = "TerminalIN";
            this.TerminalIN.Size = new System.Drawing.Size(388, 20);
            this.TerminalIN.TabIndex = 0;
            this.TerminalIN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AutoComplete);
            this.TerminalIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SendCommando);
            // 
            // StartWindow
            // 
            this.StartWindow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StartWindow.Controls.Add(this.ExplenationLabel);
            this.StartWindow.Controls.Add(this.HostileLabel);
            this.StartWindow.Controls.Add(this.StartBtn);
            this.StartWindow.Controls.Add(this.SnameLabel);
            this.StartWindow.Controls.Add(this.PnameLabel);
            this.StartWindow.Controls.Add(this.CPMCselect);
            this.StartWindow.Controls.Add(this.RUOPselect);
            this.StartWindow.Controls.Add(this.TSIBselect);
            this.StartWindow.Controls.Add(this.NLFDselect);
            this.StartWindow.Controls.Add(this.CONMselect);
            this.StartWindow.Controls.Add(this.AOBOselect);
            this.StartWindow.Controls.Add(this.UEDFselect);
            this.StartWindow.Controls.Add(this.PlayerShipIN);
            this.StartWindow.Controls.Add(this.PlayerNameIN);
            this.StartWindow.Controls.Add(this.progressBarStart);
            this.StartWindow.Location = new System.Drawing.Point(0, 606);
            this.StartWindow.Name = "StartWindow";
            this.StartWindow.Size = new System.Drawing.Size(400, 300);
            this.StartWindow.TabIndex = 0;
            // 
            // StartBtn
            // 
            this.StartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBtn.Location = new System.Drawing.Point(317, 268);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 23);
            this.StartBtn.TabIndex = 3;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.OnPressedStart);
            // 
            // SnameLabel
            // 
            this.SnameLabel.AutoSize = true;
            this.SnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SnameLabel.Location = new System.Drawing.Point(3, 29);
            this.SnameLabel.Name = "SnameLabel";
            this.SnameLabel.Size = new System.Drawing.Size(88, 16);
            this.SnameLabel.TabIndex = 2;
            this.SnameLabel.Text = "Ship Name:";
            // 
            // PnameLabel
            // 
            this.PnameLabel.AutoSize = true;
            this.PnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnameLabel.Location = new System.Drawing.Point(3, 4);
            this.PnameLabel.Name = "PnameLabel";
            this.PnameLabel.Size = new System.Drawing.Size(102, 16);
            this.PnameLabel.TabIndex = 2;
            this.PnameLabel.Text = "Player Name:";
            // 
            // CPMCselect
            // 
            this.CPMCselect.AutoSize = true;
            this.CPMCselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPMCselect.Location = new System.Drawing.Point(202, 100);
            this.CPMCselect.Name = "CPMCselect";
            this.CPMCselect.Size = new System.Drawing.Size(59, 17);
            this.CPMCselect.TabIndex = 1;
            this.CPMCselect.TabStop = true;
            this.CPMCselect.Text = "CPMC";
            this.CPMCselect.UseVisualStyleBackColor = true;
            // 
            // RUOPselect
            // 
            this.RUOPselect.AutoSize = true;
            this.RUOPselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RUOPselect.Location = new System.Drawing.Point(202, 77);
            this.RUOPselect.Name = "RUOPselect";
            this.RUOPselect.Size = new System.Drawing.Size(60, 17);
            this.RUOPselect.TabIndex = 1;
            this.RUOPselect.TabStop = true;
            this.RUOPselect.Text = "RUOP";
            this.RUOPselect.UseVisualStyleBackColor = true;
            // 
            // TSIBselect
            // 
            this.TSIBselect.AutoSize = true;
            this.TSIBselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSIBselect.Location = new System.Drawing.Point(202, 54);
            this.TSIBselect.Name = "TSIBselect";
            this.TSIBselect.Size = new System.Drawing.Size(53, 17);
            this.TSIBselect.TabIndex = 1;
            this.TSIBselect.TabStop = true;
            this.TSIBselect.Text = "TSIB";
            this.TSIBselect.UseVisualStyleBackColor = true;
            // 
            // NLFDselect
            // 
            this.NLFDselect.AutoSize = true;
            this.NLFDselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NLFDselect.Location = new System.Drawing.Point(111, 123);
            this.NLFDselect.Name = "NLFDselect";
            this.NLFDselect.Size = new System.Drawing.Size(57, 17);
            this.NLFDselect.TabIndex = 1;
            this.NLFDselect.TabStop = true;
            this.NLFDselect.Text = "NLFD";
            this.NLFDselect.UseVisualStyleBackColor = true;
            // 
            // CONMselect
            // 
            this.CONMselect.AutoSize = true;
            this.CONMselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CONMselect.Location = new System.Drawing.Point(111, 100);
            this.CONMselect.Name = "CONMselect";
            this.CONMselect.Size = new System.Drawing.Size(61, 17);
            this.CONMselect.TabIndex = 1;
            this.CONMselect.TabStop = true;
            this.CONMselect.Text = "CONM";
            this.CONMselect.UseVisualStyleBackColor = true;
            // 
            // AOBOselect
            // 
            this.AOBOselect.AutoSize = true;
            this.AOBOselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AOBOselect.Location = new System.Drawing.Point(111, 77);
            this.AOBOselect.Name = "AOBOselect";
            this.AOBOselect.Size = new System.Drawing.Size(59, 17);
            this.AOBOselect.TabIndex = 1;
            this.AOBOselect.TabStop = true;
            this.AOBOselect.Text = "AOBO";
            this.AOBOselect.UseVisualStyleBackColor = true;
            // 
            // UEDFselect
            // 
            this.UEDFselect.AutoSize = true;
            this.UEDFselect.Checked = true;
            this.UEDFselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UEDFselect.Location = new System.Drawing.Point(111, 54);
            this.UEDFselect.Name = "UEDFselect";
            this.UEDFselect.Size = new System.Drawing.Size(58, 17);
            this.UEDFselect.TabIndex = 1;
            this.UEDFselect.TabStop = true;
            this.UEDFselect.Text = "UEDF";
            this.UEDFselect.UseVisualStyleBackColor = true;
            // 
            // PlayerShipIN
            // 
            this.PlayerShipIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerShipIN.Location = new System.Drawing.Point(111, 28);
            this.PlayerShipIN.Name = "PlayerShipIN";
            this.PlayerShipIN.Size = new System.Drawing.Size(100, 20);
            this.PlayerShipIN.TabIndex = 0;
            // 
            // PlayerNameIN
            // 
            this.PlayerNameIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerNameIN.Location = new System.Drawing.Point(111, 3);
            this.PlayerNameIN.Name = "PlayerNameIN";
            this.PlayerNameIN.Size = new System.Drawing.Size(100, 20);
            this.PlayerNameIN.TabIndex = 0;
            // 
            // progressBarStart
            // 
            this.progressBarStart.ForeColor = System.Drawing.Color.Red;
            this.progressBarStart.Location = new System.Drawing.Point(5, 122);
            this.progressBarStart.MarqueeAnimationSpeed = 2;
            this.progressBarStart.Maximum = 7;
            this.progressBarStart.Name = "progressBarStart";
            this.progressBarStart.Size = new System.Drawing.Size(386, 20);
            this.progressBarStart.Step = 1;
            this.progressBarStart.TabIndex = 4;
            this.progressBarStart.Visible = false;
            // 
            // PlaceWindow
            // 
            this.PlaceWindow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PlaceWindow.Controls.Add(this.PeopleOnPlace);
            this.PlaceWindow.Controls.Add(this.PlaceTitle);
            this.PlaceWindow.Location = new System.Drawing.Point(400, 606);
            this.PlaceWindow.Name = "PlaceWindow";
            this.PlaceWindow.Size = new System.Drawing.Size(400, 300);
            this.PlaceWindow.TabIndex = 0;
            // 
            // PeopleOnPlace
            // 
            this.PeopleOnPlace.BackColor = System.Drawing.Color.White;
            this.PeopleOnPlace.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PeopleOnPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PeopleOnPlace.Location = new System.Drawing.Point(3, 20);
            this.PeopleOnPlace.Name = "PeopleOnPlace";
            this.PeopleOnPlace.ReadOnly = true;
            this.PeopleOnPlace.Size = new System.Drawing.Size(390, 273);
            this.PeopleOnPlace.TabIndex = 1;
            this.PeopleOnPlace.Text = "";
            // 
            // PlaceTitle
            // 
            this.PlaceTitle.AutoSize = true;
            this.PlaceTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaceTitle.Location = new System.Drawing.Point(0, 0);
            this.PlaceTitle.Name = "PlaceTitle";
            this.PlaceTitle.Size = new System.Drawing.Size(92, 16);
            this.PlaceTitle.TabIndex = 0;
            this.PlaceTitle.Text = "Placeholder";
            // 
            // BattleWindow
            // 
            this.BattleWindow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BattleWindow.Controls.Add(this.TESTOBJ);
            this.BattleWindow.Controls.Add(this.BattleTitle);
            this.BattleWindow.Location = new System.Drawing.Point(800, 0);
            this.BattleWindow.Name = "BattleWindow";
            this.BattleWindow.Size = new System.Drawing.Size(400, 300);
            this.BattleWindow.TabIndex = 0;
            // 
            // TESTOBJ
            // 
            this.TESTOBJ.AutoSize = true;
            this.TESTOBJ.Location = new System.Drawing.Point(178, 247);
            this.TESTOBJ.Name = "TESTOBJ";
            this.TESTOBJ.Size = new System.Drawing.Size(29, 13);
            this.TESTOBJ.TabIndex = 1;
            this.TESTOBJ.Text = "[||||||||]";
            // 
            // BattleTitle
            // 
            this.BattleTitle.AutoSize = true;
            this.BattleTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BattleTitle.Location = new System.Drawing.Point(0, 0);
            this.BattleTitle.Name = "BattleTitle";
            this.BattleTitle.Size = new System.Drawing.Size(67, 16);
            this.BattleTitle.TabIndex = 0;
            this.BattleTitle.Text = "Fighting:";
            // 
            // BattleTimer
            // 
            this.BattleTimer.Interval = 1000;
            // 
            // HostileLabel
            // 
            this.HostileLabel.AutoSize = true;
            this.HostileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HostileLabel.ForeColor = System.Drawing.Color.Red;
            this.HostileLabel.Location = new System.Drawing.Point(210, 123);
            this.HostileLabel.Name = "HostileLabel";
            this.HostileLabel.Size = new System.Drawing.Size(52, 15);
            this.HostileLabel.TabIndex = 5;
            this.HostileLabel.Text = "Hostile";
            // 
            // ExplenationLabel
            // 
            this.ExplenationLabel.AutoSize = true;
            this.ExplenationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExplenationLabel.Location = new System.Drawing.Point(5, 149);
            this.ExplenationLabel.Name = "ExplenationLabel";
            this.ExplenationLabel.Size = new System.Drawing.Size(50, 16);
            this.ExplenationLabel.TabIndex = 6;
            this.ExplenationLabel.Text = "Swoot";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 911);
            this.Controls.Add(this.PlaceWindow);
            this.Controls.Add(this.BattleWindow);
            this.Controls.Add(this.MapWindow);
            this.Controls.Add(this.TerminalWindow);
            this.Controls.Add(this.StartWindow);
            this.Controls.Add(this.LoggingWindow);
            this.Controls.Add(this.StatsWindow);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "InDepth";
            this.StatsWindow.ResumeLayout(false);
            this.StatsWindow.PerformLayout();
            this.MapWindow.ResumeLayout(false);
            this.MapWindow.PerformLayout();
            this.LoggingWindow.ResumeLayout(false);
            this.LoggingWindow.PerformLayout();
            this.Log.ResumeLayout(false);
            this.Log1.ResumeLayout(false);
            this.Log2.ResumeLayout(false);
            this.TerminalWindow.ResumeLayout(false);
            this.TerminalWindow.PerformLayout();
            this.StartWindow.ResumeLayout(false);
            this.StartWindow.PerformLayout();
            this.PlaceWindow.ResumeLayout(false);
            this.PlaceWindow.PerformLayout();
            this.BattleWindow.ResumeLayout(false);
            this.BattleWindow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel StatsWindow;
        private System.Windows.Forms.Panel MapWindow;
        private System.Windows.Forms.Panel LoggingWindow;
        private System.Windows.Forms.Panel TerminalWindow;
        private System.Windows.Forms.Panel StartWindow;
        private System.Windows.Forms.TextBox PlayerNameIN;
        private System.Windows.Forms.TextBox PlayerShipIN;
        private System.Windows.Forms.RadioButton CPMCselect;
        private System.Windows.Forms.RadioButton RUOPselect;
        private System.Windows.Forms.RadioButton TSIBselect;
        private System.Windows.Forms.RadioButton NLFDselect;
        private System.Windows.Forms.RadioButton CONMselect;
        private System.Windows.Forms.RadioButton AOBOselect;
        private System.Windows.Forms.RadioButton UEDFselect;
        private System.Windows.Forms.TextBox TerminalIN;
        private System.Windows.Forms.RichTextBox CommandLog;
        private System.Windows.Forms.Label MapTitle;
        private System.Windows.Forms.Label TerminalTitle;
        private System.Windows.Forms.Label Stats;
        private System.Windows.Forms.Panel PlaceWindow;
        private System.Windows.Forms.Label PlaceTitle;
        private System.Windows.Forms.Label LogTitle;
        private System.Windows.Forms.RichTextBox LogText1;
        private System.Windows.Forms.RichTextBox NearbyPlaces;
        private System.Windows.Forms.RichTextBox PeopleOnPlace;
        private System.Windows.Forms.Label SnameLabel;
        private System.Windows.Forms.Label PnameLabel;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.TabControl Log;
        private System.Windows.Forms.TabPage Log1;
        private System.Windows.Forms.TabPage Log2;
        private System.Windows.Forms.RichTextBox LogText2;
        private System.Windows.Forms.ProgressBar progressBarStart;
        private System.Windows.Forms.Panel BattleWindow;
        private System.Windows.Forms.Label BattleTitle;
        private System.Windows.Forms.Timer BattleTimer;
        private System.Windows.Forms.Label TESTOBJ;
        private System.Windows.Forms.Label ExplenationLabel;
        private System.Windows.Forms.Label HostileLabel;
    }
}

