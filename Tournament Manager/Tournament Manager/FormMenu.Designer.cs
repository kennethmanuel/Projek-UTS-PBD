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
            this.viewBracketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTournamentPrizesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.generateTournamentStartingBracketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playersTeamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.viewBracketToolStripMenuItem,
            this.viewTournamentPrizesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(881, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 24);
            // 
            // tournamentToolStripMenuItem
            // 
            this.tournamentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadAnotherTournamentFromDatabaseToolStripMenuItem,
            this.loadAnotherTournamentFromLocalFileToolStripMenuItem,
            this.saveTournamentIntoALocalFilesToolStripMenuItem,
            this.generateTournamentStartingBracketToolStripMenuItem});
            this.tournamentToolStripMenuItem.Name = "tournamentToolStripMenuItem";
            this.tournamentToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.tournamentToolStripMenuItem.Text = "Tournament";
            // 
            // loadAnotherTournamentFromDatabaseToolStripMenuItem
            // 
            this.loadAnotherTournamentFromDatabaseToolStripMenuItem.Name = "loadAnotherTournamentFromDatabaseToolStripMenuItem";
            this.loadAnotherTournamentFromDatabaseToolStripMenuItem.Size = new System.Drawing.Size(362, 26);
            this.loadAnotherTournamentFromDatabaseToolStripMenuItem.Text = "Load another tournament from database";
            // 
            // loadAnotherTournamentFromLocalFileToolStripMenuItem
            // 
            this.loadAnotherTournamentFromLocalFileToolStripMenuItem.Name = "loadAnotherTournamentFromLocalFileToolStripMenuItem";
            this.loadAnotherTournamentFromLocalFileToolStripMenuItem.Size = new System.Drawing.Size(362, 26);
            this.loadAnotherTournamentFromLocalFileToolStripMenuItem.Text = "Load another tournament from local file";
            // 
            // saveTournamentIntoALocalFilesToolStripMenuItem
            // 
            this.saveTournamentIntoALocalFilesToolStripMenuItem.Name = "saveTournamentIntoALocalFilesToolStripMenuItem";
            this.saveTournamentIntoALocalFilesToolStripMenuItem.Size = new System.Drawing.Size(362, 26);
            this.saveTournamentIntoALocalFilesToolStripMenuItem.Text = "Save tournament into a local files";
            // 
            // viewBracketToolStripMenuItem
            // 
            this.viewBracketToolStripMenuItem.Name = "viewBracketToolStripMenuItem";
            this.viewBracketToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.viewBracketToolStripMenuItem.Text = "Match";
            // 
            // viewTournamentPrizesToolStripMenuItem
            // 
            this.viewTournamentPrizesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prizeToolStripMenuItem});
            this.viewTournamentPrizesToolStripMenuItem.Name = "viewTournamentPrizesToolStripMenuItem";
            this.viewTournamentPrizesToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.viewTournamentPrizesToolStripMenuItem.Text = "View Tournament Prizes";
            // 
            // prizeToolStripMenuItem
            // 
            this.prizeToolStripMenuItem.Name = "prizeToolStripMenuItem";
            this.prizeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.prizeToolStripMenuItem.Text = "Prize";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(533, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Currenty Edited Tournament:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(730, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "<tournament_name>";
            // 
            // generateTournamentStartingBracketToolStripMenuItem
            // 
            this.generateTournamentStartingBracketToolStripMenuItem.Name = "generateTournamentStartingBracketToolStripMenuItem";
            this.generateTournamentStartingBracketToolStripMenuItem.Size = new System.Drawing.Size(362, 26);
            this.generateTournamentStartingBracketToolStripMenuItem.Text = "Generate Tournament Starting Bracket";
            // 
            // playersTeamsToolStripMenuItem
            // 
            this.playersTeamsToolStripMenuItem.Name = "playersTeamsToolStripMenuItem";
            this.playersTeamsToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.playersTeamsToolStripMenuItem.Text = "Players and Teams";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 529);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.Text = "FormMenu";
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
        private System.Windows.Forms.ToolStripMenuItem viewBracketToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem viewTournamentPrizesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateTournamentStartingBracketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playersTeamsToolStripMenuItem;
    }
}