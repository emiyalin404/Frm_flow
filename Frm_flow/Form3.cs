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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int i, j, k, l,a = 0;
        string s1, s2, s3, s4;
        private void button1_Click(object sender, EventArgs e)
        {
            a += 1000;
            l++;
            s3 = "薑汁汽水,  NT" + 1000 * l + "元\n";
            label6.Text = s1 + s2 + s3 + s4;
            label3.Text = Convert.ToString("NT：" + a);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a += 1000;
            i++;
            s4 = "peko梅酒,  NT" + 1000 * i + "元\n";
            label6.Text = s1 + s2 + s3 + s4;
            label3.Text = Convert.ToString("NT：" + a);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a += 2000;
            j++;
            s1 = "拉米水吟釀,  NT" + 2000 * j + "元\n";
            label6.Text = s1 + s2 + s3 + s4;
            label3.Text = Convert.ToString("NT：" + a);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a += 3000;
            k++;
            s2 = "團長琴酒,  NT" + 3000 * k + "元\n";
            label6.Text = s1 + s2 + s3 + s4;
            label3.Text = Convert.ToString("NT：" + a);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int money = a;
            MessageBox.Show("總金額：" + money + "元");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int money = a;
            MessageBox.Show("總金額：" + money + "元" + "\n信用卡 九折 :" + money * 0.9 + "元");
        }

        private void button7_Click(object sender, EventArgs e)
        {

            a = 0;
            i = 0;
            j = 0;
            k = 0;
            l = 0;
            s1 = "";
            s2 = "";
            s3 = "";
            s4 = "";
            label6.Text = s1 + s2 + s3 + s4;
            label3.Text = Convert.ToString("NT：" + a);
        }
    }
}
