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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            try
            {
                string Name = txtName_1.Text;
                string EnglishName = txtName_2.Text;
                string Sex = txtName_3.Text;
                string Satre = txtName_4.Text;

                MessageBox.Show("Hellow,\n我的名字叫:" + Name + "\n我的英文名字是:" + EnglishName + "\n我的性別是:" + Sex + "生" + "\n我的星座是:" + Satre);
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入正確的數值資料");
                return;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Name = txtName_1.Text;
                string EnglishName = txtName_2.Text;
                string Sex = txtName_3.Text;
                string Satre = txtName_4.Text;

                MessageBox.Show("HI~,\n我的名字叫:" + Name + "\n我的英文名字是:" + EnglishName + "\n我的性別是:" + Sex + "生" + "\n我的星座是:" + Satre);
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入正確的數值資料");
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtName_1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
