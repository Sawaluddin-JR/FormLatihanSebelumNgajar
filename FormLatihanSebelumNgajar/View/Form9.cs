using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormLatihanSebelumNgajar.View
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch1.Checked == true)
            {
                this.BackColor = Color.FromArgb(34, 36, 49);
                label2.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.White;
                label2.ForeColor = Color.Black;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            pictureBox_indonesia.Visible = false;
            pictureBox_english.Visible = true;
        }

        private void pictureBox_indonesia_Click(object sender, EventArgs e)
        {
            if (pictureBox_indonesia.Visible == true)
            {
                pictureBox_indonesia.Visible = false;
                label2.Text = "Selamat Datang di Aplikasi saya";
            }
        }
        private void pictureBox_english_Click(object sender, EventArgs e)
        {
            if (pictureBox_indonesia.Visible == false)
            {
                pictureBox_indonesia.Visible = true;
                label2.Text = "Welcome to My Aplikasi";
            }
        }
    }
}
