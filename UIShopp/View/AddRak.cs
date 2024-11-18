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
    public partial class AddRak : Form
    {
        PerpustakaanController perpustakaanController;
        public AddRak()
        {
            InitializeComponent();
        }

        private void btnAddKoleksi_Click(object sender, EventArgs e)
        {
            perpustakaanController = new PerpustakaanController();
            perpustakaanController.tambahRak(txtAddIDRak.Text, txtAddNamaRak.Text);
            this.Controls.Clear();
            this.InitializeComponent();
            txtAddIDRak.Focus();
            MessageBox.Show("Data Koleksi Berhasil Disimpan");

            Rak rak = new Rak();
            rak.Show();
            rak.showTable();
            this.Hide();
        }

        private void btnCancelRak_Click(object sender, EventArgs e)
        {
            Rak rak = new Rak();
            rak.Show();
            this.Hide();
        }
    }
}
