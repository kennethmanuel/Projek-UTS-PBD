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
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxPairingRR = new System.Windows.Forms.ListBox();
            this.buttonGeneratePairingSE = new System.Windows.Forms.Button();
            this.listBoxPairingSE = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(165)))), ((int)(((byte)(152)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button1.Location = new System.Drawing.Point(442, 56);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(354, 41);
            this.button1.TabIndex = 26;
            this.button1.Text = "Generate round robin pairing";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxPairingRR
            // 
            this.listBoxPairingRR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.listBoxPairingRR.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listBoxPairingRR.FormattingEnabled = true;
            this.listBoxPairingRR.ItemHeight = 23;
            this.listBoxPairingRR.Location = new System.Drawing.Point(442, 115);
            this.listBoxPairingRR.Name = "listBoxPairingRR";
            this.listBoxPairingRR.Size = new System.Drawing.Size(354, 441);
            this.listBoxPairingRR.TabIndex = 25;
            // 
            // buttonGeneratePairingSE
            // 
            this.buttonGeneratePairingSE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(165)))), ((int)(((byte)(152)))));
            this.buttonGeneratePairingSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGeneratePairingSE.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonGeneratePairingSE.Location = new System.Drawing.Point(35, 56);
            this.buttonGeneratePairingSE.Margin = new System.Windows.Forms.Padding(5);
            this.buttonGeneratePairingSE.Name = "buttonGeneratePairingSE";
            this.buttonGeneratePairingSE.Size = new System.Drawing.Size(354, 41);
            this.buttonGeneratePairingSE.TabIndex = 24;
            this.buttonGeneratePairingSE.Text = "Generate single elimination pairing";
            this.buttonGeneratePairingSE.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonGeneratePairingSE.UseVisualStyleBackColor = false;
            this.buttonGeneratePairingSE.Click += new System.EventHandler(this.buttonGeneratePairingSE_Click);
            // 
            // listBoxPairingSE
            // 
            this.listBoxPairingSE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.listBoxPairingSE.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listBoxPairingSE.FormattingEnabled = true;
            this.listBoxPairingSE.ItemHeight = 23;
            this.listBoxPairingSE.Location = new System.Drawing.Point(35, 115);
            this.listBoxPairingSE.Name = "listBoxPairingSE";
            this.listBoxPairingSE.Size = new System.Drawing.Size(354, 441);
            this.listBoxPairingSE.TabIndex = 23;
            // 
            // FormBracketGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(842, 585);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxPairingRR);
            this.Controls.Add(this.buttonGeneratePairingSE);
            this.Controls.Add(this.listBoxPairingSE);
            this.Name = "FormBracketGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBracketGenerator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBracketGenerator_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxPairingRR;
        private System.Windows.Forms.Button buttonGeneratePairingSE;
        private System.Windows.Forms.ListBox listBoxPairingSE;
    }
}