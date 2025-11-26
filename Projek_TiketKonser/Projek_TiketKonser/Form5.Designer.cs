namespace Projek_TiketKonser
{
    partial class form5
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
            this.lblData = new System.Windows.Forms.Label();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.lblLantai = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Segoe Print", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblData.Location = new System.Drawing.Point(13, 10);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(246, 65);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "Ticket Data";
            this.lblData.Click += new System.EventHandler(this.lblData_Click);
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.BackColor = System.Drawing.Color.DarkGray;
            this.lblTanggal.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanggal.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblTanggal.Location = new System.Drawing.Point(236, 209);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(109, 32);
            this.lblTanggal.TabIndex = 2;
            this.lblTanggal.Text = "Tanggal";
            // 
            // lblLantai
            // 
            this.lblLantai.AutoSize = true;
            this.lblLantai.BackColor = System.Drawing.Color.DarkGray;
            this.lblLantai.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLantai.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblLantai.Location = new System.Drawing.Point(236, 285);
            this.lblLantai.Name = "lblLantai";
            this.lblLantai.Size = new System.Drawing.Size(94, 32);
            this.lblLantai.TabIndex = 3;
            this.lblLantai.Text = "Lantai";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.BackColor = System.Drawing.Color.DarkGray;
            this.lblNama.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblNama.Location = new System.Drawing.Point(236, 127);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(84, 32);
            this.lblNama.TabIndex = 4;
            this.lblNama.Text = "Nama";
            this.lblNama.Click += new System.EventHandler(this.lblNama_Click);
            // 
            // form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(911, 500);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.lblLantai);
            this.Controls.Add(this.lblTanggal);
            this.Controls.Add(this.lblData);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.Label lblLantai;
        private System.Windows.Forms.Label lblNama;
    }
}