using FormLatihanSebelumNgajar.Controller;
using MySqlConnector;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FormLatihanSebelumNgajar.View
{
    public partial class FormMahasiswa : Form
    {
        private MahasiswaController mahasiswaController = new MahasiswaController();
        public FormMahasiswa()
        {
            InitializeComponent();
        }

        bool showStudent()
        {
            DataGridView_mahasiswa.DataSource = mahasiswaController.selectStudent
                (new MySqlCommand("SELECT * FROM mahasiswa"));
            DataGridView_mahasiswa.RowTemplate.Height = 80;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView_mahasiswa.Columns[3];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            return true;
        }
        bool verify()
        {
            if ((txt_nim.Text == "") || (txt_nama.Text == "") || (PictureBox_mahasiswa.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            txt_nim.MaxLength = 10;
            txt_nama.MaxLength = 25;
            showStudent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_bersihkan_Click(object sender, EventArgs e)
        {
            txt_nim.Clear();
            txt_nama.Clear();
            DateTimePicker_tanggal_lahir.Value = DateTime.Now;
            PictureBox_mahasiswa.Image = null;
        }
        private void btn_simpan_Click(object sender, EventArgs e)
        {
            int born_year = DateTimePicker_tanggal_lahir.Value.Year;
            int this_year = DateTime.Now.Year;
            if ((this_year - born_year) <= 17 || (this_year - born_year) >= 25)
            {
                MessageBox.Show("Umur harus diantar 17 s/d 25", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verify())
            {
                try
                {
                    MemoryStream memori = new MemoryStream();
                    PictureBox_mahasiswa.Image.Save(memori, PictureBox_mahasiswa.Image.RawFormat);
                    byte[] img = memori.ToArray();
                    mahasiswaController.insertStudent(txt_nim.Text, txt_nama.Text,
                        DateTimePicker_tanggal_lahir.Value, img);
                    MessageBox.Show("Penambahan data baru berhasil", "Simpan data",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showStudent();
                    txt_nim.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Inputan kosong", "Tambah data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "select Photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif;";

            if (opf.ShowDialog() == DialogResult.OK)
                PictureBox_mahasiswa.Image = Image.FromFile(opf.FileName);
        }

        private void DataGridView_mahasiswa_Click(object sender, EventArgs e)
        {
            txt_nim.Text = DataGridView_mahasiswa.CurrentRow.Cells[0].Value.ToString();
            txt_nama.Text = DataGridView_mahasiswa.CurrentRow.Cells[1].Value.ToString();
            DateTimePicker_tanggal_lahir.Value = (DateTime)DataGridView_mahasiswa.CurrentRow.Cells[2].Value;
            byte[] img = (byte[])DataGridView_mahasiswa.CurrentRow.Cells[3].Value;
            MemoryStream gambar = new MemoryStream(img);
            PictureBox_mahasiswa.Image = Image.FromStream(gambar);
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            if (verify()){
                try
                {
                    mahasiswaController.deleteStudent(txt_nim.Text);
                    showStudent();
                    btn_bersihkan.PerformClick();
                    MessageBox.Show("Hapus data berhasil", "Hapus data", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_nim.Focus();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else
            {
                MessageBox.Show("Hapus data error", "Hapus data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
