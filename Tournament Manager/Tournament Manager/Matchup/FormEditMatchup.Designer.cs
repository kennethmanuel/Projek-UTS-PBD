namespace Tournament_Manager.Tournament_Matchup
{
    partial class FormEditMatchup
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
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePickerMatchup = new System.Windows.Forms.DateTimePicker();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRound = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxScore2 = new System.Windows.Forms.TextBox();
            this.textBoxScore1 = new System.Windows.Forms.TextBox();
            this.comboBoxTeam2 = new System.Windows.Forms.ComboBox();
            this.comboBoxTeam1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.label9.Location = new System.Drawing.Point(268, 72);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 19);
            this.label9.TabIndex = 52;
            this.label9.Text = "DATE:";
            // 
            // dateTimePickerMatchup
            // 
            this.dateTimePickerMatchup.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePickerMatchup.CalendarTitleBackColor = System.Drawing.Color.AliceBlue;
            this.dateTimePickerMatchup.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dateTimePickerMatchup.Location = new System.Drawing.Point(315, 68);
            this.dateTimePickerMatchup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerMatchup.Name = "dateTimePickerMatchup";
            this.dateTimePickerMatchup.Size = new System.Drawing.Size(239, 25);
            this.dateTimePickerMatchup.TabIndex = 51;
            // 
            // textBoxId
            // 
            this.textBoxId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.textBoxId.Enabled = false;
            this.textBoxId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxId.Location = new System.Drawing.Point(281, 25);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(97, 25);
            this.textBoxId.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.label8.Location = new System.Drawing.Point(248, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 19);
            this.label8.TabIndex = 49;
            this.label8.Text = "ID";
            // 
            // label7
            // 
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.label7.Location = new System.Drawing.Point(14, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(274, 57);
            this.label7.TabIndex = 48;
            this.label7.Text = "EDIT MATCHUP";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(165)))), ((int)(((byte)(152)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonAdd.Location = new System.Drawing.Point(436, 198);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(116, 35);
            this.buttonAdd.TabIndex = 47;
            this.buttonAdd.Text = "Edit";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.label6.Location = new System.Drawing.Point(327, 127);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 19);
            this.label6.TabIndex = 46;
            this.label6.Text = "Score";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.label5.Location = new System.Drawing.Point(202, 128);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 19);
            this.label5.TabIndex = 45;
            this.label5.Text = "Score";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.label4.Location = new System.Drawing.Point(453, 127);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 19);
            this.label4.TabIndex = 44;
            this.label4.Text = "Team 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.label2.Location = new System.Drawing.Point(70, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 43;
            this.label2.Text = "Team 1";
            // 
            // textBoxRound
            // 
            this.textBoxRound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.textBoxRound.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxRound.Location = new System.Drawing.Point(456, 25);
            this.textBoxRound.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBoxRound.Name = "textBoxRound";
            this.textBoxRound.Size = new System.Drawing.Size(97, 25);
            this.textBoxRound.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.label1.Location = new System.Drawing.Point(388, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 41;
            this.label1.Text = "ROUND";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.label3.Location = new System.Drawing.Point(284, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 19);
            this.label3.TabIndex = 40;
            this.label3.Text = ":";
            // 
            // textBoxScore2
            // 
            this.textBoxScore2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.textBoxScore2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxScore2.Location = new System.Drawing.Point(303, 158);
            this.textBoxScore2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBoxScore2.Name = "textBoxScore2";
            this.textBoxScore2.Size = new System.Drawing.Size(97, 25);
            this.textBoxScore2.TabIndex = 39;
            // 
            // textBoxScore1
            // 
            this.textBoxScore1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.textBoxScore1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxScore1.Location = new System.Drawing.Point(178, 158);
            this.textBoxScore1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBoxScore1.Name = "textBoxScore1";
            this.textBoxScore1.Size = new System.Drawing.Size(97, 25);
            this.textBoxScore1.TabIndex = 38;
            // 
            // comboBoxTeam2
            // 
            this.comboBoxTeam2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.comboBoxTeam2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxTeam2.FormattingEnabled = true;
            this.comboBoxTeam2.Location = new System.Drawing.Point(410, 158);
            this.comboBoxTeam2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.comboBoxTeam2.Name = "comboBoxTeam2";
            this.comboBoxTeam2.Size = new System.Drawing.Size(144, 25);
            this.comboBoxTeam2.TabIndex = 37;
            // 
            // comboBoxTeam1
            // 
            this.comboBoxTeam1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.comboBoxTeam1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxTeam1.FormattingEnabled = true;
            this.comboBoxTeam1.Location = new System.Drawing.Point(21, 158);
            this.comboBoxTeam1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.comboBoxTeam1.Name = "comboBoxTeam1";
            this.comboBoxTeam1.Size = new System.Drawing.Size(147, 25);
            this.comboBoxTeam1.TabIndex = 36;
            // 
            // FormEditMatchup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(566, 253);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePickerMatchup);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRound);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxScore2);
            this.Controls.Add(this.textBoxScore1);
            this.Controls.Add(this.comboBoxTeam2);
            this.Controls.Add(this.comboBoxTeam1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormEditMatchup";
            this.Text = "FormEditMatchup";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEditMatchup_FormClosed);
            this.Load += new System.EventHandler(this.FormEditMatchup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePickerMatchup;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRound;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxScore2;
        private System.Windows.Forms.TextBox textBoxScore1;
        private System.Windows.Forms.ComboBox comboBoxTeam2;
        private System.Windows.Forms.ComboBox comboBoxTeam1;
    }
}