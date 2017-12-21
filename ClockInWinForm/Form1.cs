using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockInWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Tick += Timer1_Tick;

            // this는 Form1을 가리킴
            this.BackColor = Color.LightSteelBlue;
            this.Text = "myDigitalClock";

            label1.Text = DateTime.Now.ToString();
            label1.TextAlign = ContentAlignment.MiddleCenter;  
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label1.Location = new Point(this.ClientSize.Width / 2 - label1.Width / 2,
               this.ClientSize.Height / 2 - label1.Height / 2);
            label1.Text = DateTime.Now.ToString();
        }
    }
}
