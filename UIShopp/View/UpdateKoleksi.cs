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
    public partial class UpdateKoleksi : Form
    {
        private PerpustakaanController perpustakaanController;
        public UpdateKoleksi()
        {
            perpustakaanController = new PerpustakaanController();
            InitializeComponent();
        }

        private void btnUpdateKoleksi_Click(object sender, EventArgs e)
        {
            perpustakaanController = new PerpustakaanController();
            perpustakaanController.updateKoleksi(txtUpdateIDKoleksi.Text, txtUpdateNamaKoleksi.Text);
            this.Controls.Clear();
            this.InitializeComponent();
            txtUpdateIDKoleksi.Focus();
            MessageBox.Show("Data Koleksi Berhasil Diupdate");

            Koleksi koleksi = new Koleksi();
            koleksi.Show();
            this.Hide();
        }

        private void btnCancelKoleksi_Click(object sender, EventArgs e)
        {
            Koleksi koleksi = new Koleksi();
            koleksi.Show();
            this.Hide();
        }
    }
}
