namespace Tournament_Manager.Match
{
    partial class FormMatch
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
            this.tabPageMatchup = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewMatchup = new System.Windows.Forms.DataGridView();
            this.tabPageMatchupEntry = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridViewEntry = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPageMatchup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatchup)).BeginInit();
            this.tabPageMatchupEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntry)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageMatchup);
            this.tabControl1.Controls.Add(this.tabPageMatchupEntry);
            this.tabControl1.Location = new System.Drawing.Point(12, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(857, 479);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageMatchup
            // 
            this.tabPageMatchup.Controls.Add(this.button4);
            this.tabPageMatchup.Controls.Add(this.button3);
            this.tabPageMatchup.Controls.Add(this.button1);
            this.tabPageMatchup.Controls.Add(this.dataGridViewMatchup);
            this.tabPageMatchup.Location = new System.Drawing.Point(4, 25);
            this.tabPageMatchup.Name = "tabPageMatchup";
            this.tabPageMatchup.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMatchup.Size = new System.Drawing.Size(849, 450);
            this.tabPageMatchup.TabIndex = 0;
            this.tabPageMatchup.Text = "Matchup";
            this.tabPageMatchup.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(690, 46);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 35);
            this.button4.TabIndex = 3;
            this.button4.Text = "Delete Macthup";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(544, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "Edit Matchup";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add New Matchup";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMatchup
            // 
            this.dataGridViewMatchup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatchup.Location = new System.Drawing.Point(17, 98);
            this.dataGridViewMatchup.Name = "dataGridViewMatchup";
            this.dataGridViewMatchup.RowHeadersWidth = 51;
            this.dataGridViewMatchup.RowTemplate.Height = 24;
            this.dataGridViewMatchup.Size = new System.Drawing.Size(813, 334);
            this.dataGridViewMatchup.TabIndex = 0;
            // 
            // tabPageMatchupEntry
            // 
            this.tabPageMatchupEntry.Controls.Add(this.button2);
            this.tabPageMatchupEntry.Controls.Add(this.button5);
            this.tabPageMatchupEntry.Controls.Add(this.button6);
            this.tabPageMatchupEntry.Controls.Add(this.dataGridViewEntry);
            this.tabPageMatchupEntry.Location = new System.Drawing.Point(4, 25);
            this.tabPageMatchupEntry.Name = "tabPageMatchupEntry";
            this.tabPageMatchupEntry.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMatchupEntry.Size = new System.Drawing.Size(849, 450);
            this.tabPageMatchupEntry.TabIndex = 1;
            this.tabPageMatchupEntry.Text = "Entry";
            this.tabPageMatchupEntry.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(687, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "Delete Entry";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(541, 46);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 35);
            this.button5.TabIndex = 5;
            this.button5.Text = "Edit Entry";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(395, 46);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(140, 35);
            this.button6.TabIndex = 4;
            this.button6.Text = "Add Entry";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEntry
            // 
            this.dataGridViewEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEntry.Location = new System.Drawing.Point(18, 94);
            this.dataGridViewEntry.Name = "dataGridViewEntry";
            this.dataGridViewEntry.RowHeadersWidth = 51;
            this.dataGridViewEntry.RowTemplate.Height = 24;
            this.dataGridViewEntry.Size = new System.Drawing.Size(813, 334);
            this.dataGridViewEntry.TabIndex = 2;
            // 
            // FormMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 529);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMatch";
            this.Text = "Matchup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Matchup_FormClosing);
            this.Load += new System.EventHandler(this.FormMatch_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageMatchup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatchup)).EndInit();
            this.tabPageMatchupEntry.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageMatchup;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewMatchup;
        private System.Windows.Forms.TabPage tabPageMatchupEntry;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridViewEntry;
    }
}