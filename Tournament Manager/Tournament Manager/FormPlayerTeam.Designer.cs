namespace Tournament_Manager
{
    partial class FormPlayerTeam
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
            this.tabControlTeam = new System.Windows.Forms.TabControl();
            this.tabPagePlayer = new System.Windows.Forms.TabPage();
            this.textBoxSearchPlayer = new System.Windows.Forms.TextBox();
            this.buttonDeletePlayer = new System.Windows.Forms.Button();
            this.buttonEditPlayer = new System.Windows.Forms.Button();
            this.buttonAddPlayer = new System.Windows.Forms.Button();
            this.dataGridViewPlayer = new System.Windows.Forms.DataGridView();
            this.tabPageTeam = new System.Windows.Forms.TabPage();
            this.textBoxSearchTeam = new System.Windows.Forms.TextBox();
            this.buttonDeleteTeam = new System.Windows.Forms.Button();
            this.buttonEditTeam = new System.Windows.Forms.Button();
            this.buttonAddTeam = new System.Windows.Forms.Button();
            this.dataGridViewTeam = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControlTeam.SuspendLayout();
            this.tabPagePlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayer)).BeginInit();
            this.tabPageTeam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlTeam
            // 
            this.tabControlTeam.Controls.Add(this.tabPagePlayer);
            this.tabControlTeam.Controls.Add(this.tabPageTeam);
            this.tabControlTeam.Location = new System.Drawing.Point(12, 38);
            this.tabControlTeam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlTeam.Name = "tabControlTeam";
            this.tabControlTeam.SelectedIndex = 0;
            this.tabControlTeam.Size = new System.Drawing.Size(857, 479);
            this.tabControlTeam.TabIndex = 1;
            // 
            // tabPagePlayer
            // 
            this.tabPagePlayer.Controls.Add(this.button1);
            this.tabPagePlayer.Controls.Add(this.textBoxSearchPlayer);
            this.tabPagePlayer.Controls.Add(this.buttonDeletePlayer);
            this.tabPagePlayer.Controls.Add(this.buttonEditPlayer);
            this.tabPagePlayer.Controls.Add(this.buttonAddPlayer);
            this.tabPagePlayer.Controls.Add(this.dataGridViewPlayer);
            this.tabPagePlayer.Location = new System.Drawing.Point(4, 25);
            this.tabPagePlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPagePlayer.Name = "tabPagePlayer";
            this.tabPagePlayer.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPagePlayer.Size = new System.Drawing.Size(849, 450);
            this.tabPagePlayer.TabIndex = 1;
            this.tabPagePlayer.Text = "Players";
            this.tabPagePlayer.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchPlayer
            // 
            this.textBoxSearchPlayer.Location = new System.Drawing.Point(19, 59);
            this.textBoxSearchPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSearchPlayer.Name = "textBoxSearchPlayer";
            this.textBoxSearchPlayer.Size = new System.Drawing.Size(265, 22);
            this.textBoxSearchPlayer.TabIndex = 7;
            this.textBoxSearchPlayer.TextChanged += new System.EventHandler(this.textBoxSearchPlayer_TextChanged);
            // 
            // buttonDeletePlayer
            // 
            this.buttonDeletePlayer.Location = new System.Drawing.Point(687, 46);
            this.buttonDeletePlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeletePlayer.Name = "buttonDeletePlayer";
            this.buttonDeletePlayer.Size = new System.Drawing.Size(140, 34);
            this.buttonDeletePlayer.TabIndex = 6;
            this.buttonDeletePlayer.Text = "Delete Player";
            this.buttonDeletePlayer.UseVisualStyleBackColor = true;
            this.buttonDeletePlayer.Click += new System.EventHandler(this.buttonDeletePlayer_Click);
            // 
            // buttonEditPlayer
            // 
            this.buttonEditPlayer.Location = new System.Drawing.Point(541, 46);
            this.buttonEditPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditPlayer.Name = "buttonEditPlayer";
            this.buttonEditPlayer.Size = new System.Drawing.Size(140, 34);
            this.buttonEditPlayer.TabIndex = 5;
            this.buttonEditPlayer.Text = "Edit Player";
            this.buttonEditPlayer.UseVisualStyleBackColor = true;
            this.buttonEditPlayer.Click += new System.EventHandler(this.buttonEditPlayer_Click);
            // 
            // buttonAddPlayer
            // 
            this.buttonAddPlayer.Location = new System.Drawing.Point(395, 46);
            this.buttonAddPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddPlayer.Name = "buttonAddPlayer";
            this.buttonAddPlayer.Size = new System.Drawing.Size(140, 34);
            this.buttonAddPlayer.TabIndex = 4;
            this.buttonAddPlayer.Text = "Add New Player";
            this.buttonAddPlayer.UseVisualStyleBackColor = true;
            this.buttonAddPlayer.Click += new System.EventHandler(this.buttonAddPlayer_Click);
            // 
            // dataGridViewPlayer
            // 
            this.dataGridViewPlayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlayer.Location = new System.Drawing.Point(19, 94);
            this.dataGridViewPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewPlayer.Name = "dataGridViewPlayer";
            this.dataGridViewPlayer.ReadOnly = true;
            this.dataGridViewPlayer.RowHeadersWidth = 51;
            this.dataGridViewPlayer.RowTemplate.Height = 24;
            this.dataGridViewPlayer.Size = new System.Drawing.Size(813, 334);
            this.dataGridViewPlayer.TabIndex = 2;
            // 
            // tabPageTeam
            // 
            this.tabPageTeam.Controls.Add(this.textBoxSearchTeam);
            this.tabPageTeam.Controls.Add(this.buttonDeleteTeam);
            this.tabPageTeam.Controls.Add(this.buttonEditTeam);
            this.tabPageTeam.Controls.Add(this.buttonAddTeam);
            this.tabPageTeam.Controls.Add(this.dataGridViewTeam);
            this.tabPageTeam.Location = new System.Drawing.Point(4, 25);
            this.tabPageTeam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageTeam.Name = "tabPageTeam";
            this.tabPageTeam.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageTeam.Size = new System.Drawing.Size(849, 450);
            this.tabPageTeam.TabIndex = 0;
            this.tabPageTeam.Text = "Teams";
            this.tabPageTeam.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchTeam
            // 
            this.textBoxSearchTeam.Location = new System.Drawing.Point(17, 59);
            this.textBoxSearchTeam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSearchTeam.Name = "textBoxSearchTeam";
            this.textBoxSearchTeam.Size = new System.Drawing.Size(265, 22);
            this.textBoxSearchTeam.TabIndex = 8;
            this.textBoxSearchTeam.TextChanged += new System.EventHandler(this.textBoxSearchTeam_TextChanged);
            // 
            // buttonDeleteTeam
            // 
            this.buttonDeleteTeam.Location = new System.Drawing.Point(691, 46);
            this.buttonDeleteTeam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteTeam.Name = "buttonDeleteTeam";
            this.buttonDeleteTeam.Size = new System.Drawing.Size(140, 34);
            this.buttonDeleteTeam.TabIndex = 3;
            this.buttonDeleteTeam.Text = "Delete Team";
            this.buttonDeleteTeam.UseVisualStyleBackColor = true;
            this.buttonDeleteTeam.Click += new System.EventHandler(this.buttonDeleteTeam_Click);
            // 
            // buttonEditTeam
            // 
            this.buttonEditTeam.Location = new System.Drawing.Point(544, 46);
            this.buttonEditTeam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditTeam.Name = "buttonEditTeam";
            this.buttonEditTeam.Size = new System.Drawing.Size(140, 34);
            this.buttonEditTeam.TabIndex = 2;
            this.buttonEditTeam.Text = "Edit Team";
            this.buttonEditTeam.UseVisualStyleBackColor = true;
            this.buttonEditTeam.Click += new System.EventHandler(this.buttonEditTeam_Click);
            // 
            // buttonAddTeam
            // 
            this.buttonAddTeam.Location = new System.Drawing.Point(397, 46);
            this.buttonAddTeam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddTeam.Name = "buttonAddTeam";
            this.buttonAddTeam.Size = new System.Drawing.Size(140, 34);
            this.buttonAddTeam.TabIndex = 1;
            this.buttonAddTeam.Text = "Add New Team";
            this.buttonAddTeam.UseVisualStyleBackColor = true;
            this.buttonAddTeam.Click += new System.EventHandler(this.buttonAddTeam_Click);
            // 
            // dataGridViewTeam
            // 
            this.dataGridViewTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeam.Location = new System.Drawing.Point(17, 98);
            this.dataGridViewTeam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewTeam.Name = "dataGridViewTeam";
            this.dataGridViewTeam.ReadOnly = true;
            this.dataGridViewTeam.RowHeadersWidth = 51;
            this.dataGridViewTeam.RowTemplate.Height = 24;
            this.dataGridViewTeam.Size = new System.Drawing.Size(813, 334);
            this.dataGridViewTeam.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(752, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormPlayerTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 529);
            this.Controls.Add(this.tabControlTeam);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPlayerTeam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPlayerTeam";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPlayerTeam_FormClosing);
            this.Load += new System.EventHandler(this.FormPlayerTeam_Load);
            this.tabControlTeam.ResumeLayout(false);
            this.tabPagePlayer.ResumeLayout(false);
            this.tabPagePlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayer)).EndInit();
            this.tabPageTeam.ResumeLayout(false);
            this.tabPageTeam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlTeam;
        private System.Windows.Forms.TabPage tabPageTeam;
        private System.Windows.Forms.Button buttonAddTeam;
        private System.Windows.Forms.DataGridView dataGridViewTeam;
        private System.Windows.Forms.TabPage tabPagePlayer;
        private System.Windows.Forms.DataGridView dataGridViewPlayer;
        private System.Windows.Forms.Button buttonDeleteTeam;
        private System.Windows.Forms.Button buttonEditTeam;
        private System.Windows.Forms.Button buttonDeletePlayer;
        private System.Windows.Forms.Button buttonEditPlayer;
        private System.Windows.Forms.Button buttonAddPlayer;
        private System.Windows.Forms.TextBox textBoxSearchPlayer;
        private System.Windows.Forms.TextBox textBoxSearchTeam;
        private System.Windows.Forms.Button button1;
    }
}