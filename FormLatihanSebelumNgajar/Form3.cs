using System;
using System.Windows.Forms;

namespace FormLatihanSebelumNgajar
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        double temp;
        char oper;
        bool oper1;


        private void bersih()
        {
            hasiltxt.Text = "0";
            inputtxt.Text = "";
            temp = 0;
            oper = ' ';
            oper1 = false;
        }

        private void fokus()
        {
            hasiltxt.Focus();
            hasiltxt.Select(hasiltxt.Text.Length, 1);
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            bersih();
            fokus();
        }

        private void btnAngka_Click(object sender, EventArgs e)
        {
            Button btnAng = (Button)sender;
            if (hasiltxt.Text == "0")
            {
                hasiltxt.Clear();
            }
            if (oper == '=')
            {
                oper = ' ';
                hasiltxt.Clear();
                temp = 0;
            }
            hasiltxt.Text = hasiltxt.Text + btnAng.Text;
            fokus();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            bersih();
            fokus();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            hasiltxt.Text = "0";
            if (oper == '=')
            {
                temp = 0;
                oper1 = false;
                oper = ' ';
            }
            fokus();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            hasiltxt.Text = hasiltxt.Text.Remove(hasiltxt.Text.Length - 1);
            if ((hasiltxt.Text == "") || (hasiltxt.Text == "-"))
            {
                hasiltxt.Text = "0";
            }
            if (oper == '=')
            {
                temp = 0;
                oper1 = false;
                oper = ' ';
            }
            fokus();
        }

        private void btnoperator_Click(object sender, EventArgs e)
        {
            Button op = (Button)sender;
            if (oper1 == false)
            {
                if (inputtxt.Text == "")
                {
                    temp = Convert.ToDouble(hasiltxt.Text);
                }
                else
                {
                    if (oper == '+')
                    {
                        temp = temp + Convert.ToDouble(hasiltxt.Text);
                    }
                    else if (oper == '-')
                    {
                        temp = temp - Convert.ToDouble(hasiltxt.Text);
                    }
                    else if (oper == 'x')
                    {
                        temp = temp * Convert.ToDouble(hasiltxt.Text);
                    }
                    else if (oper == ':')
                    {
                        temp = temp / Convert.ToDouble(hasiltxt.Text);
                    }
                }
            }
            if (op.Text == "=")
            {
                inputtxt.Text = "";
                hasiltxt.Text = temp.ToString();
            }
            else
            {
                inputtxt.Text = temp.ToString() + op.Text;
                hasiltxt.Text = "0";
            }
            oper = Convert.ToChar(op.Text);
            fokus();
        }
    }
}
