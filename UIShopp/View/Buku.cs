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
    public partial class Buku : UserControl
    {
        private PerpustakaanController perpustakaanController;
        public Buku()
        {
            perpustakaanController = new PerpustakaanController();
            InitializeComponent();
        }

        public void showTable()
        {
            dgvBuku.DataSource = perpustakaanController.tampilBuku(new MySqlCommand("SELECT * FROM buku"));
            //dgvKoleksi.RowTemplate.Height = 50;
            //agar kolom menyesuaikan secara otomatis dengan lebar DataGridView
            dgvBuku.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void btnAddBuku_Click(object sender, EventArgs e)
        {
            AddBuku addBuku = new AddBuku();
            addBuku.Show();
            this.Hide();
        }

        private void Buku_Load(object sender, EventArgs e)
        {
            showTable();
        }

        private void btnUpdateBuku_Click(object sender, EventArgs e)
        {
            UpdateBuku updateBuku = new UpdateBuku();
            updateBuku.Show();
            this.Hide();

            updateBuku.txtUpdateIDBuku.Text = this.dgvBuku.CurrentRow.Cells[0].Value.ToString();
            updateBuku.txtUpdateNamaBuku.Text = this.dgvBuku.CurrentRow.Cells[1].Value.ToString();
            updateBuku.txtUpdatePenulis.Text = this.dgvBuku.CurrentRow.Cells[2].Value.ToString();
            updateBuku.txtUpdateTahunTerbit.Text = this.dgvBuku.CurrentRow.Cells[3].Value.ToString();
            updateBuku.txtUpdateStok.Text = this.dgvBuku.CurrentRow.Cells[4].Value.ToString();
            updateBuku.txtUpdateIDKoleksi.Text = this.dgvBuku.CurrentRow.Cells[5].Value.ToString();
            updateBuku.txtUpdateIDRak.Text = this.dgvBuku.CurrentRow.Cells[6].Value.ToString();
        }

        private void dgvBuku_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDelete1.Text = dgvBuku.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDelete2.Text = dgvBuku.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDelete3.Text = dgvBuku.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDelete4.Text = dgvBuku.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtDelete5.Text = dgvBuku.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtDelete6.Text = dgvBuku.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtDelete7.Text = dgvBuku.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        bool verify()
        {
            if ((txtDelete1.Text == "") || (txtDelete2.Text == "") || (txtDelete3.Text == "") || (txtDelete4.Text == "") ||
                 (txtDelete5.Text == "") || (txtDelete6.Text == "") || (txtDelete7.Text == ""))
            {
                return false;
            }
            else
            {
                return true;
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
            txtDelete7.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (verify())

            {
                try
                {
                    perpustakaanController.hapusBuku(txtDelete1.Text);
                    showTable();
                    btnClear.PerformClick();
                    MessageBox.Show("Koleksi delete succesfully", "delete Buku",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error_barang not delete", "delete buku",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
