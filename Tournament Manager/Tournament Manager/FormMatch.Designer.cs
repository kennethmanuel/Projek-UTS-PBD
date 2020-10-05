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
            this.label5 = new System.Windows.Forms.Label();
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
            this.tabControl1.Location = new System.Drawing.Point(21, 114);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(750, 479);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageMatchup
            // 
            this.tabPageMatchup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.tabPageMatchup.Controls.Add(this.button4);
            this.tabPageMatchup.Controls.Add(this.button3);
            this.tabPageMatchup.Controls.Add(this.button1);
            this.tabPageMatchup.Controls.Add(this.dataGridViewMatchup);
            this.tabPageMatchup.Location = new System.Drawing.Point(4, 25);
            this.tabPageMatchup.Name = "tabPageMatchup";
            this.tabPageMatchup.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMatchup.Size = new System.Drawing.Size(742, 450);
            this.tabPageMatchup.TabIndex = 0;
            this.tabPageMatchup.Text = "Matchup";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(165)))), ((int)(((byte)(152)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(604, 46);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 35);
            this.button4.TabIndex = 3;
            this.button4.Text = "Delete Macthup";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(165)))), ((int)(((byte)(152)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(476, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "Edit Matchup";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(165)))), ((int)(((byte)(152)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(316, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add New Matchup";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewMatchup
            // 
            this.dataGridViewMatchup.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewMatchup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatchup.Location = new System.Drawing.Point(15, 98);
            this.dataGridViewMatchup.Name = "dataGridViewMatchup";
            this.dataGridViewMatchup.RowHeadersWidth = 51;
            this.dataGridViewMatchup.RowTemplate.Height = 24;
            this.dataGridViewMatchup.Size = new System.Drawing.Size(711, 334);
            this.dataGridViewMatchup.TabIndex = 0;
            // 
            // tabPageMatchupEntry
            // 
            this.tabPageMatchupEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.tabPageMatchupEntry.Controls.Add(this.button2);
            this.tabPageMatchupEntry.Controls.Add(this.button5);
            this.tabPageMatchupEntry.Controls.Add(this.button6);
            this.tabPageMatchupEntry.Controls.Add(this.dataGridViewEntry);
            this.tabPageMatchupEntry.Location = new System.Drawing.Point(4, 25);
            this.tabPageMatchupEntry.Name = "tabPageMatchupEntry";
            this.tabPageMatchupEntry.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMatchupEntry.Size = new System.Drawing.Size(742, 450);
            this.tabPageMatchupEntry.TabIndex = 1;
            this.tabPageMatchupEntry.Text = "Entry";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(165)))), ((int)(((byte)(152)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(601, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "Delete Entry";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(165)))), ((int)(((byte)(152)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(473, 46);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 35);
            this.button5.TabIndex = 5;
            this.button5.Text = "Edit Entry";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(165)))), ((int)(((byte)(152)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(346, 46);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 35);
            this.button6.TabIndex = 4;
            this.button6.Text = "Add Entry";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // dataGridViewEntry
            // 
            this.dataGridViewEntry.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEntry.Location = new System.Drawing.Point(16, 94);
            this.dataGridViewEntry.Name = "dataGridViewEntry";
            this.dataGridViewEntry.RowHeadersWidth = 51;
            this.dataGridViewEntry.RowTemplate.Height = 24;
            this.dataGridViewEntry.Size = new System.Drawing.Size(711, 334);
            this.dataGridViewEntry.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Perpetua Titling MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.label5.Location = new System.Drawing.Point(295, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 39);
            this.label5.TabIndex = 20;
            this.label5.Text = "MATCHUP";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(791, 605);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormMatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label label5;
    }
}