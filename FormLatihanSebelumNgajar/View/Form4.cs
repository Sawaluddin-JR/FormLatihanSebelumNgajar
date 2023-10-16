using System;
using System.Windows.Forms;

namespace FormLatihanSebelumNgajar
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public double bil1, bil2, hasil;
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnkurang_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDouble(textAngka1.Text);
            bil2 = Convert.ToDouble(textAngka2.Text);
            hasil = bil1 - bil2;
            textHasil.Text = hasil.ToString();
        }

        private void btnbagi_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDouble(textAngka1.Text);
            bil2 = Convert.ToDouble(textAngka2.Text);
            hasil = bil1 / bil2;
            textHasil.Text = hasil.ToString();
        }

        private void btnkali_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDouble(textAngka1.Text);
            bil2 = Convert.ToDouble(textAngka2.Text);
            hasil = bil1 * bil2;
            textHasil.Text = hasil.ToString();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnSD_Click(object sender, EventArgs e)
        {

        }

        private void btntambah_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDouble(textAngka1.Text);
            bil2 = Convert.ToDouble(textAngka2.Text);
            hasil = bil1 + bil2;
            textHasil.Text = hasil.ToString();
        }
    }
}
