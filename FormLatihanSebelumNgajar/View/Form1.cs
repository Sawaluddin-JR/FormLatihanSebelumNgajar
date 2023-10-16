using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormLatihanSebelumNgajar
{
    public partial class Form1 : Form
    {
        string name;
        string email;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Cyan;
            this.Text = "Selamat Datang";
            //txtEmail.UseSystemPasswordChar = true;
        }
        public string GetName()
        {
            string marga = "Siregar";
            this.name = txtName.Text + marga;
            return this.name;
        }

        public string GetEmail()
        {
            this.email = txtEmail.Text;
            return this.email;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Form2 form2 = new Form2();
            form2.form1 = this;
            form2.ShowDialog();*/

            label1.Text = txtName.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = txtName.Text;
        }
    }
}
