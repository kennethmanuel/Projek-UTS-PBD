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
            this.buttonDeletePrize = new System.Windows.Forms.Button();
            this.buttonEditPrize = new System.Windows.Forms.Button();
            this.buttonAddPrice = new System.Windows.Forms.Button();
            this.dataGridViewPrize = new System.Windows.Forms.DataGridView();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrize)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDeletePrize
            // 
            this.buttonDeletePrize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(165)))), ((int)(((byte)(152)))));
            this.buttonDeletePrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeletePrize.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonDeletePrize.Location = new System.Drawing.Point(619, 110);
            this.buttonDeletePrize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDeletePrize.Name = "buttonDeletePrize";
            this.buttonDeletePrize.Size = new System.Drawing.Size(122, 34);
            this.buttonDeletePrize.TabIndex = 7;
            this.buttonDeletePrize.Text = "Delete Prize";
            this.buttonDeletePrize.UseVisualStyleBackColor = false;
            this.buttonDeletePrize.Click += new System.EventHandler(this.buttonDeletePrize_Click);
            // 
            // buttonEditPrize
            // 
            this.buttonEditPrize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(165)))), ((int)(((byte)(152)))));
            this.buttonEditPrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditPrize.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonEditPrize.Location = new System.Drawing.Point(493, 110);
            this.buttonEditPrize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEditPrize.Name = "buttonEditPrize";
            this.buttonEditPrize.Size = new System.Drawing.Size(122, 34);
            this.buttonEditPrize.TabIndex = 6;
            this.buttonEditPrize.Text = "Edit Prize";
            this.buttonEditPrize.UseVisualStyleBackColor = false;
            this.buttonEditPrize.Click += new System.EventHandler(this.buttonEditPrize_Click);
            // 
            // buttonAddPrice
            // 
            this.buttonAddPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(165)))), ((int)(((byte)(152)))));
            this.buttonAddPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonAddPrice.Location = new System.Drawing.Point(367, 110);
            this.buttonAddPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddPrice.Name = "buttonAddPrice";
            this.buttonAddPrice.Size = new System.Drawing.Size(122, 34);
            this.buttonAddPrice.TabIndex = 5;
            this.buttonAddPrice.Text = "Add New Prize";
            this.buttonAddPrice.UseVisualStyleBackColor = false;
            this.buttonAddPrice.Click += new System.EventHandler(this.buttonAddPrice_Click);
            // 
            // dataGridViewPrize
            // 
            this.dataGridViewPrize.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(92)))), ((int)(((byte)(84)))));
            this.dataGridViewPrize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrize.Location = new System.Drawing.Point(29, 159);
            this.dataGridViewPrize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewPrize.Name = "dataGridViewPrize";
            this.dataGridViewPrize.RowHeadersWidth = 51;
            this.dataGridViewPrize.RowTemplate.Height = 24;
            this.dataGridViewPrize.Size = new System.Drawing.Size(712, 334);
            this.dataGridViewPrize.TabIndex = 4;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxSearch.Location = new System.Drawing.Point(29, 110);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(307, 30);
            this.textBoxSearch.TabIndex = 8;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label5
            // 
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.label5.Location = new System.Drawing.Point(307, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 56);
            this.label5.TabIndex = 20;
            this.label5.Text = "PRIZE";
            // 
            // FormPrize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(771, 520);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonDeletePrize);
            this.Controls.Add(this.buttonEditPrize);
            this.Controls.Add(this.buttonAddPrice);
            this.Controls.Add(this.dataGridViewPrize);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormPrize";
            this.Text = "FormPrize";
            this.Load += new System.EventHandler(this.FormPrize_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDeletePrize;
        private System.Windows.Forms.Button buttonEditPrize;
        private System.Windows.Forms.Button buttonAddPrice;
        private System.Windows.Forms.DataGridView dataGridViewPrize;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label5;
    }
}