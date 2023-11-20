using FormLatihanSebelumNgajar.Controller;
using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

namespace FormLatihanSebelumNgajar.View
{
    public partial class Form7 : Form
    {
        Kuis14 kuis14 = new Kuis14();
        public Form7()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox_email.Text;
            string kataSandi = textBox_pass.Text;
            DataTable table = kuis14.getList(new MySqlCommand
                ("SELECT * FROM admin WHERE email = '" + email + "' AND kata_sandi ='" + kataSandi + "'"));

            if (table.Rows.Count > 0)
            {
                Form8 form8 = new Form8();
                this.Hide();
                form8.Show();
            }
            else
            {
                MessageBox.Show("email dan password salah", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

