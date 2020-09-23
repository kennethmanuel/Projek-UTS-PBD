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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageTeam = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTeam = new System.Windows.Forms.DataGridView();
            this.tabPagePlayer = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridViewPlayer = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPageTeam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeam)).BeginInit();
            this.tabPagePlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageTeam);
            this.tabControl1.Controls.Add(this.tabPagePlayer);
            this.tabControl1.Location = new System.Drawing.Point(12, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(857, 479);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageTeam
            // 
            this.tabPageTeam.Controls.Add(this.button4);
            this.tabPageTeam.Controls.Add(this.button3);
            this.tabPageTeam.Controls.Add(this.button1);
            this.tabPageTeam.Controls.Add(this.dataGridViewTeam);
            this.tabPageTeam.Location = new System.Drawing.Point(4, 25);
            this.tabPageTeam.Name = "tabPageTeam";
            this.tabPageTeam.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTeam.Size = new System.Drawing.Size(849, 450);
            this.tabPageTeam.TabIndex = 0;
            this.tabPageTeam.Text = "Teams";
            this.tabPageTeam.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(690, 46);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 35);
            this.button4.TabIndex = 3;
            this.button4.Text = "Delete Team";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(544, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "Edit Team";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add New Team";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTeam
            // 
            this.dataGridViewTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeam.Location = new System.Drawing.Point(17, 98);
            this.dataGridViewTeam.Name = "dataGridViewTeam";
            this.dataGridViewTeam.RowHeadersWidth = 51;
            this.dataGridViewTeam.RowTemplate.Height = 24;
            this.dataGridViewTeam.Size = new System.Drawing.Size(813, 334);
            this.dataGridViewTeam.TabIndex = 0;
            // 
            // tabPagePlayer
            // 
            this.tabPagePlayer.Controls.Add(this.button2);
            this.tabPagePlayer.Controls.Add(this.button5);
            this.tabPagePlayer.Controls.Add(this.button6);
            this.tabPagePlayer.Controls.Add(this.dataGridViewPlayer);
            this.tabPagePlayer.Location = new System.Drawing.Point(4, 25);
            this.tabPagePlayer.Name = "tabPagePlayer";
            this.tabPagePlayer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePlayer.Size = new System.Drawing.Size(849, 450);
            this.tabPagePlayer.TabIndex = 1;
            this.tabPagePlayer.Text = "Players";
            this.tabPagePlayer.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(687, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "Delete Team";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(541, 46);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 35);
            this.button5.TabIndex = 5;
            this.button5.Text = "Edit Team";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(395, 46);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(140, 35);
            this.button6.TabIndex = 4;
            this.button6.Text = "Add New Team";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPlayer
            // 
            this.dataGridViewPlayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlayer.Location = new System.Drawing.Point(18, 94);
            this.dataGridViewPlayer.Name = "dataGridViewPlayer";
            this.dataGridViewPlayer.RowHeadersWidth = 51;
            this.dataGridViewPlayer.RowTemplate.Height = 24;
            this.dataGridViewPlayer.Size = new System.Drawing.Size(813, 334);
            this.dataGridViewPlayer.TabIndex = 2;
            // 
            // FormPlayerTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 529);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormPlayerTeam";
            this.Text = "FormPlayerTeam";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPlayerTeam_FormClosing);
            this.Load += new System.EventHandler(this.FormPlayerTeam_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageTeam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeam)).EndInit();
            this.tabPagePlayer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageTeam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewTeam;
        private System.Windows.Forms.TabPage tabPagePlayer;
        private System.Windows.Forms.DataGridView dataGridViewPlayer;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}