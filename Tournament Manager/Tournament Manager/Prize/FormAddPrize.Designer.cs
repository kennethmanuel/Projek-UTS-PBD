namespace Tournament_Manager.Prize
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPrizeId = new System.Windows.Forms.TextBox();
            this.textBoxPrizePlaceName = new System.Windows.Forms.TextBox();
            this.textBoxPrizePercentage = new System.Windows.Forms.TextBox();
            this.textBoxPriceAmount = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxTournamentsName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Place Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prize Percentage: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prize Amount: ";
            // 
            // textBoxPrizeId
            // 
            this.textBoxPrizeId.Location = new System.Drawing.Point(119, 24);
            this.textBoxPrizeId.Name = "textBoxPrizeId";
            this.textBoxPrizeId.Size = new System.Drawing.Size(96, 20);
            this.textBoxPrizeId.TabIndex = 4;
            // 
            // textBoxPrizePlaceName
            // 
            this.textBoxPrizePlaceName.Location = new System.Drawing.Point(119, 63);
            this.textBoxPrizePlaceName.Name = "textBoxPrizePlaceName";
            this.textBoxPrizePlaceName.Size = new System.Drawing.Size(178, 20);
            this.textBoxPrizePlaceName.TabIndex = 5;
            // 
            // textBoxPrizePercentage
            // 
            this.textBoxPrizePercentage.Location = new System.Drawing.Point(119, 106);
            this.textBoxPrizePercentage.Name = "textBoxPrizePercentage";
            this.textBoxPrizePercentage.Size = new System.Drawing.Size(178, 20);
            this.textBoxPrizePercentage.TabIndex = 6;
            // 
            // textBoxPriceAmount
            // 
            this.textBoxPriceAmount.Location = new System.Drawing.Point(119, 146);
            this.textBoxPriceAmount.Name = "textBoxPriceAmount";
            this.textBoxPriceAmount.Size = new System.Drawing.Size(178, 20);
            this.textBoxPriceAmount.TabIndex = 7;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(222, 221);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tournaments Name: ";
            // 
            // comboBoxTournamentsName
            // 
            this.comboBoxTournamentsName.FormattingEnabled = true;
            this.comboBoxTournamentsName.Location = new System.Drawing.Point(119, 186);
            this.comboBoxTournamentsName.Name = "comboBoxTournamentsName";
            this.comboBoxTournamentsName.Size = new System.Drawing.Size(178, 21);
            this.comboBoxTournamentsName.TabIndex = 10;
            // 
            // FormAddPrize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 266);
            this.Controls.Add(this.comboBoxTournamentsName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxPriceAmount);
            this.Controls.Add(this.textBoxPrizePercentage);
            this.Controls.Add(this.textBoxPrizePlaceName);
            this.Controls.Add(this.textBoxPrizeId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAddPrize";
            this.Text = "FormAddPrize";
            this.Load += new System.EventHandler(this.FormAddPrize_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPrizeId;
        private System.Windows.Forms.TextBox textBoxPrizePlaceName;
        private System.Windows.Forms.TextBox textBoxPrizePercentage;
        private System.Windows.Forms.TextBox textBoxPriceAmount;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxTournamentsName;
    }
}