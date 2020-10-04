namespace Tournament_Manager
{
    partial class FormTournament
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
            this.buttonLoadTournament = new System.Windows.Forms.Button();
            this.buttonCreateTournament = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTournament = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLoadTournament
            // 
            this.buttonLoadTournament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.buttonLoadTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadTournament.Location = new System.Drawing.Point(77, 457);
            this.buttonLoadTournament.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonLoadTournament.Name = "buttonLoadTournament";
            this.buttonLoadTournament.Size = new System.Drawing.Size(453, 65);
            this.buttonLoadTournament.TabIndex = 7;
            this.buttonLoadTournament.Text = "Load Tournament";
            this.buttonLoadTournament.UseVisualStyleBackColor = false;
            this.buttonLoadTournament.Click += new System.EventHandler(this.buttonLoadTournament_Click);
            // 
            // buttonCreateTournament
            // 
            this.buttonCreateTournament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.buttonCreateTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateTournament.Location = new System.Drawing.Point(77, 381);
            this.buttonCreateTournament.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonCreateTournament.Name = "buttonCreateTournament";
            this.buttonCreateTournament.Size = new System.Drawing.Size(453, 65);
            this.buttonCreateTournament.TabIndex = 6;
            this.buttonCreateTournament.Text = "Create New Tournament";
            this.buttonCreateTournament.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 218);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tournament Name";
            // 
            // comboBoxTournament
            // 
            this.comboBoxTournament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBoxTournament.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTournament.FormattingEnabled = true;
            this.comboBoxTournament.Location = new System.Drawing.Point(77, 277);
            this.comboBoxTournament.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.comboBoxTournament.Name = "comboBoxTournament";
            this.comboBoxTournament.Size = new System.Drawing.Size(450, 37);
            this.comboBoxTournament.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Perpetua Titling MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Coral;
            this.label5.Location = new System.Drawing.Point(65, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 39);
            this.label5.TabIndex = 19;
            this.label5.Text = "TOURNAMENT";
            // 
            // FormTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(639, 584);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonLoadTournament);
            this.Controls.Add(this.buttonCreateTournament);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTournament);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormTournament";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTournament";
            this.Load += new System.EventHandler(this.FormTournament_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadTournament;
        private System.Windows.Forms.Button buttonCreateTournament;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTournament;
        private System.Windows.Forms.Label label5;
    }
}