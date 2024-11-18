using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIShopp.Controller;

namespace UIShopp.View
{
    public partial class AddBuku : Form
    {
        private PerpustakaanController perpustakaanController;
        public AddBuku()
        {
            InitializeComponent();
        }

        private void btnAddBuku_Click(object sender, EventArgs e)
        {
            perpustakaanController = new PerpustakaanController();
            perpustakaanController.tambahBuku(txtAddIDBuku.Text, txtAddNamaBuku.Text, txtPenulis.Text, txtTahunTerbit.Text, txtStok.Text, txtIDKoleksi.Text, txtTanggal.Text);
            this.Controls.Clear();
            this.InitializeComponent();
            txtAddIDBuku.Focus();
            MessageBox.Show("Data Koleksi Berhasil Disimpan");

            Buku buku = new Buku();
            buku.Show();
            buku.showTable();
            this.Hide();
        }

        private void btnCancelBuku_Click(object sender, EventArgs e)
        {
            Buku buku = new Buku();
            buku.Show();
            this.Hide();
        }

        private void AddBuku_Load(object sender, EventArgs e)
        {

        }
    }
}
