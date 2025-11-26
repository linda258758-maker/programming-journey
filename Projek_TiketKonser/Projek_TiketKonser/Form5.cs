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
    public partial class form5 : Form
    {
        private string Nama;
        private string Tanggal;
        private string Lantai;
        public form5(string nama, string tanggal, string lantai)
        {

            InitializeComponent();
            this.Nama = nama;
            this.Tanggal = tanggal;
            this.Lantai = lantai;
        }

        private void lblData_Click(object sender, EventArgs e)
        {
            lblNama.Text = Nama;
            lblTanggal.Text = Tanggal;
            lblLantai.Text = Lantai;
        }

        private void lblNama_Click(object sender, EventArgs e)
        {

        }
    }
}
