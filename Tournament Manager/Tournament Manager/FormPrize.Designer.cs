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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrize)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDeletePrize
            // 
            this.buttonDeletePrize.Location = new System.Drawing.Point(526, 25);
            this.buttonDeletePrize.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeletePrize.Name = "buttonDeletePrize";
            this.buttonDeletePrize.Size = new System.Drawing.Size(105, 28);
            this.buttonDeletePrize.TabIndex = 7;
            this.buttonDeletePrize.Text = "Delete Prize";
            this.buttonDeletePrize.UseVisualStyleBackColor = true;
            this.buttonDeletePrize.Click += new System.EventHandler(this.buttonDeletePrize_Click);
            // 
            // buttonEditPrize
            // 
            this.buttonEditPrize.Location = new System.Drawing.Point(417, 25);
            this.buttonEditPrize.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEditPrize.Name = "buttonEditPrize";
            this.buttonEditPrize.Size = new System.Drawing.Size(105, 28);
            this.buttonEditPrize.TabIndex = 6;
            this.buttonEditPrize.Text = "Edit Prize";
            this.buttonEditPrize.UseVisualStyleBackColor = true;
            this.buttonEditPrize.Click += new System.EventHandler(this.buttonEditPrize_Click);
            // 
            // buttonAddPrice
            // 
            this.buttonAddPrice.Location = new System.Drawing.Point(308, 25);
            this.buttonAddPrice.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddPrice.Name = "buttonAddPrice";
            this.buttonAddPrice.Size = new System.Drawing.Size(105, 28);
            this.buttonAddPrice.TabIndex = 5;
            this.buttonAddPrice.Text = "Add New Prize";
            this.buttonAddPrice.UseVisualStyleBackColor = true;
            this.buttonAddPrice.Click += new System.EventHandler(this.buttonAddPrice_Click);
            // 
            // dataGridViewPrize
            // 
            this.dataGridViewPrize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrize.Location = new System.Drawing.Point(22, 67);
            this.dataGridViewPrize.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewPrize.Name = "dataGridViewPrize";
            this.dataGridViewPrize.RowHeadersWidth = 51;
            this.dataGridViewPrize.RowTemplate.Height = 24;
            this.dataGridViewPrize.Size = new System.Drawing.Size(610, 271);
            this.dataGridViewPrize.TabIndex = 4;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(22, 30);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(264, 20);
            this.textBoxSearch.TabIndex = 8;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // FormPrize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 362);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonDeletePrize);
            this.Controls.Add(this.buttonEditPrize);
            this.Controls.Add(this.buttonAddPrice);
            this.Controls.Add(this.dataGridViewPrize);
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}