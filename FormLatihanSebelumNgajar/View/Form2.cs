using System;
using System.Windows.Forms;

namespace FormLatihanSebelumNgajar
{
    public partial class Form2 : Form
    {
        public Form1 form1;
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void tampilForm()
        {
            txtTampilName.Text = form1.GetName();
            txtTampilEmail.Text = form1.GetEmail();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            tampilForm();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedItem.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
