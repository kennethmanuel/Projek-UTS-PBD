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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPair)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.label5.Location = new System.Drawing.Point(464, 38);
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
            this.dataGridViewPair.Location = new System.Drawing.Point(37, 149);
            this.dataGridViewPair.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewPair.Name = "dataGridViewPair";
            this.dataGridViewPair.RowHeadersWidth = 51;
            this.dataGridViewPair.Size = new System.Drawing.Size(1092, 539);
            this.dataGridViewPair.TabIndex = 21;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(977, 78);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(152, 37);
            this.buttonInsert.TabIndex = 22;
            this.buttonInsert.Text = "Insert Pairing";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(793, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 37);
            this.button1.TabIndex = 23;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormPairing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1189, 726);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.dataGridViewPair);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
    }
}