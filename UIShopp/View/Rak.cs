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
    public partial class Rak : UserControl
    {
        PerpustakaanController perpustakaanController;
        public Rak()
        {
            perpustakaanController = new PerpustakaanController();
            InitializeComponent();
        }

        public void showTable()
        {
            dgvRak.DataSource = perpustakaanController.tampilRak(new MySqlCommand("SELECT * FROM rak"));
            //dgvKoleksi.RowTemplate.Height = 50;
            //agar kolom menyesuaikan secara otomatis dengan lebar DataGridView
            dgvRak.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Rak_Load(object sender, EventArgs e)
        {
            showTable();
        }

        private void btnAddRak_Click(object sender, EventArgs e)
        {
            AddRak addRak = new AddRak();
            addRak.Show();
            this.Hide();
        }

        private void btnUpdateRak_Click(object sender, EventArgs e)
        {
            UpdateRak updateRak = new UpdateRak();
            updateRak.Show();
            this.Hide();

            updateRak.txtUpdateIDRak.Text = this.dgvRak.CurrentRow.Cells[0].Value.ToString();
            updateRak.txtUpdateNamaRak.Text = this.dgvRak.CurrentRow.Cells[1].Value.ToString();
        }

        private void dgvRak_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDelete1.Text = dgvRak.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDelete2.Text = dgvRak.Rows[e.RowIndex].Cells[1].Value.ToString();
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
                    perpustakaanController.hapusRak(txtDelete1.Text);
                    showTable();
                    btnClear.PerformClick();
                    MessageBox.Show("Koleksi delete succesfully", "delete rak",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error_barang not delete", "delete barang",
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
