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
            this.buttonLoadTournament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(165)))), ((int)(((byte)(152)))));
            this.buttonLoadTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadTournament.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonLoadTournament.Location = new System.Drawing.Point(55, 315);
            this.buttonLoadTournament.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLoadTournament.Name = "buttonLoadTournament";
            this.buttonLoadTournament.Size = new System.Drawing.Size(324, 45);
            this.buttonLoadTournament.TabIndex = 7;
            this.buttonLoadTournament.Text = "Load Tournament";
            this.buttonLoadTournament.UseVisualStyleBackColor = false;
            this.buttonLoadTournament.Click += new System.EventHandler(this.buttonLoadTournament_Click);
            // 
            // buttonCreateTournament
            // 
            this.buttonCreateTournament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(165)))), ((int)(((byte)(152)))));
            this.buttonCreateTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateTournament.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonCreateTournament.Location = new System.Drawing.Point(55, 262);
            this.buttonCreateTournament.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreateTournament.Name = "buttonCreateTournament";
            this.buttonCreateTournament.Size = new System.Drawing.Size(324, 45);
            this.buttonCreateTournament.TabIndex = 6;
            this.buttonCreateTournament.Text = "Create New Tournament";
            this.buttonCreateTournament.UseVisualStyleBackColor = false;
            this.buttonCreateTournament.Click += new System.EventHandler(this.buttonCreateTournament_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tournament Name";
            // 
            // comboBoxTournament
            // 
            this.comboBoxTournament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.comboBoxTournament.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTournament.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxTournament.FormattingEnabled = true;
            this.comboBoxTournament.Location = new System.Drawing.Point(55, 191);
            this.comboBoxTournament.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTournament.Name = "comboBoxTournament";
            this.comboBoxTournament.Size = new System.Drawing.Size(323, 31);
            this.comboBoxTournament.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.label5.Location = new System.Drawing.Point(47, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(348, 55);
            this.label5.TabIndex = 19;
            this.label5.Text = "TOURNAMENT";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(443, 402);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonLoadTournament);
            this.Controls.Add(this.buttonCreateTournament);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTournament);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
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