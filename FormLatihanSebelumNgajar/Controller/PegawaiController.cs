using FormLatihanSebelumNgajar.Model;
using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

namespace FormLatihanSebelumNgajar.Controller
{
    internal class PegawaiController : Model.Koneksi
    {
        Koneksi koneksi = new Koneksi();
        public DataTable selectPegawai(MySqlCommand command)
        {
            DataTable date = new DataTable();
            try
            {
                string show = "SELECT * FROM pegawai";
                da = new MySqlConnector.MySqlDataAdapter(show, GetConnection());
                da.Fill(date);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return date;
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

        public void deletePegawai(string id)
        {
            string delete = "DELETE FROM pegawai WHERE Id=" + id;

            try
            {
                cmd = new MySqlConnector.MySqlCommand(delete, GetConnection());
                cmd.Parameters.Add("@Id", MySqlConnector.MySqlDbType.VarChar).Value = id;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed!!" + ex.Message);
            }
        }

        public DataTable searchPegawai(string search)
        {
            DataTable table = new DataTable();
            try
            {
                MySqlCommand command = new MySqlCommand
                    ("SELECT * FROM pegawai WHERE CONCAT(Id,Nama,Alamat,Agama,Umur)LIKE '%" + search + "%'", koneksi.GetConnection());
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
