using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIShopp.View;

namespace UIShopp
{
    public partial class Form1 : Form
    {
        private Koleksi koleksi;
        public Form1()
        {
            koleksi = new Koleksi();
            // Berlangganan pada event DataChanged di koleksi
            koleksi.DataChanged += Koleksi_DataChanged;
            InitializeComponent();
        }

        private void Koleksi_DataChanged(object sender, EventArgs e)
        {
            // Tampilkan ulang data di DataGridView atau logika lainnya untuk respon event
            koleksi.showTable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            koleksi1.Hide();
            rak1.Hide();
            buku1.Hide();
            pengunjung1.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            koleksi1.Hide();
            rak1.Hide();
            buku1.Hide();
            pengunjung1.Hide();
        }

        private void btnKoleksi_Click(object sender, EventArgs e)
        {
            rak1.Hide();
            buku1.Hide();
            pengunjung1.Hide();

            koleksi1.Show();
            koleksi1.BringToFront();
        }

        private void btnRak_Click(object sender, EventArgs e)
        {
            koleksi1.Hide();
            buku1.Hide();
            pengunjung1.Hide();

            rak1.Show();
            rak1.BringToFront();

        }


        private void btnBuku_Click(object sender, EventArgs e)
        {
            koleksi1.Hide();
            rak1.Hide();
            pengunjung1.Hide();

            buku1.Show();
            buku1.BringToFront();

        }


        private void btnPengunjung_Click(object sender, EventArgs e)
        {
            koleksi1.Hide();
            buku1.Hide();
            rak1.Hide();

            pengunjung1.Show();
            pengunjung1 .BringToFront();

        }










        private void koleksi1_Load(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        
    }
}
