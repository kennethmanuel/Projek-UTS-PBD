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
            this.label5 = new System.Windows.Forms.Label();
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
            this.tabControlTeam.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControlTeam.Location = new System.Drawing.Point(11, 90);
            this.tabControlTeam.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlTeam.Name = "tabControlTeam";
            this.tabControlTeam.SelectedIndex = 0;
            this.tabControlTeam.Size = new System.Drawing.Size(750, 479);
            this.tabControlTeam.TabIndex = 1;
            // 
            // tabPagePlayer
            // 
            this.tabPagePlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.tabPagePlayer.Controls.Add(this.textBoxSearchPlayer);
            this.tabPagePlayer.Controls.Add(this.buttonDeletePlayer);
            this.tabPagePlayer.Controls.Add(this.buttonEditPlayer);
            this.tabPagePlayer.Controls.Add(this.buttonAddPlayer);
            this.tabPagePlayer.Controls.Add(this.dataGridViewPlayer);
            this.tabPagePlayer.Location = new System.Drawing.Point(4, 32);
            this.tabPagePlayer.Margin = new System.Windows.Forms.Padding(2);
            this.tabPagePlayer.Name = "tabPagePlayer";
            this.tabPagePlayer.Padding = new System.Windows.Forms.Padding(2);
            this.tabPagePlayer.Size = new System.Drawing.Size(742, 443);
            this.tabPagePlayer.TabIndex = 1;
            this.tabPagePlayer.Text = "Players";
            // 
            // textBoxSearchPlayer
            // 
            this.textBoxSearchPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.textBoxSearchPlayer.Location = new System.Drawing.Point(16, 50);
            this.textBoxSearchPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSearchPlayer.Name = "textBoxSearchPlayer";
            this.textBoxSearchPlayer.Size = new System.Drawing.Size(307, 30);
            this.textBoxSearchPlayer.TabIndex = 7;
            this.textBoxSearchPlayer.TextChanged += new System.EventHandler(this.textBoxSearchPlayer_TextChanged);
            // 
            // buttonDeletePlayer
            // 
            this.buttonDeletePlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(165)))), ((int)(((byte)(152)))));
            this.buttonDeletePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeletePlayer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonDeletePlayer.Location = new System.Drawing.Point(601, 46);
            this.buttonDeletePlayer.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeletePlayer.Name = "buttonDeletePlayer";
            this.buttonDeletePlayer.Size = new System.Drawing.Size(123, 34);
            this.buttonDeletePlayer.TabIndex = 6;
            this.buttonDeletePlayer.Text = "Delete Player";
            this.buttonDeletePlayer.UseVisualStyleBackColor = false;
            this.buttonDeletePlayer.Click += new System.EventHandler(this.buttonDeletePlayer_Click);
            // 
            // buttonEditPlayer
            // 
            this.buttonEditPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(165)))), ((int)(((byte)(152)))));
            this.buttonEditPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditPlayer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonEditPlayer.Location = new System.Drawing.Point(474, 46);
            this.buttonEditPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEditPlayer.Name = "buttonEditPlayer";
            this.buttonEditPlayer.Size = new System.Drawing.Size(123, 34);
            this.buttonEditPlayer.TabIndex = 5;
            this.buttonEditPlayer.Text = "Edit Player";
            this.buttonEditPlayer.UseVisualStyleBackColor = false;
            this.buttonEditPlayer.Click += new System.EventHandler(this.buttonEditPlayer_Click);
            // 
            // buttonAddPlayer
            // 
            this.buttonAddPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(165)))), ((int)(((byte)(152)))));
            this.buttonAddPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddPlayer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonAddPlayer.Location = new System.Drawing.Point(345, 46);
            this.buttonAddPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddPlayer.Name = "buttonAddPlayer";
            this.buttonAddPlayer.Size = new System.Drawing.Size(123, 34);
            this.buttonAddPlayer.TabIndex = 4;
            this.buttonAddPlayer.Text = "Add New Player";
            this.buttonAddPlayer.UseVisualStyleBackColor = false;
            this.buttonAddPlayer.Click += new System.EventHandler(this.buttonAddPlayer_Click);
            // 
            // dataGridViewPlayer
            // 
            this.dataGridViewPlayer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(92)))), ((int)(((byte)(84)))));
            this.dataGridViewPlayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlayer.Location = new System.Drawing.Point(16, 94);
            this.dataGridViewPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewPlayer.Name = "dataGridViewPlayer";
            this.dataGridViewPlayer.ReadOnly = true;
            this.dataGridViewPlayer.RowHeadersWidth = 51;
            this.dataGridViewPlayer.RowTemplate.Height = 24;
            this.dataGridViewPlayer.Size = new System.Drawing.Size(712, 334);
            this.dataGridViewPlayer.TabIndex = 2;
            // 
            // tabPageTeam
            // 
            this.tabPageTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.tabPageTeam.Controls.Add(this.textBoxSearchTeam);
            this.tabPageTeam.Controls.Add(this.buttonDeleteTeam);
            this.tabPageTeam.Controls.Add(this.buttonEditTeam);
            this.tabPageTeam.Controls.Add(this.buttonAddTeam);
            this.tabPageTeam.Controls.Add(this.dataGridViewTeam);
            this.tabPageTeam.Location = new System.Drawing.Point(4, 32);
            this.tabPageTeam.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageTeam.Name = "tabPageTeam";
            this.tabPageTeam.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageTeam.Size = new System.Drawing.Size(742, 443);
            this.tabPageTeam.TabIndex = 0;
            this.tabPageTeam.Text = "Teams";
            // 
            // textBoxSearchTeam
            // 
            this.textBoxSearchTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.textBoxSearchTeam.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxSearchTeam.Location = new System.Drawing.Point(15, 50);
            this.textBoxSearchTeam.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSearchTeam.Name = "textBoxSearchTeam";
            this.textBoxSearchTeam.Size = new System.Drawing.Size(307, 30);
            this.textBoxSearchTeam.TabIndex = 8;
            this.textBoxSearchTeam.TextChanged += new System.EventHandler(this.textBoxSearchTeam_TextChanged);
            // 
            // buttonDeleteTeam
            // 
            this.buttonDeleteTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(165)))), ((int)(((byte)(152)))));
            this.buttonDeleteTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteTeam.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonDeleteTeam.Location = new System.Drawing.Point(604, 46);
            this.buttonDeleteTeam.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeleteTeam.Name = "buttonDeleteTeam";
            this.buttonDeleteTeam.Size = new System.Drawing.Size(123, 34);
            this.buttonDeleteTeam.TabIndex = 3;
            this.buttonDeleteTeam.Text = "Delete Team";
            this.buttonDeleteTeam.UseVisualStyleBackColor = false;
            this.buttonDeleteTeam.Click += new System.EventHandler(this.buttonDeleteTeam_Click);
            // 
            // buttonEditTeam
            // 
            this.buttonEditTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(165)))), ((int)(((byte)(152)))));
            this.buttonEditTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditTeam.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonEditTeam.Location = new System.Drawing.Point(476, 46);
            this.buttonEditTeam.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEditTeam.Name = "buttonEditTeam";
            this.buttonEditTeam.Size = new System.Drawing.Size(123, 34);
            this.buttonEditTeam.TabIndex = 2;
            this.buttonEditTeam.Text = "Edit Team";
            this.buttonEditTeam.UseVisualStyleBackColor = false;
            this.buttonEditTeam.Click += new System.EventHandler(this.buttonEditTeam_Click);
            // 
            // buttonAddTeam
            // 
            this.buttonAddTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(165)))), ((int)(((byte)(152)))));
            this.buttonAddTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTeam.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonAddTeam.Location = new System.Drawing.Point(348, 46);
            this.buttonAddTeam.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddTeam.Name = "buttonAddTeam";
            this.buttonAddTeam.Size = new System.Drawing.Size(123, 34);
            this.buttonAddTeam.TabIndex = 1;
            this.buttonAddTeam.Text = "Add New Team";
            this.buttonAddTeam.UseVisualStyleBackColor = false;
            this.buttonAddTeam.Click += new System.EventHandler(this.buttonAddTeam_Click);
            // 
            // dataGridViewTeam
            // 
            this.dataGridViewTeam.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(92)))), ((int)(((byte)(84)))));
            this.dataGridViewTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeam.Location = new System.Drawing.Point(15, 98);
            this.dataGridViewTeam.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewTeam.Name = "dataGridViewTeam";
            this.dataGridViewTeam.ReadOnly = true;
            this.dataGridViewTeam.RowHeadersWidth = 51;
            this.dataGridViewTeam.RowTemplate.Height = 24;
            this.dataGridViewTeam.Size = new System.Drawing.Size(712, 334);
            this.dataGridViewTeam.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.label5.Location = new System.Drawing.Point(182, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(415, 60);
            this.label5.TabIndex = 20;
            this.label5.Text = "PLAYER AND TEAMS";
            // 
            // FormPlayerTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(771, 580);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tabControlTeam);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Label label5;
    }
}