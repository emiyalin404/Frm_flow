using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm_flow
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string money;
        public string year;
        public string moon;
        public string frist;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                money = txtmoney.Text;
                year = txtdate.Text;
                moon = txtpa.Text;
                frist = txtfrist.Text;
                double a1 = double.Parse(money);
                double a2 = double.Parse(year) * 12;
                double a3 = double.Parse(frist);
                double a4 = double.Parse(moon) / 100;
                double a5 = a4 / 12;
                double a6 = (Math.Pow((1 + a5), a2) * a5) / (Math.Pow((1 + a5), a2) - 1);
                double a7 = a1 - a3;
                double a8 = Math.Floor(a7 * a6);
                MessageBox.Show("月付" + a8 + "元");
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入正確的數值資料");
                return;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                money = txtmoney.Text;
                year = txtdate.Text;
                moon = txtpa.Text;
                frist = txtfrist.Text;
                double a1 = double.Parse(money);
                double a2 = double.Parse(year) * 12;
                double a3 = double.Parse(frist);
                double a4 = double.Parse(moon) / 100;
                double a5 = a4 / 12;
                double a6 = (Math.Pow((1 + a5), a2) * a5) / (Math.Pow((1 + a5), a2) - 1);
                double a7 = a1 - a3;
                double a8 = Math.Floor(a7 * a6);
                double a9 = a8 * a2;
                MessageBox.Show(a9.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入正確的數值資料");
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                money = txtmoney.Text;
                year = txtdate.Text;
                moon = txtpa.Text;
                frist = txtfrist.Text;
                double a1 = double.Parse(money);
                double a2 = double.Parse(year) * 12;
                double a3 = double.Parse(frist);
                double a4 = double.Parse(moon) / 100;
                double a5 = a4 / 12;
                double a6 = (Math.Pow((1 + a5), a2) * a5) / (Math.Pow((1 + a5), a2) - 1);
                double a7 = a1 - a3;
                double a8 = Math.Floor(a7 * a6);
                double a71 = a7 * a2;
                string b8 = "" + a8;
                string b71 = "" + a71;
                Form2_1 a = new Form2_1();
                a.label6.Text = txtmoney.Text;
                a.label7.Text = txtdate.Text;
                a.label8.Text = txtpa.Text;
                a.label9.Text = b8;
                a.label10.Text = b71;
                a.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入正確的數值資料");
                return;
            }
        }
    }
}
