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
    public struct Product
    {
        public string Name;
        public int chi, eng, math;
    }


    public partial class Form7 : Form
    {
        string result;
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product pro = new Product();
            pro.Name = textBox1.Text;
            pro.chi = int.Parse(textBox2.Text);
            pro.eng = int.Parse(textBox3.Text);
            pro.math = int.Parse(textBox4.Text);
            result = "姓名：" + pro.Name + "\n國文：" + pro.chi
                + "\n英文：" + pro.eng + "\n數學：" + pro.math;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = result;
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            Product pro = new Product();
            pro.Name = textBox1.Text;
            pro.chi = int.Parse(textBox2.Text);
            pro.eng = int.Parse(textBox3.Text);
            pro.math = int.Parse(textBox4.Text);
            int[] arr = { pro.chi, pro.eng, pro.math };
            string[] sei = { "國文", "英文", "數學" };
            int max = arr[0];
            int min = arr[0];
            string max1 = sei[0];
            string min1 = sei[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    max1 = sei[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                    min1 = sei[i];
                }
            }
            label6.Text = "最高分：" + max1 + max + "\n最低分：" + min1 + min;

        }
    }
}
