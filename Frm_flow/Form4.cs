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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Int32.Parse(textBox1.Text);
                int b = Int32.Parse(textBox2.Text);
                label1.Text = (a + b).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入數值 就你最特別");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Int32.Parse(textBox1.Text);
                int b = Int32.Parse(textBox2.Text);
                label1.Text = (a - b).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入數值 就你最特別");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Int32.Parse(textBox1.Text);
                int b = Int32.Parse(textBox2.Text);
                label1.Text = (a * b).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入數值 就你最特別");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Int32.Parse(textBox1.Text);
                double b = Int32.Parse(textBox2.Text);
                label1.Text = (a / b).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入數值 就你最特別");
            }
        }
    }
}
