namespace Projek_TiketKonser
{
    partial class form2
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
            this.cmbLantai = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTanggal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblJdl = new System.Windows.Forms.Label();
            this.lblJudul = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.tb_Bayar = new System.Windows.Forms.TextBox();
            this.lbl_Kembalian = new System.Windows.Forms.Label();
            this.btnBayar = new System.Windows.Forms.Button();
            this.btnBatalkan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbLantai
            // 
            this.cmbLantai.BackColor = System.Drawing.Color.DarkGray;
            this.cmbLantai.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLantai.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.cmbLantai.FormattingEnabled = true;
            this.cmbLantai.Items.AddRange(new object[] {
            "BLINK............................................Rp. 4.800.000",
            "VIP..................................................Rp. 3.800.000",
            "PLATINUM..................................Rp. 3.400.000",
            "CAT 1.............................................Rp. 2.900.000",
            "CAT 2.............................................Rp. 2.600.000",
            "CAT 3.............................................Rp. 2.100.000",
            "CAT 4.............................................Rp. 1.350.000"});
            this.cmbLantai.Location = new System.Drawing.Point(194, 283);
            this.cmbLantai.Name = "cmbLantai";
            this.cmbLantai.Size = new System.Drawing.Size(380, 27);
            this.cmbLantai.TabIndex = 10;
            this.cmbLantai.SelectedIndexChanged += new System.EventHandler(this.cmbFloor_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGray;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label3.Location = new System.Drawing.Point(48, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "LANTAI";
            // 
            // cmbTanggal
            // 
            this.cmbTanggal.BackColor = System.Drawing.Color.DarkGray;
            this.cmbTanggal.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTanggal.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.cmbTanggal.FormattingEnabled = true;
            this.cmbTanggal.Items.AddRange(new object[] {
            "DAY1 ( Friday, 25/10/2025)",
            "DAY2 ( Saturday, 26/10/2025)",
            "DAY3 ( Sunday, 27/10/2025)"});
            this.cmbTanggal.Location = new System.Drawing.Point(195, 222);
            this.cmbTanggal.Name = "cmbTanggal";
            this.cmbTanggal.Size = new System.Drawing.Size(379, 27);
            this.cmbTanggal.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label2.Location = new System.Drawing.Point(48, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "TANGGAL";
            // 
            // tbNama
            // 
            this.tbNama.BackColor = System.Drawing.Color.DarkGray;
            this.tbNama.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNama.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.tbNama.Location = new System.Drawing.Point(194, 167);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(380, 27);
            this.tbNama.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label1.Location = new System.Drawing.Point(48, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "NAMA";
            // 
            // lblJdl
            // 
            this.lblJdl.AutoSize = true;
            this.lblJdl.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJdl.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblJdl.Location = new System.Drawing.Point(356, 47);
            this.lblJdl.Name = "lblJdl";
            this.lblJdl.Size = new System.Drawing.Size(351, 19);
            this.lblJdl.TabIndex = 1;
            this.lblJdl.Text = "WELCOME TO OUR TICKET WAR FORUM!!";
            this.lblJdl.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblJudul.Location = new System.Drawing.Point(298, 10);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(465, 37);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "ANNYEONG YEOROBUNN!!!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkGray;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label4.Location = new System.Drawing.Point(622, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "TOTAL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkGray;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label5.Location = new System.Drawing.Point(622, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "BAYAR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkGray;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label6.Location = new System.Drawing.Point(622, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "KEMBALIAN";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.BackColor = System.Drawing.Color.DarkGray;
            this.lbl_Total.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(798, 165);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(24, 25);
            this.lbl_Total.TabIndex = 14;
            this.lbl_Total.Text = "0";
            // 
            // tb_Bayar
            // 
            this.tb_Bayar.BackColor = System.Drawing.Color.DarkGray;
            this.tb_Bayar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Bayar.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.tb_Bayar.Location = new System.Drawing.Point(796, 224);
            this.tb_Bayar.Name = "tb_Bayar";
            this.tb_Bayar.Size = new System.Drawing.Size(228, 27);
            this.tb_Bayar.TabIndex = 15;
            // 
            // lbl_Kembalian
            // 
            this.lbl_Kembalian.AutoSize = true;
            this.lbl_Kembalian.BackColor = System.Drawing.Color.DarkGray;
            this.lbl_Kembalian.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Kembalian.Location = new System.Drawing.Point(798, 285);
            this.lbl_Kembalian.Name = "lbl_Kembalian";
            this.lbl_Kembalian.Size = new System.Drawing.Size(24, 25);
            this.lbl_Kembalian.TabIndex = 16;
            this.lbl_Kembalian.Text = "0";
            // 
            // btnBayar
            // 
            this.btnBayar.BackColor = System.Drawing.Color.DarkGray;
            this.btnBayar.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBayar.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnBayar.Location = new System.Drawing.Point(622, 351);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(157, 44);
            this.btnBayar.TabIndex = 17;
            this.btnBayar.Text = "BAYAR";
            this.btnBayar.UseVisualStyleBackColor = false;
            this.btnBayar.Click += new System.EventHandler(this.btnBayar_Click);
            // 
            // btnBatalkan
            // 
            this.btnBatalkan.BackColor = System.Drawing.Color.DarkGray;
            this.btnBatalkan.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatalkan.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnBatalkan.Location = new System.Drawing.Point(622, 401);
            this.btnBatalkan.Name = "btnBatalkan";
            this.btnBatalkan.Size = new System.Drawing.Size(157, 44);
            this.btnBatalkan.TabIndex = 18;
            this.btnBatalkan.Text = "BATALKAN";
            this.btnBatalkan.UseVisualStyleBackColor = false;
            this.btnBatalkan.Click += new System.EventHandler(this.btnBatalkan_Click);
            // 
            // form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1043, 526);
            this.Controls.Add(this.btnBatalkan);
            this.Controls.Add(this.btnBayar);
            this.Controls.Add(this.lbl_Kembalian);
            this.Controls.Add(this.tb_Bayar);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbLantai);
            this.Controls.Add(this.cmbTanggal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblJdl);
            this.Controls.Add(this.lblJudul);
            this.Name = "form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLantai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTanggal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblJdl;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.TextBox tb_Bayar;
        private System.Windows.Forms.Label lbl_Kembalian;
        private System.Windows.Forms.Button btnBayar;
        private System.Windows.Forms.Button btnBatalkan;
    }
}