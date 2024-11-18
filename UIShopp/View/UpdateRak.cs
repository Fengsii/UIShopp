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
    public partial class UpdateRak : Form
    {
        private PerpustakaanController perpustakaanController;
        public UpdateRak()
        {
            perpustakaanController = new PerpustakaanController();
            InitializeComponent();
        }

        private void btnUpdateRak_Click(object sender, EventArgs e)
        {
            perpustakaanController = new PerpustakaanController();
            perpustakaanController.updateRak(txtUpdateIDRak.Text, txtUpdateNamaRak.Text);
            this.Controls.Clear();
            this.InitializeComponent();
            txtUpdateIDRak.Focus();
            MessageBox.Show("Data Rak Berhasil Diupdate");

            Rak rak = new Rak();
            rak.Show();

        }

        private void btnCancelRak_Click(object sender, EventArgs e)
        {
            Rak rak = new Rak();
            rak.Show();
            this.Hide();
        }
    }
}
