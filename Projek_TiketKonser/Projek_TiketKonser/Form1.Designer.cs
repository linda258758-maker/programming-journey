namespace Projek_TiketKonser
{
    partial class Form1
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
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblJdl = new System.Windows.Forms.Label();
            this.lblBorn = new System.Windows.Forms.Label();
            this.lblJis = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblWorld = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblJudul.Font = new System.Drawing.Font("Segoe Print", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblJudul.Location = new System.Drawing.Point(-1, -2);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(268, 84);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "BlackPink";
            this.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJdl
            // 
            this.lblJdl.AutoSize = true;
            this.lblJdl.BackColor = System.Drawing.Color.Black;
            this.lblJdl.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJdl.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblJdl.Location = new System.Drawing.Point(25, 69);
            this.lblJdl.Name = "lblJdl";
            this.lblJdl.Size = new System.Drawing.Size(158, 30);
            this.lblJdl.TabIndex = 1;
            this.lblJdl.Text = "Tour BLACKPINK 2025 In \r\nIndonesia";
            this.lblJdl.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblBorn
            // 
            this.lblBorn.AutoSize = true;
            this.lblBorn.BackColor = System.Drawing.Color.Black;
            this.lblBorn.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorn.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblBorn.Location = new System.Drawing.Point(147, 172);
            this.lblBorn.Name = "lblBorn";
            this.lblBorn.Size = new System.Drawing.Size(734, 135);
            this.lblBorn.TabIndex = 2;
            this.lblBorn.Text = "BORN PINK";
            // 
            // lblJis
            // 
            this.lblJis.AutoSize = true;
            this.lblJis.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJis.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblJis.Location = new System.Drawing.Point(732, 9);
            this.lblJis.Name = "lblJis";
            this.lblJis.Size = new System.Drawing.Size(283, 20);
            this.lblJis.TabIndex = 3;
            this.lblJis.Text = "Jakarta International Stadium(JIS)";
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnOpen.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(479, 423);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(82, 36);
            this.btnOpen.TabIndex = 5;
            this.btnOpen.Text = "OPEN";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblWorld
            // 
            this.lblWorld.AutoSize = true;
            this.lblWorld.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorld.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblWorld.Location = new System.Drawing.Point(459, 307);
            this.lblWorld.Name = "lblWorld";
            this.lblWorld.Size = new System.Drawing.Size(118, 20);
            this.lblWorld.TabIndex = 6;
            this.lblWorld.Text = "WORLD TOUR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1027, 533);
            this.Controls.Add(this.lblWorld);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.lblJis);
            this.Controls.Add(this.lblBorn);
            this.Controls.Add(this.lblJdl);
            this.Controls.Add(this.lblJudul);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblJdl;
        private System.Windows.Forms.Label lblBorn;
        private System.Windows.Forms.Label lblJis;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lblWorld;
    }
}

