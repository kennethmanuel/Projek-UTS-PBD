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
            this.textBoxSearchMatchup = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEditMatchup = new System.Windows.Forms.Button();
            this.dataGridViewMatchup = new System.Windows.Forms.DataGridView();
            this.tabPageMatchupEntry = new System.Windows.Forms.TabPage();
            this.buttonDeleteEntry = new System.Windows.Forms.Button();
            this.buttonEditEntry = new System.Windows.Forms.Button();
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
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl1.Location = new System.Drawing.Point(9, 93);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(750, 479);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageMatchup
            // 
            this.tabPageMatchup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.tabPageMatchup.Controls.Add(this.textBoxSearchMatchup);
            this.tabPageMatchup.Controls.Add(this.buttonDelete);
            this.tabPageMatchup.Controls.Add(this.buttonEditMatchup);
            this.tabPageMatchup.Controls.Add(this.dataGridViewMatchup);
            this.tabPageMatchup.Location = new System.Drawing.Point(4, 32);
            this.tabPageMatchup.Name = "tabPageMatchup";
            this.tabPageMatchup.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMatchup.Size = new System.Drawing.Size(742, 443);
            this.tabPageMatchup.TabIndex = 0;
            this.tabPageMatchup.Text = "Matchup";
            // 
            // textBoxSearchMatchup
            // 
            this.textBoxSearchMatchup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.textBoxSearchMatchup.Location = new System.Drawing.Point(15, 52);
            this.textBoxSearchMatchup.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSearchMatchup.Name = "textBoxSearchMatchup";
            this.textBoxSearchMatchup.Size = new System.Drawing.Size(260, 30);
            this.textBoxSearchMatchup.TabIndex = 8;
            this.textBoxSearchMatchup.TextChanged += new System.EventHandler(this.textBoxSearchMatchup_TextChanged);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(165)))), ((int)(((byte)(152)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonDelete.ForeColor = System.Drawing.Color.Black;
            this.buttonDelete.Location = new System.Drawing.Point(569, 46);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(158, 35);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete Matchup";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonEditMatchup
            // 
            this.buttonEditMatchup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(165)))), ((int)(((byte)(152)))));
            this.buttonEditMatchup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditMatchup.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonEditMatchup.ForeColor = System.Drawing.Color.Black;
            this.buttonEditMatchup.Location = new System.Drawing.Point(441, 46);
            this.buttonEditMatchup.Name = "buttonEditMatchup";
            this.buttonEditMatchup.Size = new System.Drawing.Size(122, 35);
            this.buttonEditMatchup.TabIndex = 2;
            this.buttonEditMatchup.Text = "Edit Matchup";
            this.buttonEditMatchup.UseVisualStyleBackColor = false;
            this.buttonEditMatchup.Click += new System.EventHandler(this.buttonEditMatchup_Click);
            // 
            // dataGridViewMatchup
            // 
            this.dataGridViewMatchup.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(92)))), ((int)(((byte)(84)))));
            this.dataGridViewMatchup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatchup.Location = new System.Drawing.Point(15, 96);
            this.dataGridViewMatchup.Name = "dataGridViewMatchup";
            this.dataGridViewMatchup.RowHeadersWidth = 51;
            this.dataGridViewMatchup.RowTemplate.Height = 24;
            this.dataGridViewMatchup.Size = new System.Drawing.Size(712, 334);
            this.dataGridViewMatchup.TabIndex = 0;
            // 
            // tabPageMatchupEntry
            // 
            this.tabPageMatchupEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.tabPageMatchupEntry.Controls.Add(this.buttonDeleteEntry);
            this.tabPageMatchupEntry.Controls.Add(this.buttonEditEntry);
            this.tabPageMatchupEntry.Controls.Add(this.dataGridViewEntry);
            this.tabPageMatchupEntry.Location = new System.Drawing.Point(4, 32);
            this.tabPageMatchupEntry.Name = "tabPageMatchupEntry";
            this.tabPageMatchupEntry.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMatchupEntry.Size = new System.Drawing.Size(742, 443);
            this.tabPageMatchupEntry.TabIndex = 1;
            this.tabPageMatchupEntry.Text = "Entry";
            // 
            // buttonDeleteEntry
            // 
            this.buttonDeleteEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(165)))), ((int)(((byte)(152)))));
            this.buttonDeleteEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteEntry.Location = new System.Drawing.Point(601, 46);
            this.buttonDeleteEntry.Name = "buttonDeleteEntry";
            this.buttonDeleteEntry.Size = new System.Drawing.Size(122, 35);
            this.buttonDeleteEntry.TabIndex = 6;
            this.buttonDeleteEntry.Text = "Delete Entry";
            this.buttonDeleteEntry.UseVisualStyleBackColor = false;
            // 
            // buttonEditEntry
            // 
            this.buttonEditEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(165)))), ((int)(((byte)(152)))));
            this.buttonEditEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditEntry.Location = new System.Drawing.Point(473, 46);
            this.buttonEditEntry.Name = "buttonEditEntry";
            this.buttonEditEntry.Size = new System.Drawing.Size(122, 35);
            this.buttonEditEntry.TabIndex = 5;
            this.buttonEditEntry.Text = "Edit Entry";
            this.buttonEditEntry.UseVisualStyleBackColor = false;
            // 
            // dataGridViewEntry
            // 
            this.dataGridViewEntry.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(92)))), ((int)(((byte)(84)))));
            this.dataGridViewEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEntry.Location = new System.Drawing.Point(15, 98);
            this.dataGridViewEntry.Name = "dataGridViewEntry";
            this.dataGridViewEntry.RowHeadersWidth = 51;
            this.dataGridViewEntry.RowTemplate.Height = 24;
            this.dataGridViewEntry.Size = new System.Drawing.Size(712, 334);
            this.dataGridViewEntry.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.label5.Location = new System.Drawing.Point(243, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 59);
            this.label5.TabIndex = 20;
            this.label5.Text = "MATCHUP";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(771, 580);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matchup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Matchup_FormClosing);
            this.Load += new System.EventHandler(this.FormMatch_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageMatchup.ResumeLayout(false);
            this.tabPageMatchup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatchup)).EndInit();
            this.tabPageMatchupEntry.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageMatchup;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEditMatchup;
        private System.Windows.Forms.DataGridView dataGridViewMatchup;
        private System.Windows.Forms.TabPage tabPageMatchupEntry;
        private System.Windows.Forms.Button buttonDeleteEntry;
        private System.Windows.Forms.Button buttonEditEntry;
        private System.Windows.Forms.DataGridView dataGridViewEntry;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSearchMatchup;
    }
}