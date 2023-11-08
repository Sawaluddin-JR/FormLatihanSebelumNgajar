using FormLatihanSebelumNgajar.Controller;
using MySqlConnector;
using System;
using System.Windows.Forms;

namespace FormLatihanSebelumNgajar.View
{
    public partial class Form6 : Form
    {
        PegawaiController pegawaiController = new PegawaiController();
        public Form6()
        {
            InitializeComponent();
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            showData(new MySqlCommand("SELECT * FROM pegawai"));
        }
        public void showData(MySqlCommand command)
        {
            DataGridView_pegawai.ReadOnly = true;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            DataGridView_pegawai.DataSource = pegawaiController.getList(command);
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            string selectQuery;
            if (radioButton_all.Checked)
            {
                selectQuery = "SELECT * FROM pegawai";
            }
            else if (radioButton_islam.Checked)
            {
                selectQuery = "SELECT * FROM pegawai WHERE Agama='Islam'";
            }
            else
            {
                selectQuery = "SELECT * FROM pegawai WHERE Agama='Kristen'";
            }
            showData(new MySqlCommand(selectQuery));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataGridView_pegawai.DataSource = pegawaiController.searchPegawai(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                pegawaiController.deletePegawai(textBox_id.Text);
                showData(new MySqlCommand("SELECT * FROM pegawai"));
                button_clear.PerformClick();
                MessageBox.Show("Pegawai Deleted Succesfully", "Delete Pegawai", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_id.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_id.Clear();
            textBox1.Clear();
        }
    }
}
