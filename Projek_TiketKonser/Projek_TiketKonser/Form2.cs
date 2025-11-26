using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projek_TiketKonser
{
    public partial class form2 : Form
    {
        int TotalHarga = 0;
        public form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
             BLINK............................................Rp. 4.800.000
             VIP..................................................Rp. 3.800.000
             PLATINUM..................................Rp. 3.400.000
             CAT 1.............................................Rp. 2.900.000
             CAT 2.............................................Rp. 2.600.000
             CAT 3.............................................Rp. 2.100.000
             CAT 4.............................................Rp. 1.350.000*/
            if (cmbLantai.SelectedIndex == 0)
            {
                lbl_Total.Text = "4.800.000";
                TotalHarga = 4800000;

            }
            if (cmbLantai.SelectedIndex == 1)
            {
                lbl_Total.Text = "3.800.000";
                TotalHarga = 3800000;
            }
            if (cmbLantai.SelectedIndex == 2)
            {
                lbl_Total.Text = "3.400.000";
                TotalHarga = 3400000;
            }
            if (cmbLantai.SelectedIndex == 3)
            {
                lbl_Total.Text = "2.900.000";
                TotalHarga = 2900000;
            }
            if (cmbLantai.SelectedIndex == 4)
            {
                lbl_Total.Text = "2.600.000";
                TotalHarga = 2600000;
            }
            if (cmbLantai.SelectedIndex == 5)
            {
                lbl_Total.Text = "2.100.000";
                TotalHarga = 2100000;
            }
            if (cmbLantai.SelectedIndex == 6)
            {
                lbl_Total.Text = "1.350.000";
                TotalHarga = 1350000;
            }
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            if(int.TryParse(tb_Bayar.Text, out int bayar))
            {
                int total = TotalHarga;
                int kembalian = bayar - total;

                lbl_Kembalian.Text = kembalian.ToString();
            }

        }

        private void btnBatalkan_Click(object sender, EventArgs e)
        { 
            // Reset semua input ke keadaan awal
            tbNama.Text = "";
            cmbTanggal.Text = ""; // Jika menggunakan ComboBox untuk tanggal
            cmbLantai.Text  = ""; // Kembali ke pilihan Lantai Pertama
            tb_Bayar.Text = "";
            lbl_Kembalian.Text = "0";
            lbl_Total.Text = "0"; // Set ulang total

            // fokus ke input Nama
            tbNama.Focus();

            MessageBox.Show("Semua data telah dibatalkan/direset.",
                            "Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
