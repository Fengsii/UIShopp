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
    public partial class AddPengunjung : Form
    {
        private PerpustakaanController perpustakaanController;
        public AddPengunjung()
        {
            perpustakaanController = new PerpustakaanController();
            InitializeComponent();
        }

        private void btnAddPengunjung_Click(object sender, EventArgs e)
        {
            perpustakaanController.tambahPengunjung(txtAddIDPengunjung.Text, txtAddNamaPengunjung.Text, txtJenisKelamin.Text, txtProgramStudi.Text, txtKebutuhan.Text, txtTanggal.Text);
            this.Controls.Clear();
            this.InitializeComponent();
            txtAddIDPengunjung.Focus();
            MessageBox.Show("Data Pengunjung Berhasil Disimpan");

            Pengunjung pengunjung = new Pengunjung();
            pengunjung.Show();
            pengunjung.showTable();
            this.Hide();
        }

        private void btnCancelPengunjung_Click(object sender, EventArgs e)
        {
            Pengunjung pengunjung = new Pengunjung();
            pengunjung.Show();
            this.Hide();
        }
    }
}
