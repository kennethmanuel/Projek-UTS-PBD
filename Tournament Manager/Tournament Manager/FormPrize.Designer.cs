namespace Tournament_Manager
{
    partial class FormPrize
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewPrize = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrize)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(702, 31);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 35);
            this.button4.TabIndex = 7;
            this.button4.Text = "Delete Macthup";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(556, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 35);
            this.button3.TabIndex = 6;
            this.button3.Text = "Edit Matchup";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(410, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add New Matchup";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPrize
            // 
            this.dataGridViewPrize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrize.Location = new System.Drawing.Point(29, 83);
            this.dataGridViewPrize.Name = "dataGridViewPrize";
            this.dataGridViewPrize.RowHeadersWidth = 51;
            this.dataGridViewPrize.RowTemplate.Height = 24;
            this.dataGridViewPrize.Size = new System.Drawing.Size(813, 334);
            this.dataGridViewPrize.TabIndex = 4;
            // 
            // FormPrize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 446);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewPrize);
            this.Name = "FormPrize";
            this.Text = "FormPrize";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewPrize;
    }
}