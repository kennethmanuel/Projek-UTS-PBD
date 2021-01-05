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
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.buttonPrint2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPair)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.label5.Location = new System.Drawing.Point(283, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(265, 59);
            this.label5.TabIndex = 19;
            this.label5.Text = "PAIRING";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewPair
            // 
            this.dataGridViewPair.AllowUserToAddRows = false;
            this.dataGridViewPair.AllowUserToDeleteRows = false;
            this.dataGridViewPair.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPair.Location = new System.Drawing.Point(13, 107);
            this.dataGridViewPair.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewPair.Name = "dataGridViewPair";
            this.dataGridViewPair.RowHeadersWidth = 51;
            this.dataGridViewPair.Size = new System.Drawing.Size(888, 489);
            this.dataGridViewPair.TabIndex = 21;
            // 
            // buttonPrint2
            // 
            this.buttonPrint2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(165)))), ((int)(((byte)(152)))));
            this.buttonPrint2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonPrint2.Location = new System.Drawing.Point(701, 612);
            this.buttonPrint2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPrint2.Name = "buttonPrint2";
            this.buttonPrint2.Size = new System.Drawing.Size(200, 44);
            this.buttonPrint2.TabIndex = 26;
            this.buttonPrint2.Text = "Print";
            this.buttonPrint2.UseVisualStyleBackColor = false;
            this.buttonPrint2.Click += new System.EventHandler(this.buttonPrint2_Click);
            // 
            // FormPairing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(918, 679);
            this.Controls.Add(this.buttonPrint2);
            this.Controls.Add(this.dataGridViewPair);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPairing";
            this.Text = "FormPairing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPairing_FormClosing);
            this.Load += new System.EventHandler(this.FormPairing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPair)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewPair;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button buttonPrint2;
    }
}