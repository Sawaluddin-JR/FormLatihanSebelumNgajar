using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

namespace FormLatihanSebelumNgajar.Model
{
    internal class Koneksi
    {
        public MySqlCommand cmd;
        public DataSet ds;
        public MySqlDataAdapter da;

        public MySqlConnection GetConnection()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost;user=root;database=konekDatabase";

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi berhasil" + ex.Message);
            }
            return conn;
        }
    }
}
