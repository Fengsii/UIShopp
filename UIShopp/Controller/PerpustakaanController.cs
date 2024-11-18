using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIShopp.Controller
{
    internal class PerpustakaanController:Model.Connection
    {
        public DataTable tampilKoleksi(MySqlCommand c)
        {
            DataTable data = new DataTable();
            try
            {
                string tampil = "SELECT * FROM koleksi";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }

        public void tambahKoleksi(string idKoleksi, string namaKoleksi)
        {
            string tambah = "insert into koleksi values(" + "@id_koleksi,@nama_koleksi)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@id_koleksi", MySqlConnector.MySqlDbType.VarChar).Value = idKoleksi;
                cmd.Parameters.Add("@nama_koleksi", MySqlConnector.MySqlDbType.VarChar).Value = namaKoleksi;
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah Koleksi Gagal" + ex.Message);
            }
        }

        public void updateKoleksi(string idKoleksi, string namaKoleksi)
        {
            string update = "update koleksi set nama_koleksi=@nama_koleksi where id=@id_koleksi";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(update, GetConn());
                cmd.Parameters.Add("@id_koleksi", MySqlConnector.MySqlDbType.VarChar).Value = idKoleksi;
                cmd.Parameters.Add("@nama_koleksi", MySqlConnector.MySqlDbType.VarChar).Value = namaKoleksi;
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Koleksi Gagal" + ex.Message);
            }
        }

        public void hapusKoleksi(string idKoleksi)
        {
            string hapus = "DELETE FROM koleksi WHERE id=@id_koleksi";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(hapus, GetConn());
                cmd.Parameters.Add("@id_koleksi", MySqlConnector.MySqlDbType.VarChar).Value = idKoleksi;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("delete data gagal" + ex.Message);
            }
        }

        //=========================================================================
        //=========================================================================

        public DataTable tampilRak(MySqlCommand c)
        {
            DataTable data = new DataTable();
            try
            {
                string tampil = "SELECT * FROM rak";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }


        public void tambahRak(string idRak, string namaRak)
        {
            string tambah = "insert into rak values(" + "@id_rak,@nama_rak)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@id_rak", MySqlConnector.MySqlDbType.VarChar).Value = idRak;
                cmd.Parameters.Add("@nama_rak", MySqlConnector.MySqlDbType.VarChar).Value = namaRak;
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah Rak Gagal" + ex.Message);
            }
        }

        public void updateRak(string idRak, string namaRak)
        {
            string update = "update rak set nama_rak=@nama_rak where id=@id_rak";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(update, GetConn());
                cmd.Parameters.Add("@id_rak", MySqlConnector.MySqlDbType.VarChar).Value = idRak;
                cmd.Parameters.Add("@nama_rak", MySqlConnector.MySqlDbType.VarChar).Value = namaRak;
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Rak Gagal" + ex.Message);
            }
        }

        public void hapusRak(string idRak)
        {
            string hapus = "DELETE FROM rak WHERE id=@id_rak";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(hapus, GetConn());
                cmd.Parameters.Add("@id_rak", MySqlConnector.MySqlDbType.VarChar).Value = idRak;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("delete data gagal" + ex.Message);
            }
        }


        //=========================================================================
        //=========================================================================

        public DataTable tampilBuku(MySqlCommand c)
        {
            DataTable data = new DataTable();
            try
            {
                string tampil = "SELECT * FROM buku";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }

        public void tambahBuku(string idBuku, string namaBuku, string penulis, string tahunTerbit, string stok, string idKoleksi, string idRak)
        {
            string tambah = "insert into buku values(" + "@id_buku,@nama_buku,@penulis,@tahunterbit,@stok,@idkoleksi,@idrak)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@id_buku", MySqlConnector.MySqlDbType.VarChar).Value = idBuku;
                cmd.Parameters.Add("@nama_buku", MySqlConnector.MySqlDbType.VarChar).Value = namaBuku;
                cmd.Parameters.Add("@penulis", MySqlConnector.MySqlDbType.VarChar).Value = penulis;
                cmd.Parameters.Add("@tahunterbit", MySqlConnector.MySqlDbType.VarChar).Value = tahunTerbit;
                cmd.Parameters.Add("@stok", MySqlConnector.MySqlDbType.VarChar).Value = stok;
                cmd.Parameters.Add("@idkoleksi", MySqlConnector.MySqlDbType.VarChar).Value = idKoleksi;
                cmd.Parameters.Add("@idrak", MySqlConnector.MySqlDbType.VarChar).Value = idRak;
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah Rak Gagal" + ex.Message);
            }
        }

        public void updateBuku(string idBuku, string namaBuku, string penulis, string tahunTerbit, string stok, string idKoleksi, string idRak)
        {
            string update = "update buku set judul=@nama_buku, penulis=@penulis, tahun_terbit=@tahun_terbit, stok=@stok, id_koleksi=@id_koleksi, id_rak=@id_rak where id=@id_buku";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(update, GetConn());
                cmd.Parameters.Add("@id_buku", MySqlConnector.MySqlDbType.VarChar).Value = idBuku;
                cmd.Parameters.Add("@nama_buku", MySqlConnector.MySqlDbType.VarChar).Value = namaBuku;
                cmd.Parameters.Add("@penulis", MySqlConnector.MySqlDbType.VarChar).Value = penulis;
                cmd.Parameters.Add("@tahun_terbit", MySqlConnector.MySqlDbType.VarChar).Value = tahunTerbit;
                cmd.Parameters.Add("@stok", MySqlConnector.MySqlDbType.VarChar).Value = stok;
                cmd.Parameters.Add("@id_koleksi", MySqlConnector.MySqlDbType.VarChar).Value = idKoleksi;
                cmd.Parameters.Add("@id_rak", MySqlConnector.MySqlDbType.VarChar).Value = idRak;
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Rak Gagal" + ex.Message);
            }
        }

        public void hapusBuku(string idBuku)
        {
            string hapus = "DELETE FROM buku WHERE id=@id_buku";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(hapus, GetConn());
                cmd.Parameters.Add("@id_buku", MySqlConnector.MySqlDbType.VarChar).Value = idBuku;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("delete data gagal" + ex.Message);
            }
        }

        //=========================================================================
        //=========================================================================

        public DataTable tampilPengunjung(MySqlCommand c)
        {
            DataTable data = new DataTable();
            try
            {
                string tampil = "SELECT * FROM pengunjung";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }

        public void tambahPengunjung(string idPengunjung, string namaPengunjung, string jenisKelamin, string programStudi, string kebutuhan, string tanggal)
        {
            string tambah = "insert into pengunjung values(" + "@id_pengunjung,@nama_pengunjung,@jenis_kelamin,@program_studi,@kebutuhan,@tanggal)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@id_pengunjung", MySqlConnector.MySqlDbType.VarChar).Value = idPengunjung;
                cmd.Parameters.Add("@nama_pengunjung", MySqlConnector.MySqlDbType.VarChar).Value = namaPengunjung;
                cmd.Parameters.Add("@jenis_kelamin", MySqlConnector.MySqlDbType.VarChar).Value = jenisKelamin;
                cmd.Parameters.Add("@program_studi", MySqlConnector.MySqlDbType.VarChar).Value = programStudi;
                cmd.Parameters.Add("@kebutuhan", MySqlConnector.MySqlDbType.VarChar).Value = kebutuhan;
                cmd.Parameters.Add("@tanggal", MySqlConnector.MySqlDbType.VarChar).Value = tanggal;
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah Pengunjung Gagal" + ex.Message);
            }
        }

        public void updatePengunjung(string idPengunjung, string namaPengunjung, string jenisKelamin, string programStudi, string kebutuhan, string tanggal)
        {
            string update = "update pengunjung set nama=@nama_pengunjung, jenis_kelamin=@jenis_kelamin, program_studi=@program_studi, kebutuhan=@kebutuhan, tanggal=@tanggal where id=@id_pengunjung";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(update, GetConn());
                cmd.Parameters.Add("@id_pengunjung", MySqlConnector.MySqlDbType.VarChar).Value = idPengunjung;
                cmd.Parameters.Add("@nama_pengunjung", MySqlConnector.MySqlDbType.VarChar).Value = namaPengunjung;
                cmd.Parameters.Add("@jenis_kelamin", MySqlConnector.MySqlDbType.VarChar).Value = jenisKelamin;
                cmd.Parameters.Add("@program_studi", MySqlConnector.MySqlDbType.VarChar).Value = programStudi;
                cmd.Parameters.Add("@kebutuhan", MySqlConnector.MySqlDbType.VarChar).Value = kebutuhan;
                cmd.Parameters.Add("@tanggal", MySqlConnector.MySqlDbType.VarChar).Value = tanggal;
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Pengunjung Gagal" + ex.Message);
            }
        }

        public void hapusPengunjung(string idPengunjung)
        {
            string hapus = "DELETE FROM pengunjung WHERE id=@id_pengunjung";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(hapus, GetConn());
                cmd.Parameters.Add("@id_pengunjung", MySqlConnector.MySqlDbType.VarChar).Value = idPengunjung;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("delete data gagal" + ex.Message);
            }
        }
    }
}
