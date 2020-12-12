namespace Tournament_Manager
{
    partial class FormBracketGenerator
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
            this.listBoxPairingSE = new System.Windows.Forms.ListBox();
            this.buttonGeneratePairingSE = new System.Windows.Forms.Button();
            this.listBoxPairingRR = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxPairingSE
            // 
            this.listBoxPairingSE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.listBoxPairingSE.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listBoxPairingSE.FormattingEnabled = true;
            this.listBoxPairingSE.ItemHeight = 17;
            this.listBoxPairingSE.Location = new System.Drawing.Point(26, 93);
            this.listBoxPairingSE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxPairingSE.Name = "listBoxPairingSE";
            this.listBoxPairingSE.Size = new System.Drawing.Size(266, 344);
            this.listBoxPairingSE.TabIndex = 23;
            // 
            // buttonGeneratePairingSE
            // 
            this.buttonGeneratePairingSE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(165)))), ((int)(((byte)(152)))));
            this.buttonGeneratePairingSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGeneratePairingSE.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonGeneratePairingSE.Location = new System.Drawing.Point(26, 46);
            this.buttonGeneratePairingSE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGeneratePairingSE.Name = "buttonGeneratePairingSE";
            this.buttonGeneratePairingSE.Size = new System.Drawing.Size(266, 33);
            this.buttonGeneratePairingSE.TabIndex = 24;
            this.buttonGeneratePairingSE.Text = "Generate single elimination pairing";
            this.buttonGeneratePairingSE.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonGeneratePairingSE.UseVisualStyleBackColor = false;
            this.buttonGeneratePairingSE.Click += new System.EventHandler(this.buttonGeneratePairingSE_Click);
            // 
            // listBoxPairingRR
            // 
            this.listBoxPairingRR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.listBoxPairingRR.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listBoxPairingRR.FormattingEnabled = true;
            this.listBoxPairingRR.ItemHeight = 17;
            this.listBoxPairingRR.Location = new System.Drawing.Point(332, 93);
            this.listBoxPairingRR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxPairingRR.Name = "listBoxPairingRR";
            this.listBoxPairingRR.Size = new System.Drawing.Size(266, 344);
            this.listBoxPairingRR.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(165)))), ((int)(((byte)(152)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button1.Location = new System.Drawing.Point(332, 46);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 33);
            this.button1.TabIndex = 26;
            this.button1.Text = "Generate round robin pairing";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormBracketGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(632, 475);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxPairingRR);
            this.Controls.Add(this.buttonGeneratePairingSE);
            this.Controls.Add(this.listBoxPairingSE);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormBracketGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBracketGenerator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBracketGenerator_FormClosing);
            this.Load += new System.EventHandler(this.FormBracketGenerator_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPairingSE;
        private System.Windows.Forms.Button buttonGeneratePairingSE;
        private System.Windows.Forms.ListBox listBoxPairingRR;
        private System.Windows.Forms.Button button1;
    }
}