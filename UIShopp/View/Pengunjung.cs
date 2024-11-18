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
    public partial class Pengunjung : UserControl
    {
        private PerpustakaanController perpustakaanController;
        public Pengunjung()
        {
            perpustakaanController = new PerpustakaanController();
            InitializeComponent();
        }

        public void showTable()
        {
            dgvPengunjung.DataSource = perpustakaanController.tampilPengunjung(new MySqlCommand("SELECT * FROM pengunjung"));
            //dgvKoleksi.RowTemplate.Height = 50;
            //agar kolom menyesuaikan secara otomatis dengan lebar DataGridView
            dgvPengunjung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Pengunjung_Load(object sender, EventArgs e)
        {
            showTable();
        }

        private void btnAddPengunjung_Click(object sender, EventArgs e)
        {
            AddPengunjung addPengunjung = new AddPengunjung();
            addPengunjung.Show();
            this.Hide();
        }

        private void btnUpdatePengunjung_Click(object sender, EventArgs e)
        {
            UpdatePengunjung updatePengunjung = new UpdatePengunjung();
            updatePengunjung.Show();
            this.Hide();

            updatePengunjung.txtUpdateIDPengunjung.Text = this.dgvPengunjung.CurrentRow.Cells[0].Value.ToString();
            updatePengunjung.txtUpdateNamaPengunjung.Text = this.dgvPengunjung.CurrentRow.Cells[1].Value.ToString();
            updatePengunjung.txtUpdateJenisKelamin.Text = this.dgvPengunjung.CurrentRow.Cells[2].Value.ToString();
            updatePengunjung.txtUpdateProgramStudi.Text = this.dgvPengunjung.CurrentRow.Cells[3].Value.ToString();
            updatePengunjung.txtUpdateKebutuhan.Text = this.dgvPengunjung.CurrentRow.Cells[4].Value.ToString();
            updatePengunjung.txtUpdateTanggal.Text = this.dgvPengunjung.CurrentRow.Cells[5].Value.ToString();
        }

        private void dgvPengunjung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDelete1.Text = dgvPengunjung.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDelete2.Text = dgvPengunjung.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDelete3.Text = dgvPengunjung.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDelete4.Text = dgvPengunjung.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtDelete5.Text = dgvPengunjung.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtDelete6.Text = dgvPengunjung.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        bool verify()
        {
            if ((txtDelete1.Text == "") || (txtDelete2.Text == "") || (txtDelete3.Text == "") || (txtDelete4.Text == "") ||
                 (txtDelete5.Text == "") || (txtDelete6.Text == ""))
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
                    perpustakaanController.hapusPengunjung(txtDelete1.Text);
                    showTable();
                    btnClear.PerformClick();
                    MessageBox.Show("Koleksi delete succesfully", "delete Pengunjung",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error_barang not delete", "delete pengunjung",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDelete1.Clear();
            txtDelete2.Clear();
            txtDelete3.Clear();
            txtDelete4.Clear();
            txtDelete5.Clear();
            txtDelete6.Clear();
        }
    }
}
