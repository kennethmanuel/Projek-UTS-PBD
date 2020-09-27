namespace Tournament_Manager
{
    partial class FormAddPlayer
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
            this.textBoxPlayerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPlayerId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPlayerEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxTeam = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(204, 334);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // textBoxPlayerName
            // 
            this.textBoxPlayerName.Location = new System.Drawing.Point(47, 147);
            this.textBoxPlayerName.Name = "textBoxPlayerName";
            this.textBoxPlayerName.Size = new System.Drawing.Size(232, 22);
            this.textBoxPlayerName.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Player Name";
            // 
            // textBoxPlayerId
            // 
            this.textBoxPlayerId.Location = new System.Drawing.Point(47, 76);
            this.textBoxPlayerId.Name = "textBoxPlayerId";
            this.textBoxPlayerId.Size = new System.Drawing.Size(232, 22);
            this.textBoxPlayerId.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Player Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Team";
            // 
            // textBoxPlayerEmail
            // 
            this.textBoxPlayerEmail.Location = new System.Drawing.Point(47, 211);
            this.textBoxPlayerEmail.Name = "textBoxPlayerEmail";
            this.textBoxPlayerEmail.Size = new System.Drawing.Size(232, 22);
            this.textBoxPlayerEmail.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Player Email";
            // 
            // comboBoxTeam
            // 
            this.comboBoxTeam.FormattingEnabled = true;
            this.comboBoxTeam.Location = new System.Drawing.Point(47, 283);
            this.comboBoxTeam.Name = "comboBoxTeam";
            this.comboBoxTeam.Size = new System.Drawing.Size(232, 24);
            this.comboBoxTeam.TabIndex = 18;
            // 
            // FormAddPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 401);
            this.Controls.Add(this.comboBoxTeam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPlayerEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxPlayerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPlayerId);
            this.Controls.Add(this.label3);
            this.Name = "FormAddPlayer";
            this.Text = "FormAddPlayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxPlayerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPlayerId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPlayerEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxTeam;
    }
}