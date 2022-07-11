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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        //F1 a = new F1();
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form5_1 a = new Form5_1();

            a.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form5_2 a = new Form5_2();

            a.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form5_3 a = new Form5_3();

            a.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form5_4 a = new Form5_4();

            a.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Form5_5 a = new Form5_5();

            a.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form5_6 a = new Form5_6();

            a.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form5_7 a = new Form5_7();

            a.Show();
        }
    }


}
