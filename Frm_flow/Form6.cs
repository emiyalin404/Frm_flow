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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            label1.Left = 0;
            wForm = this.Width;
            timer1.Enabled = true;
            wLable = label1.Width;
            label1.Top = 0;
            hFrom = this.Height;
            hLable = label1.Height ;

        }
        int wForm = 0;
        int wLable = 0;
        int hFrom = 0;
        int hLable = 0;
        int ixStart = 0;
        int iyStart = 0;
        private void Form6_MouseMove(object sender, MouseEventArgs e)
        {
            if (ixStart == 0 & iyStart == 0)
            {
                ixStart = e.X;
                iyStart = e.Y;
                //return;
            }
            //判斷自螢幕保護程式執行後,滑鼠的位置是否變動
            else if (e.X != ixStart || e.Y != iyStart)
            {
                Cursor.Show();
                timer1.Enabled = false;
                //Application.Exit();
                this.Close();
            };
        }
        int xxx = 10;
        int yyy = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
           
             label1.Left += xxx;
             label1.Top += yyy;

            if (label1.Left >= wForm - wLable)
            {
                xxx *= -1;
            }
             if ((label1.Left) < 0)
            { 
                xxx *= -1; 
            }
            if (label1.Top >= hFrom - hLable)
            {
                yyy *= -1;
            }
             if ((label1.Top) < 0)
            {
                yyy *= -1;
            }



            //label1.Left = 0;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
