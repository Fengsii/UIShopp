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
    public partial class UpdatePengunjung : Form
    {
        private PerpustakaanController perpustakaanController;
        public UpdatePengunjung()
        {
            perpustakaanController = new PerpustakaanController();
            InitializeComponent();
        }

        private void btnUpdatePengunjung_Click(object sender, EventArgs e)
        {
            perpustakaanController.updatePengunjung(txtUpdateIDPengunjung.Text, txtUpdateNamaPengunjung.Text, txtUpdateJenisKelamin.Text, txtUpdateProgramStudi.Text, txtUpdateKebutuhan.Text, txtUpdateTanggal.Text);
            this.Controls.Clear();
            this.InitializeComponent();
            txtUpdateIDPengunjung.Focus();
            MessageBox.Show("Data Pengunjung Berhasil Diupdate");

            Pengunjung pengunjung = new Pengunjung();
            pengunjung.Show();
            pengunjung.showTable();
            this.Hide();
        }

        private void btnCanceUpdatelPengunjung_Click(object sender, EventArgs e)
        {
            Pengunjung pengunjung = new Pengunjung();
            pengunjung.Show();
            this.Hide();
        }
    }
}
