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
    public partial class Koleksi : UserControl
    {
        private PerpustakaanController perpustakaanController;

        public event EventHandler DataChanged;

        protected virtual void OnDataChanged()
        {
            DataChanged?.Invoke(this, EventArgs.Empty);
        }

        public Koleksi()
        {
            perpustakaanController = new PerpustakaanController();
            InitializeComponent();
        }

        public void showTable()
        {
            dgvKoleksi.DataSource = perpustakaanController.tampilKoleksi(new MySqlCommand("SELECT * FROM koleksi"));
            //dgvKoleksi.RowTemplate.Height = 50;
            //agar kolom menyesuaikan secara otomatis dengan lebar DataGridView
            dgvKoleksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Koleksi_Load(object sender, EventArgs e)
        {
            showTable();
        }

        private void btnAddKoleksi_Click(object sender, EventArgs e)
        {
            AddKoleksi addKoleksi = new AddKoleksi();
            addKoleksi.Show();
            this.Hide();
        }

        private void btnUpdateKoleksi_Click(object sender, EventArgs e)
        {
            UpdateKoleksi updateKoleksi = new UpdateKoleksi();
            updateKoleksi.Show();
            this.Hide();

            updateKoleksi.txtUpdateIDKoleksi.Text = this.dgvKoleksi.CurrentRow.Cells[0].Value.ToString();
            updateKoleksi.txtUpdateNamaKoleksi.Text = this.dgvKoleksi.CurrentRow.Cells[1].Value.ToString();
        }

        private void dgvKoleksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDelete1.Text = dgvKoleksi.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDelete2.Text = dgvKoleksi.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        bool verify()
        {
            if ((txtDelete1.Text == "") || (txtDelete2.Text == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (verify())

            {
                try
                {
                    perpustakaanController.hapusKoleksi(txtDelete1.Text);
                    showTable();
                    btnClear.PerformClick();
                    MessageBox.Show("Koleksi delete succesfully", "delete Koleksi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OnDataChanged();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error_barang not delete", "delete koleksi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDelete1.Clear();
            txtDelete2.Clear();
        }
    }
}
