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
    public partial class UpdateBuku : Form
    {
        private PerpustakaanController perpustakaanController;
        public UpdateBuku()
        {
            InitializeComponent();
        }

        private void btnUpdateBuku_Click(object sender, EventArgs e)
        {
            perpustakaanController = new PerpustakaanController();
            perpustakaanController.updateBuku(txtUpdateIDBuku.Text, txtUpdateNamaBuku.Text, txtUpdatePenulis.Text, txtUpdateTahunTerbit.Text, txtUpdateStok.Text, txtUpdateIDKoleksi.Text, txtUpdateIDRak.Text);
            this.Controls.Clear();
            this.InitializeComponent();
            txtUpdateIDBuku.Focus();
            MessageBox.Show("Data Buku Berhasil Disimpan");

            Buku buku = new Buku();
            buku.Show();
            buku.showTable();
            this.Hide();
        }

        private void btnCancelUpdateBuku_Click(object sender, EventArgs e)
        {
            Buku buku = new Buku();
            buku.Show();
            this.Hide();
        }
    }
}
