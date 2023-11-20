using FormLatihanSebelumNgajar.Model;
using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

namespace FormLatihanSebelumNgajar.Controller
{
    internal class Kuis14
    {
        Koneksi koneksi = new Koneksi();
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
