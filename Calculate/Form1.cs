using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate
{
    public partial class Calculate : Form
    {
        public double x, y;
        public char z;
        public Calculate()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            result_view.Text = "";
        }

        private void del_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(result_view.Text);
            z = '/';
            result_view.Text = "";
        }

        private void stepen_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(result_view.Text);
            result_view.Text = "";
            z = '^';
        }

        private void umn_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(result_view.Text);
            result_view.Text = "";
            z = '*';
        }

        private void minus_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(result_view.Text);
            result_view.Text = "";
            z = '-';
        }

        private void plus_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(result_view.Text);
            result_view.Text = "";
            z = '+';
        }

        private void result_Click(object sender, EventArgs e)
        {
            y = Convert.ToDouble(result_view.Text);
            result_view.Text = Convert.ToString(x + y);
            switch (z) {
                case '/': result_view.Text = Convert.ToString(x / y);break;
                case '^': result_view.Text = Convert.ToString(Math.Pow(x,y));break;
                case '+': result_view.Text = Convert.ToString(x+y); break;
                case '-': result_view.Text = Convert.ToString(x-y); break;
                case '*': result_view.Text = Convert.ToString(x*y); break;
            }
        }

        private void zero_Click(object sender, EventArgs e)
        {
            result_view.Text += "0";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            result_view.Text += "9";
        }

        private void eath_Click(object sender, EventArgs e)
        {
            result_view.Text += "8";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            result_view.Text += "7";
        }

        private void six_Click(object sender, EventArgs e)
        {
            result_view.Text += "6";
        }

        private void five_Click(object sender, EventArgs e)
        {
            result_view.Text += "5";
        }

        private void four_Click(object sender, EventArgs e)
        {
            result_view.Text += "4";
        }

        private void three_Click(object sender, EventArgs e)
        {
            result_view.Text += "3";
        }

        private void two_Click(object sender, EventArgs e)
        {
            result_view.Text += "2";
        }

        private void one_Click(object sender, EventArgs e)
        {
            result_view.Text += "1";
        }

        private void sized_Click(object sender, EventArgs e)
        {
            if (sized.Text == ">")
            {
                this.Size = new System.Drawing.Size(604, 548);
                sized.Location = new Point(sized.Location.X + 262, sized.Location.Y + 0);
                sized.Text = "<";
            }
            else {
                this.Size = new System.Drawing.Size(343, 548);
                sized.Location = new Point(sized.Location.X - 262, sized.Location.Y + 0);
                sized.Text = ">";
            }
        }

        private void cos_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(result_view.Text);
            result_view.Text = Convert.ToString(Math.Cos(x));
            z = 'c';
        }

        private void sin_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(result_view.Text);
            result_view.Text = Convert.ToString(Math.Sin(x));
            z = 's';
        }

        private void tg_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(result_view.Text);
            result_view.Text = Convert.ToString(Math.Sin(x)/Math.Cos(x));
            z = 't';
        }

        private void zap_Click(object sender, EventArgs e)
        {
            result_view.Text += ",";
        }

        private void ph_Click(object sender, EventArgs e)
        {
            phs();
        }

        private void result_view_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
