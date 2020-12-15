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
            this.dataGridViewEntry = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewMatchup = new System.Windows.Forms.DataGridView();
            this.buttonEditMatchup = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonViewMatchPairing = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatchup)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEntry
            // 
            this.dataGridViewEntry.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(92)))), ((int)(((byte)(84)))));
            this.dataGridViewEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEntry.Location = new System.Drawing.Point(375, 96);
            this.dataGridViewEntry.Name = "dataGridViewEntry";
            this.dataGridViewEntry.RowHeadersWidth = 51;
            this.dataGridViewEntry.RowTemplate.Height = 24;
            this.dataGridViewEntry.Size = new System.Drawing.Size(443, 373);
            this.dataGridViewEntry.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.label5.Location = new System.Drawing.Point(0, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 59);
            this.label5.TabIndex = 20;
            this.label5.Text = "MATCHUP";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewMatchup
            // 
            this.dataGridViewMatchup.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(92)))), ((int)(((byte)(84)))));
            this.dataGridViewMatchup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatchup.Location = new System.Drawing.Point(17, 96);
            this.dataGridViewMatchup.Name = "dataGridViewMatchup";
            this.dataGridViewMatchup.RowHeadersWidth = 51;
            this.dataGridViewMatchup.RowTemplate.Height = 24;
            this.dataGridViewMatchup.Size = new System.Drawing.Size(352, 278);
            this.dataGridViewMatchup.TabIndex = 0;
            // 
            // buttonEditMatchup
            // 
            this.buttonEditMatchup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(165)))), ((int)(((byte)(152)))));
            this.buttonEditMatchup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditMatchup.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonEditMatchup.ForeColor = System.Drawing.Color.Black;
            this.buttonEditMatchup.Location = new System.Drawing.Point(131, 380);
            this.buttonEditMatchup.Name = "buttonEditMatchup";
            this.buttonEditMatchup.Size = new System.Drawing.Size(124, 35);
            this.buttonEditMatchup.TabIndex = 2;
            this.buttonEditMatchup.Text = "Edit";
            this.buttonEditMatchup.UseVisualStyleBackColor = false;
            this.buttonEditMatchup.Click += new System.EventHandler(this.buttonEditMatchup_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(165)))), ((int)(((byte)(152)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonDelete.ForeColor = System.Drawing.Color.Black;
            this.buttonDelete.Location = new System.Drawing.Point(261, 380);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(108, 35);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.label1.Location = new System.Drawing.Point(366, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 59);
            this.label1.TabIndex = 21;
            this.label1.Text = "ENTRY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(165)))), ((int)(((byte)(152)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(17, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 35);
            this.button1.TabIndex = 22;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // buttonViewMatchPairing
            // 
            this.buttonViewMatchPairing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(165)))), ((int)(((byte)(152)))));
            this.buttonViewMatchPairing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewMatchPairing.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonViewMatchPairing.ForeColor = System.Drawing.Color.Black;
            this.buttonViewMatchPairing.Location = new System.Drawing.Point(17, 421);
            this.buttonViewMatchPairing.Name = "buttonViewMatchPairing";
            this.buttonViewMatchPairing.Size = new System.Drawing.Size(352, 35);
            this.buttonViewMatchPairing.TabIndex = 23;
            this.buttonViewMatchPairing.Text = "View Match Pairing";
            this.buttonViewMatchPairing.UseVisualStyleBackColor = false;
            this.buttonViewMatchPairing.Click += new System.EventHandler(this.ButtonViewMatchPairing_Click);
            // 
            // FormMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(836, 482);
            this.Controls.Add(this.buttonViewMatchPairing);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEditMatchup);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewMatchup);
            this.Controls.Add(this.dataGridViewEntry);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matchup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Matchup_FormClosing);
            this.Load += new System.EventHandler(this.FormMatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatchup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewEntry;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewMatchup;
        private System.Windows.Forms.Button buttonEditMatchup;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonViewMatchPairing;
    }
}