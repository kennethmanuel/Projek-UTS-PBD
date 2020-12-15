namespace Tournament_Manager
{
    partial class FormPairing
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
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewPair = new System.Windows.Forms.DataGridView();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonInsertMatchup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPair)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.label5.Location = new System.Drawing.Point(348, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 48);
            this.label5.TabIndex = 19;
            this.label5.Text = "PAIRING";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewPair
            // 
            this.dataGridViewPair.AllowUserToAddRows = false;
            this.dataGridViewPair.AllowUserToDeleteRows = false;
            this.dataGridViewPair.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPair.Location = new System.Drawing.Point(28, 121);
            this.dataGridViewPair.Name = "dataGridViewPair";
            this.dataGridViewPair.RowHeadersWidth = 51;
            this.dataGridViewPair.Size = new System.Drawing.Size(819, 438);
            this.dataGridViewPair.TabIndex = 21;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(733, 79);
            this.buttonInsert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(114, 30);
            this.buttonInsert.TabIndex = 22;
            this.buttonInsert.Text = "Insert Pairing";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(601, 79);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 30);
            this.button1.TabIndex = 23;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonInsertMatchup
            // 
            this.buttonInsertMatchup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(157)))), ((int)(((byte)(106)))));
            this.buttonInsertMatchup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsertMatchup.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonInsertMatchup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.buttonInsertMatchup.Location = new System.Drawing.Point(28, 79);
            this.buttonInsertMatchup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonInsertMatchup.Name = "buttonInsertMatchup";
            this.buttonInsertMatchup.Size = new System.Drawing.Size(150, 36);
            this.buttonInsertMatchup.TabIndex = 24;
            this.buttonInsertMatchup.Text = "Add Matchup";
            this.buttonInsertMatchup.UseVisualStyleBackColor = false;
            this.buttonInsertMatchup.Click += new System.EventHandler(this.buttonInsertMatchup_Click);
            // 
            // FormPairing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(892, 590);
            this.Controls.Add(this.buttonInsertMatchup);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.dataGridViewPair);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormPairing";
            this.Text = "FormPairing";
            this.Load += new System.EventHandler(this.FormPairing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPair)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewPair;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonInsertMatchup;
    }
}