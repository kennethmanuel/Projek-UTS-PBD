namespace Tournament_Manager
{
    partial class FormMenu
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
            this.menuStripControl = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tournamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAnotherTournamentFromDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateTournamentStartingBracketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playersTeamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamAndPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTournamentPrizesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelTournament = new System.Windows.Forms.Label();
            this.labelTournamentValue = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonViewPlayer = new System.Windows.Forms.Button();
            this.buttonViewTeam = new System.Windows.Forms.Button();
            this.buttonView = new System.Windows.Forms.Button();
            this.buttonViewMatchups = new System.Windows.Forms.Button();
            this.buttonMatchupEntries = new System.Windows.Forms.Button();
            this.buttonViewPairing = new System.Windows.Forms.Button();
            this.linkLabelAbout = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxInfo = new System.Windows.Forms.ListBox();
            this.dataGridViewLeaderboard = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStripControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeaderboard)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripControl
            // 
            this.menuStripControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(153)))), ((int)(((byte)(132)))));
            this.menuStripControl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStripControl.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.tournamentToolStripMenuItem,
            this.playersTeamsToolStripMenuItem,
            this.viewTournamentPrizesToolStripMenuItem});
            this.menuStripControl.Location = new System.Drawing.Point(0, 0);
            this.menuStripControl.Name = "menuStripControl";
            this.menuStripControl.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStripControl.Size = new System.Drawing.Size(1061, 31);
            this.menuStripControl.TabIndex = 1;
            this.menuStripControl.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 27);
            // 
            // tournamentToolStripMenuItem
            // 
            this.tournamentToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(153)))), ((int)(((byte)(132)))));
            this.tournamentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadAnotherTournamentFromDatabaseToolStripMenuItem,
            this.generateTournamentStartingBracketToolStripMenuItem,
            this.pairToolStripMenuItem});
            this.tournamentToolStripMenuItem.Name = "tournamentToolStripMenuItem";
            this.tournamentToolStripMenuItem.Size = new System.Drawing.Size(116, 27);
            this.tournamentToolStripMenuItem.Text = "Tournament";
            // 
            // loadAnotherTournamentFromDatabaseToolStripMenuItem
            // 
            this.loadAnotherTournamentFromDatabaseToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(153)))), ((int)(((byte)(132)))));
            this.loadAnotherTournamentFromDatabaseToolStripMenuItem.Name = "loadAnotherTournamentFromDatabaseToolStripMenuItem";
            this.loadAnotherTournamentFromDatabaseToolStripMenuItem.Size = new System.Drawing.Size(407, 28);
            this.loadAnotherTournamentFromDatabaseToolStripMenuItem.Text = "Load another tournament from database";
            this.loadAnotherTournamentFromDatabaseToolStripMenuItem.Click += new System.EventHandler(this.loadAnotherTournamentFromDatabaseToolStripMenuItem_Click);
            // 
            // generateTournamentStartingBracketToolStripMenuItem
            // 
            this.generateTournamentStartingBracketToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(153)))), ((int)(((byte)(132)))));
            this.generateTournamentStartingBracketToolStripMenuItem.Name = "generateTournamentStartingBracketToolStripMenuItem";
            this.generateTournamentStartingBracketToolStripMenuItem.Size = new System.Drawing.Size(407, 28);
            this.generateTournamentStartingBracketToolStripMenuItem.Text = "Quick generate tournament pairing";
            this.generateTournamentStartingBracketToolStripMenuItem.Click += new System.EventHandler(this.generateTournamentStartingBracketToolStripMenuItem_Click);
            // 
            // pairToolStripMenuItem
            // 
            this.pairToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(153)))), ((int)(((byte)(132)))));
            this.pairToolStripMenuItem.Name = "pairToolStripMenuItem";
            this.pairToolStripMenuItem.Size = new System.Drawing.Size(407, 28);
            this.pairToolStripMenuItem.Text = "Pair";
            this.pairToolStripMenuItem.Click += new System.EventHandler(this.pairToolStripMenuItem_Click);
            // 
            // playersTeamsToolStripMenuItem
            // 
            this.playersTeamsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teamAndPlayerToolStripMenuItem,
            this.matchToolStripMenuItem});
            this.playersTeamsToolStripMenuItem.Name = "playersTeamsToolStripMenuItem";
            this.playersTeamsToolStripMenuItem.Size = new System.Drawing.Size(101, 27);
            this.playersTeamsToolStripMenuItem.Text = "View Data";
            // 
            // teamAndPlayerToolStripMenuItem
            // 
            this.teamAndPlayerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(153)))), ((int)(((byte)(132)))));
            this.teamAndPlayerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.teamAndPlayerToolStripMenuItem.Name = "teamAndPlayerToolStripMenuItem";
            this.teamAndPlayerToolStripMenuItem.Size = new System.Drawing.Size(220, 28);
            this.teamAndPlayerToolStripMenuItem.Text = "Team and Player";
            this.teamAndPlayerToolStripMenuItem.Click += new System.EventHandler(this.teamAndPlayerToolStripMenuItem_Click);
            // 
            // matchToolStripMenuItem
            // 
            this.matchToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(153)))), ((int)(((byte)(132)))));
            this.matchToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.matchToolStripMenuItem.Name = "matchToolStripMenuItem";
            this.matchToolStripMenuItem.Size = new System.Drawing.Size(220, 28);
            this.matchToolStripMenuItem.Text = "Match and Entry";
            this.matchToolStripMenuItem.Click += new System.EventHandler(this.matchToolStripMenuItem_Click_1);
            // 
            // viewTournamentPrizesToolStripMenuItem
            // 
            this.viewTournamentPrizesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prizeToolStripMenuItem});
            this.viewTournamentPrizesToolStripMenuItem.Name = "viewTournamentPrizesToolStripMenuItem";
            this.viewTournamentPrizesToolStripMenuItem.Size = new System.Drawing.Size(206, 27);
            this.viewTournamentPrizesToolStripMenuItem.Text = "View Tournament Prizes";
            // 
            // prizeToolStripMenuItem
            // 
            this.prizeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(153)))), ((int)(((byte)(132)))));
            this.prizeToolStripMenuItem.Name = "prizeToolStripMenuItem";
            this.prizeToolStripMenuItem.Size = new System.Drawing.Size(131, 28);
            this.prizeToolStripMenuItem.Text = "Prize";
            this.prizeToolStripMenuItem.Click += new System.EventHandler(this.prizeToolStripMenuItem_Click);
            // 
            // labelTournament
            // 
            this.labelTournament.AutoSize = true;
            this.labelTournament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(153)))), ((int)(((byte)(132)))));
            this.labelTournament.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTournament.Location = new System.Drawing.Point(568, 5);
            this.labelTournament.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTournament.Name = "labelTournament";
            this.labelTournament.Size = new System.Drawing.Size(231, 23);
            this.labelTournament.TabIndex = 2;
            this.labelTournament.Text = "Currenty Edited Tournament:";
            // 
            // labelTournamentValue
            // 
            this.labelTournamentValue.AutoSize = true;
            this.labelTournamentValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.labelTournamentValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTournamentValue.Location = new System.Drawing.Point(807, 5);
            this.labelTournamentValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTournamentValue.Name = "labelTournamentValue";
            this.labelTournamentValue.Size = new System.Drawing.Size(175, 23);
            this.labelTournamentValue.TabIndex = 3;
            this.labelTournamentValue.Text = "<tournament_name>";
            this.labelTournamentValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(36)))), ((int)(((byte)(29)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonDelete.Location = new System.Drawing.Point(708, 570);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(314, 39);
            this.buttonDelete.TabIndex = 24;
            this.buttonDelete.Text = "Delete Current Tournament";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonViewPlayer
            // 
            this.buttonViewPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(133)))), ((int)(((byte)(136)))));
            this.buttonViewPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewPlayer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonViewPlayer.Location = new System.Drawing.Point(51, 205);
            this.buttonViewPlayer.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.buttonViewPlayer.Name = "buttonViewPlayer";
            this.buttonViewPlayer.Size = new System.Drawing.Size(314, 39);
            this.buttonViewPlayer.TabIndex = 25;
            this.buttonViewPlayer.Text = "♚View Participating Player ♚";
            this.buttonViewPlayer.UseVisualStyleBackColor = false;
            this.buttonViewPlayer.Click += new System.EventHandler(this.buttonViewPlayer_Click);
            // 
            // buttonViewTeam
            // 
            this.buttonViewTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(98)))), ((int)(((byte)(134)))));
            this.buttonViewTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewTeam.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonViewTeam.Location = new System.Drawing.Point(51, 266);
            this.buttonViewTeam.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.buttonViewTeam.Name = "buttonViewTeam";
            this.buttonViewTeam.Size = new System.Drawing.Size(314, 39);
            this.buttonViewTeam.TabIndex = 26;
            this.buttonViewTeam.Text = "♛View Participating Team ♛";
            this.buttonViewTeam.UseVisualStyleBackColor = false;
            this.buttonViewTeam.Click += new System.EventHandler(this.buttonViewTeam_Click);
            // 
            // buttonView
            // 
            this.buttonView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(151)))), ((int)(((byte)(26)))));
            this.buttonView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonView.Location = new System.Drawing.Point(51, 323);
            this.buttonView.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(314, 39);
            this.buttonView.TabIndex = 27;
            this.buttonView.Text = "♜View Prize ♜";
            this.buttonView.UseVisualStyleBackColor = false;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // buttonViewMatchups
            // 
            this.buttonViewMatchups.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(153)))), ((int)(((byte)(33)))));
            this.buttonViewMatchups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewMatchups.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonViewMatchups.Location = new System.Drawing.Point(51, 381);
            this.buttonViewMatchups.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.buttonViewMatchups.Name = "buttonViewMatchups";
            this.buttonViewMatchups.Size = new System.Drawing.Size(314, 39);
            this.buttonViewMatchups.TabIndex = 28;
            this.buttonViewMatchups.Text = "♝ View Matchups ♝";
            this.buttonViewMatchups.UseVisualStyleBackColor = false;
            this.buttonViewMatchups.Click += new System.EventHandler(this.buttonViewMatchups_Click);
            // 
            // buttonMatchupEntries
            // 
            this.buttonMatchupEntries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(157)))), ((int)(((byte)(106)))));
            this.buttonMatchupEntries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMatchupEntries.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonMatchupEntries.Location = new System.Drawing.Point(51, 442);
            this.buttonMatchupEntries.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.buttonMatchupEntries.Name = "buttonMatchupEntries";
            this.buttonMatchupEntries.Size = new System.Drawing.Size(314, 39);
            this.buttonMatchupEntries.TabIndex = 29;
            this.buttonMatchupEntries.Text = "♞View Matchup Entries♞";
            this.buttonMatchupEntries.UseVisualStyleBackColor = false;
            this.buttonMatchupEntries.Click += new System.EventHandler(this.buttonMatchupEntries_Click);
            // 
            // buttonViewPairing
            // 
            this.buttonViewPairing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(93)))), ((int)(((byte)(14)))));
            this.buttonViewPairing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewPairing.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonViewPairing.Location = new System.Drawing.Point(51, 500);
            this.buttonViewPairing.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.buttonViewPairing.Name = "buttonViewPairing";
            this.buttonViewPairing.Size = new System.Drawing.Size(314, 39);
            this.buttonViewPairing.TabIndex = 30;
            this.buttonViewPairing.Text = "♟Generate Pairing ♟";
            this.buttonViewPairing.UseVisualStyleBackColor = false;
            this.buttonViewPairing.Click += new System.EventHandler(this.buttonViewPairing_Click);
            // 
            // linkLabelAbout
            // 
            this.linkLabelAbout.AutoSize = true;
            this.linkLabelAbout.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.linkLabelAbout.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.linkLabelAbout.Location = new System.Drawing.Point(47, 580);
            this.linkLabelAbout.Name = "linkLabelAbout";
            this.linkLabelAbout.Size = new System.Drawing.Size(163, 23);
            this.linkLabelAbout.TabIndex = 31;
            this.linkLabelAbout.TabStop = true;
            this.linkLabelAbout.Text = "Check us on github.";
            this.linkLabelAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAbout_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.label2.Location = new System.Drawing.Point(41, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(612, 59);
            this.label2.TabIndex = 32;
            this.label2.Text = "TOURNAMENT MANAGER ♔";
            // 
            // listBoxInfo
            // 
            this.listBoxInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.listBoxInfo.FormattingEnabled = true;
            this.listBoxInfo.ItemHeight = 22;
            this.listBoxInfo.Location = new System.Drawing.Point(727, 83);
            this.listBoxInfo.Name = "listBoxInfo";
            this.listBoxInfo.Size = new System.Drawing.Size(295, 48);
            this.listBoxInfo.TabIndex = 33;
            // 
            // dataGridViewLeaderboard
            // 
            this.dataGridViewLeaderboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLeaderboard.Location = new System.Drawing.Point(727, 205);
            this.dataGridViewLeaderboard.Name = "dataGridViewLeaderboard";
            this.dataGridViewLeaderboard.RowHeadersVisible = false;
            this.dataGridViewLeaderboard.RowHeadersWidth = 51;
            this.dataGridViewLeaderboard.RowTemplate.Height = 24;
            this.dataGridViewLeaderboard.Size = new System.Drawing.Size(295, 334);
            this.dataGridViewLeaderboard.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.label1.Location = new System.Drawing.Point(720, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 45);
            this.label1.TabIndex = 35;
            this.label1.Text = "Current Standings";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1061, 651);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewLeaderboard);
            this.Controls.Add(this.listBoxInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabelAbout);
            this.Controls.Add(this.buttonViewPairing);
            this.Controls.Add(this.buttonMatchupEntries);
            this.Controls.Add(this.buttonViewMatchups);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.buttonViewTeam);
            this.Controls.Add(this.buttonViewPlayer);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelTournamentValue);
            this.Controls.Add(this.labelTournament);
            this.Controls.Add(this.menuStripControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStripControl;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tournament Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMenu_FormClosing);
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStripControl.ResumeLayout(false);
            this.menuStripControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeaderboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStripControl;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tournamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadAnotherTournamentFromDatabaseToolStripMenuItem;
        private System.Windows.Forms.Label labelTournament;
        private System.Windows.Forms.Label labelTournamentValue;
        private System.Windows.Forms.ToolStripMenuItem viewTournamentPrizesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateTournamentStartingBracketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playersTeamsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamAndPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchToolStripMenuItem;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonViewPlayer;
        private System.Windows.Forms.Button buttonViewTeam;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Button buttonViewMatchups;
        private System.Windows.Forms.Button buttonMatchupEntries;
        private System.Windows.Forms.Button buttonViewPairing;
        private System.Windows.Forms.LinkLabel linkLabelAbout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem pairToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxInfo;
        private System.Windows.Forms.DataGridView dataGridViewLeaderboard;
        private System.Windows.Forms.Label label1;
    }
}