namespace Tournament_Manager.TournamentPrize
{
    partial class FormAddPrize
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxPriceAmount = new System.Windows.Forms.TextBox();
            this.textBoxPrizePercentage = new System.Windows.Forms.TextBox();
            this.textBoxPrizePlaceName = new System.Windows.Forms.TextBox();
            this.textBoxPrizeId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(165)))), ((int)(((byte)(152)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonAdd.Location = new System.Drawing.Point(232, 468);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(137, 41);
            this.buttonAdd.TabIndex = 19;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxPriceAmount
            // 
            this.textBoxPriceAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.textBoxPriceAmount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxPriceAmount.Location = new System.Drawing.Point(49, 399);
            this.textBoxPriceAmount.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxPriceAmount.Name = "textBoxPriceAmount";
            this.textBoxPriceAmount.Size = new System.Drawing.Size(320, 30);
            this.textBoxPriceAmount.TabIndex = 18;
            // 
            // textBoxPrizePercentage
            // 
            this.textBoxPrizePercentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.textBoxPrizePercentage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxPrizePercentage.Location = new System.Drawing.Point(49, 318);
            this.textBoxPrizePercentage.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxPrizePercentage.Name = "textBoxPrizePercentage";
            this.textBoxPrizePercentage.Size = new System.Drawing.Size(320, 30);
            this.textBoxPrizePercentage.TabIndex = 17;
            // 
            // textBoxPrizePlaceName
            // 
            this.textBoxPrizePlaceName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.textBoxPrizePlaceName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxPrizePlaceName.Location = new System.Drawing.Point(49, 241);
            this.textBoxPrizePlaceName.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxPrizePlaceName.Name = "textBoxPrizePlaceName";
            this.textBoxPrizePlaceName.Size = new System.Drawing.Size(320, 30);
            this.textBoxPrizePlaceName.TabIndex = 16;
            // 
            // textBoxPrizeId
            // 
            this.textBoxPrizeId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.textBoxPrizeId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxPrizeId.Location = new System.Drawing.Point(49, 166);
            this.textBoxPrizeId.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxPrizeId.Name = "textBoxPrizeId";
            this.textBoxPrizeId.Size = new System.Drawing.Size(320, 30);
            this.textBoxPrizeId.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(45, 371);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Prize Amount: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(45, 290);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Prize Percentage: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(45, 213);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Place Name: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Id: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.label6.Location = new System.Drawing.Point(101, 52);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 51);
            this.label6.TabIndex = 22;
            this.label6.Text = "ADD PRIZE";
            // 
            // FormAddPrize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(427, 549);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxPriceAmount);
            this.Controls.Add(this.textBoxPrizePercentage);
            this.Controls.Add(this.textBoxPrizePlaceName);
            this.Controls.Add(this.textBoxPrizeId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormAddPrize";
            this.Text = "FormAddPrize";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAddPrize_FormClosed);
            this.Load += new System.EventHandler(this.FormAddPrize_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxPriceAmount;
        private System.Windows.Forms.TextBox textBoxPrizePercentage;
        private System.Windows.Forms.TextBox textBoxPrizePlaceName;
        private System.Windows.Forms.TextBox textBoxPrizeId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}