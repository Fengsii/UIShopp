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
    public partial class AddKoleksi : Form
    {
        private PerpustakaanController perpustakaanController;

        public event EventHandler DataChanged;

        protected virtual void OnDataChanged()
        {
            DataChanged?.Invoke(this, EventArgs.Empty);
        }
        public AddKoleksi()
        {
            InitializeComponent();
        }

        private void btnAddKoleksi_Click(object sender, EventArgs e)
        {
            perpustakaanController = new PerpustakaanController();
            perpustakaanController.tambahKoleksi(txtAddIDKoleksi.Text, txtAddNamaKoleksi.Text);
            this.Controls.Clear();
            this.InitializeComponent();
            txtAddIDKoleksi.Focus();
            MessageBox.Show("Data Koleksi Berhasil Disimpan");

            Koleksi koleksi = new Koleksi();
            koleksi.Show();
            koleksi.showTable();
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
