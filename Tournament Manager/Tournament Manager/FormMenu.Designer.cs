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
            this.playersTeamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamAndPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTournamentPrizesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTournamentName = new System.Windows.Forms.Label();
            this.menuStripControl.SuspendLayout();
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
            this.menuStripControl.Size = new System.Drawing.Size(1045, 31);
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
            this.generateTournamentStartingBracketToolStripMenuItem});
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
            this.generateTournamentStartingBracketToolStripMenuItem.Text = "Generate Tournament Starting Bracket";
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
            this.teamAndPlayerToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.teamAndPlayerToolStripMenuItem.Text = "Team and Player";
            this.teamAndPlayerToolStripMenuItem.Click += new System.EventHandler(this.teamAndPlayerToolStripMenuItem_Click);
            // 
            // matchToolStripMenuItem
            // 
            this.matchToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(153)))), ((int)(((byte)(132)))));
            this.matchToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.matchToolStripMenuItem.Name = "matchToolStripMenuItem";
            this.matchToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.matchToolStripMenuItem.Text = "Match";
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
            this.prizeToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.prizeToolStripMenuItem.Text = "Prize";
            this.prizeToolStripMenuItem.Click += new System.EventHandler(this.prizeToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(153)))), ((int)(((byte)(132)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(574, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Currenty Edited Tournament:";
            // 
            // labelTournamentName
            // 
            this.labelTournamentName.AutoSize = true;
            this.labelTournamentName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(153)))), ((int)(((byte)(132)))));
            this.labelTournamentName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTournamentName.Location = new System.Drawing.Point(803, 5);
            this.labelTournamentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTournamentName.Name = "labelTournamentName";
            this.labelTournamentName.Size = new System.Drawing.Size(175, 23);
            this.labelTournamentName.TabIndex = 3;
            this.labelTournamentName.Text = "<tournament_name>";
            this.labelTournamentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1045, 776);
            this.Controls.Add(this.labelTournamentName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStripControl);
            this.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStripControl;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMenu_FormClosing);
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStripControl.ResumeLayout(false);
            this.menuStripControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStripControl;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tournamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadAnotherTournamentFromDatabaseToolStripMenuItem;
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