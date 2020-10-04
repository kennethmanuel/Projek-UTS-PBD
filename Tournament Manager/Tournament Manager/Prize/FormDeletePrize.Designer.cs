namespace Tournament_Manager.Prize
{
    partial class FormDeletePrize
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
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxPriceAmount = new System.Windows.Forms.TextBox();
            this.textBoxPrizePercentage = new System.Windows.Forms.TextBox();
            this.textBoxPrizePlaceName = new System.Windows.Forms.TextBox();
            this.textBoxPrizeId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTournamentName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Tournaments Name: ";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(232, 213);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 30;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // textBoxPriceAmount
            // 
            this.textBoxPriceAmount.Location = new System.Drawing.Point(129, 138);
            this.textBoxPriceAmount.Name = "textBoxPriceAmount";
            this.textBoxPriceAmount.Size = new System.Drawing.Size(178, 20);
            this.textBoxPriceAmount.TabIndex = 29;
            // 
            // textBoxPrizePercentage
            // 
            this.textBoxPrizePercentage.Location = new System.Drawing.Point(129, 98);
            this.textBoxPrizePercentage.Name = "textBoxPrizePercentage";
            this.textBoxPrizePercentage.Size = new System.Drawing.Size(178, 20);
            this.textBoxPrizePercentage.TabIndex = 28;
            // 
            // textBoxPrizePlaceName
            // 
            this.textBoxPrizePlaceName.Location = new System.Drawing.Point(129, 55);
            this.textBoxPrizePlaceName.Name = "textBoxPrizePlaceName";
            this.textBoxPrizePlaceName.Size = new System.Drawing.Size(178, 20);
            this.textBoxPrizePlaceName.TabIndex = 27;
            // 
            // textBoxPrizeId
            // 
            this.textBoxPrizeId.Location = new System.Drawing.Point(129, 16);
            this.textBoxPrizeId.Name = "textBoxPrizeId";
            this.textBoxPrizeId.Size = new System.Drawing.Size(96, 20);
            this.textBoxPrizeId.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Prize Amount: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Prize Percentage: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Place Name: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Id: ";
            // 
            // textBoxTournamentName
            // 
            this.textBoxTournamentName.Location = new System.Drawing.Point(129, 178);
            this.textBoxTournamentName.Name = "textBoxTournamentName";
            this.textBoxTournamentName.Size = new System.Drawing.Size(178, 20);
            this.textBoxTournamentName.TabIndex = 32;
            // 
            // FormDeletePrize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 249);
            this.Controls.Add(this.textBoxTournamentName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textBoxPriceAmount);
            this.Controls.Add(this.textBoxPrizePercentage);
            this.Controls.Add(this.textBoxPrizePlaceName);
            this.Controls.Add(this.textBoxPrizeId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDeletePrize";
            this.Text = "FormDeletePrize";
            this.Load += new System.EventHandler(this.FormDeletePrize_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textBoxPriceAmount;
        private System.Windows.Forms.TextBox textBoxPrizePercentage;
        private System.Windows.Forms.TextBox textBoxPrizePlaceName;
        private System.Windows.Forms.TextBox textBoxPrizeId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTournamentName;
    }
}