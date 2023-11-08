using FormLatihanSebelumNgajar.Model;
using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

namespace FormLatihanSebelumNgajar.Controller
{
    internal class MahasiswaController : Model.Koneksi
    {
        Koneksi koneksi = new Koneksi();
        // Function Untuk menampilkan data yang ada di tabel mahasiswa
        public DataTable selectStudent(MySqlCommand command)
        {
            DataTable date = new DataTable();
            try
            {
                string show = "SELECT * FROM mahasiswa";
                da = new MySqlConnector.MySqlDataAdapter(show, GetConnection());
                da.Fill(date);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return date;
        }

        // Function untuk menambahkan data-data ke dalam tabel mahasiswa
        public void insertStudent(string nim, string name, DateTime tanggalLahir, byte[] photo)
        {
            string add = "INSERT INTO mahasiswa VALUES (" + "@NIM,@Nama,@Tanggal_lahir,@Photo)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(add, GetConnection());
                cmd.Parameters.Add("@NIM", MySqlConnector.MySqlDbType.VarChar).Value = nim;
                cmd.Parameters.Add("@Nama", MySqlConnector.MySqlDbType.VarChar).Value = name;
                cmd.Parameters.Add("@Tanggal_lahir", MySqlConnector.MySqlDbType.Date).Value = tanggalLahir;
                cmd.Parameters.Add("@Photo", MySqlConnector.MySqlDbType.Blob).Value = photo;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add Date Failed!! " + ex.Message);
            }
        }

        // Function untuk menghapus data berdasarkan NIM di tabel mahasiswa
        public void deleteStudent(string NIM)
        {
            string delete = "DELETE FROM mahasiswa WHERE NIM=" + NIM;

            try
            {
                cmd = new MySqlConnector.MySqlCommand(delete, GetConnection());
                cmd.Parameters.Add("@NIS", MySqlConnector.MySqlDbType.VarChar).Value = NIM;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed!!" + ex.Message);
            }
        }
        public DataTable getList(MySqlCommand command)
        {
            command.Connection = koneksi.GetConnection();
            DataTable table = new DataTable();
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return table;
        }
    }
}
