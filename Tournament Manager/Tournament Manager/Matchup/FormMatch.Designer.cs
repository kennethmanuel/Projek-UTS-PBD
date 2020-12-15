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
            this.buttonDeleteEntry = new System.Windows.Forms.Button();
            this.buttonEditEntry = new System.Windows.Forms.Button();
            this.dataGridViewEntry = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewMatchup = new System.Windows.Forms.DataGridView();
            this.buttonEditMatchup = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatchup)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDeleteEntry
            // 
            this.buttonDeleteEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(165)))), ((int)(((byte)(152)))));
            this.buttonDeleteEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteEntry.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonDeleteEntry.Location = new System.Drawing.Point(612, 138);
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
            this.buttonEditEntry.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonEditEntry.Location = new System.Drawing.Point(484, 138);
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
            this.dataGridViewEntry.Location = new System.Drawing.Point(291, 179);
            this.dataGridViewEntry.Name = "dataGridViewEntry";
            this.dataGridViewEntry.RowHeadersWidth = 51;
            this.dataGridViewEntry.RowTemplate.Height = 24;
            this.dataGridViewEntry.Size = new System.Drawing.Size(443, 334);
            this.dataGridViewEntry.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.label5.Location = new System.Drawing.Point(45, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 59);
            this.label5.TabIndex = 20;
            this.label5.Text = "MATCHUP";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewMatchup
            // 
            this.dataGridViewMatchup.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(92)))), ((int)(((byte)(84)))));
            this.dataGridViewMatchup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatchup.Location = new System.Drawing.Point(34, 179);
            this.dataGridViewMatchup.Name = "dataGridViewMatchup";
            this.dataGridViewMatchup.RowHeadersWidth = 51;
            this.dataGridViewMatchup.RowTemplate.Height = 24;
            this.dataGridViewMatchup.Size = new System.Drawing.Size(251, 334);
            this.dataGridViewMatchup.TabIndex = 0;
            // 
            // buttonEditMatchup
            // 
            this.buttonEditMatchup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(165)))), ((int)(((byte)(152)))));
            this.buttonEditMatchup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditMatchup.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonEditMatchup.ForeColor = System.Drawing.Color.Black;
            this.buttonEditMatchup.Location = new System.Drawing.Point(34, 138);
            this.buttonEditMatchup.Name = "buttonEditMatchup";
            this.buttonEditMatchup.Size = new System.Drawing.Size(103, 35);
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
            this.buttonDelete.Location = new System.Drawing.Point(141, 138);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(144, 35);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.label1.Location = new System.Drawing.Point(408, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 59);
            this.label1.TabIndex = 21;
            this.label1.Text = "ENTRY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(813, 541);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonDeleteEntry);
            this.Controls.Add(this.buttonEditMatchup);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewMatchup);
            this.Controls.Add(this.buttonEditEntry);
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
        private System.Windows.Forms.Button buttonDeleteEntry;
        private System.Windows.Forms.Button buttonEditEntry;
        private System.Windows.Forms.DataGridView dataGridViewEntry;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewMatchup;
        private System.Windows.Forms.Button buttonEditMatchup;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label1;
    }
}