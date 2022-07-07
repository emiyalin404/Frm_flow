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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            Form1 a = new Form1();
            a.TopLevel = false;
            a.Visible = true;
            a.Top = 0;
            a.Left = 0;
            splitContainer1.Panel2.Controls.Add(a);
            a.Show();
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            Form2 a = new Form2();
            a.TopLevel = false;
            a.Visible = true;
            a.Top = 0;
            a.Left = 0;
            splitContainer1.Panel2.Controls.Add(a);
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            Form3 a = new Form3();
            a.TopLevel = false;
            a.Visible = true;
            a.Top = 0;
            a.Left = 0;
            splitContainer1.Panel2.Controls.Add(a);
            a.Show();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {


        }

        private void Home_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            Form4 a = new Form4();
            a.TopLevel = false;
            a.Visible = true;
            a.Top = 0;
            a.Left = 0;
            splitContainer1.Panel2.Controls.Add(a);
            a.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            splitContainer1.Panel2.Controls.Clear();
            Form7 a = new Form7();
            a.TopLevel = false;
            a.Visible = true;
            a.Top = 0;
            a.Left = 0;
            splitContainer1.Panel2.Controls.Add(a);
            a.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            Form5 a = new Form5();
            a.TopLevel = false;
            a.Visible = true;
            a.Top = 0;
            a.Left = 0;
            splitContainer1.Panel2.Controls.Add(a);
            a.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            Form6 a = new Form6();
            a.Show();
        }
    }
}



