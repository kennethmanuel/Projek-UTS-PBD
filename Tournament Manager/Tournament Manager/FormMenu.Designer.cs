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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tournamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAnotherTournamentFromDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAnotherTournamentFromLocalFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTournamentIntoALocalFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateTournamentStartingBracketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playersTeamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamAndPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTournamentPrizesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTournamentName = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.tournamentToolStripMenuItem,
            this.playersTeamsToolStripMenuItem,
            this.viewTournamentPrizesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(750, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // tournamentToolStripMenuItem
            // 
            this.tournamentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadAnotherTournamentFromDatabaseToolStripMenuItem,
            this.loadAnotherTournamentFromLocalFileToolStripMenuItem,
            this.saveTournamentIntoALocalFilesToolStripMenuItem,
            this.generateTournamentStartingBracketToolStripMenuItem});
            this.tournamentToolStripMenuItem.Name = "tournamentToolStripMenuItem";
            this.tournamentToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.tournamentToolStripMenuItem.Text = "Tournament";
            // 
            // loadAnotherTournamentFromDatabaseToolStripMenuItem
            // 
            this.loadAnotherTournamentFromDatabaseToolStripMenuItem.Name = "loadAnotherTournamentFromDatabaseToolStripMenuItem";
            this.loadAnotherTournamentFromDatabaseToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.loadAnotherTournamentFromDatabaseToolStripMenuItem.Text = "Load another tournament from database";
            // 
            // loadAnotherTournamentFromLocalFileToolStripMenuItem
            // 
            this.loadAnotherTournamentFromLocalFileToolStripMenuItem.Name = "loadAnotherTournamentFromLocalFileToolStripMenuItem";
            this.loadAnotherTournamentFromLocalFileToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.loadAnotherTournamentFromLocalFileToolStripMenuItem.Text = "Load another tournament from local file";
            // 
            // saveTournamentIntoALocalFilesToolStripMenuItem
            // 
            this.saveTournamentIntoALocalFilesToolStripMenuItem.Name = "saveTournamentIntoALocalFilesToolStripMenuItem";
            this.saveTournamentIntoALocalFilesToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.saveTournamentIntoALocalFilesToolStripMenuItem.Text = "Save tournament into a local files";
            // 
            // generateTournamentStartingBracketToolStripMenuItem
            // 
            this.generateTournamentStartingBracketToolStripMenuItem.Name = "generateTournamentStartingBracketToolStripMenuItem";
            this.generateTournamentStartingBracketToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.generateTournamentStartingBracketToolStripMenuItem.Text = "Generate Tournament Starting Bracket";
            // 
            // playersTeamsToolStripMenuItem
            // 
            this.playersTeamsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teamAndPlayerToolStripMenuItem,
            this.matchToolStripMenuItem});
            this.playersTeamsToolStripMenuItem.Name = "playersTeamsToolStripMenuItem";
            this.playersTeamsToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.playersTeamsToolStripMenuItem.Text = "View Data";
            // 
            // teamAndPlayerToolStripMenuItem
            // 
            this.teamAndPlayerToolStripMenuItem.Name = "teamAndPlayerToolStripMenuItem";
            this.teamAndPlayerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.teamAndPlayerToolStripMenuItem.Text = "Team and Player";
            this.teamAndPlayerToolStripMenuItem.Click += new System.EventHandler(this.teamAndPlayerToolStripMenuItem_Click);
            // 
            // matchToolStripMenuItem
            // 
            this.matchToolStripMenuItem.Name = "matchToolStripMenuItem";
            this.matchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.matchToolStripMenuItem.Text = "Match";
            this.matchToolStripMenuItem.Click += new System.EventHandler(this.matchToolStripMenuItem_Click_1);
            // 
            // viewTournamentPrizesToolStripMenuItem
            // 
            this.viewTournamentPrizesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prizeToolStripMenuItem});
            this.viewTournamentPrizesToolStripMenuItem.Name = "viewTournamentPrizesToolStripMenuItem";
            this.viewTournamentPrizesToolStripMenuItem.Size = new System.Drawing.Size(144, 20);
            this.viewTournamentPrizesToolStripMenuItem.Text = "View Tournament Prizes";
            // 
            // prizeToolStripMenuItem
            // 
            this.prizeToolStripMenuItem.Name = "prizeToolStripMenuItem";
            this.prizeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.prizeToolStripMenuItem.Text = "Prize";
            this.prizeToolStripMenuItem.Click += new System.EventHandler(this.prizeToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(428, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Currenty Edited Tournament:";
            // 
            // labelTournamentName
            // 
            this.labelTournamentName.AutoSize = true;
            this.labelTournamentName.Location = new System.Drawing.Point(592, 5);
            this.labelTournamentName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTournamentName.Name = "labelTournamentName";
            this.labelTournamentName.Size = new System.Drawing.Size(104, 13);
            this.labelTournamentName.TabIndex = 3;
            this.labelTournamentName.Text = "<tournament_name>";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 458);
            this.Controls.Add(this.labelTournamentName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMenu_FormClosing);
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tournamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadAnotherTournamentFromDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadAnotherTournamentFromLocalFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTournamentIntoALocalFilesToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTournamentName;
        private System.Windows.Forms.ToolStripMenuItem viewTournamentPrizesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateTournamentStartingBracketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playersTeamsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamAndPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchToolStripMenuItem;
    }
}