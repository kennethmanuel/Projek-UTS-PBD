﻿namespace Tournament_Manager
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
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(318, 543);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(137, 44);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxPlayerName
            // 
            this.textBoxPlayerName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlayerName.Location = new System.Drawing.Point(76, 237);
            this.textBoxPlayerName.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.textBoxPlayerName.Name = "textBoxPlayerName";
            this.textBoxPlayerName.Size = new System.Drawing.Size(375, 34);
            this.textBoxPlayerName.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(71, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 27);
            this.label2.TabIndex = 12;
            this.label2.Text = "Player Name";
            // 
            // textBoxPlayerId
            // 
            this.textBoxPlayerId.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlayerId.Location = new System.Drawing.Point(76, 124);
            this.textBoxPlayerId.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.textBoxPlayerId.Name = "textBoxPlayerId";
            this.textBoxPlayerId.Size = new System.Drawing.Size(375, 34);
            this.textBoxPlayerId.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(71, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 27);
            this.label3.TabIndex = 10;
            this.label3.Text = "Player Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 408);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 27);
            this.label1.TabIndex = 17;
            this.label1.Text = "Team";
            // 
            // textBoxPlayerEmail
            // 
            this.textBoxPlayerEmail.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlayerEmail.Location = new System.Drawing.Point(76, 341);
            this.textBoxPlayerEmail.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.textBoxPlayerEmail.Name = "textBoxPlayerEmail";
            this.textBoxPlayerEmail.Size = new System.Drawing.Size(375, 34);
            this.textBoxPlayerEmail.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(71, 292);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 27);
            this.label4.TabIndex = 15;
            this.label4.Text = "Player Email";
            // 
            // comboBoxTeam
            // 
            this.comboBoxTeam.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTeam.FormattingEnabled = true;
            this.comboBoxTeam.Location = new System.Drawing.Point(76, 460);
            this.comboBoxTeam.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.comboBoxTeam.Name = "comboBoxTeam";
            this.comboBoxTeam.Size = new System.Drawing.Size(375, 34);
            this.comboBoxTeam.TabIndex = 18;
            this.comboBoxTeam.SelectedIndexChanged += new System.EventHandler(this.comboBoxTeam_SelectedIndexChanged);
            // 
            // FormAddPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(548, 652);
            this.Controls.Add(this.comboBoxTeam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPlayerEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxPlayerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPlayerId);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Name = "FormAddPlayer";
            this.Text = "FormAddPlayer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAddPlayer_FormClosed);
            this.Load += new System.EventHandler(this.FormAddPlayer_Load);
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