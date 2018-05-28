using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Int32 secs = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                button1.Text = "Start";
            }
            else
            {
                timer1.Enabled = true;
                button1.Text = "Pause";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            secs++;
            setWatch();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            secs = 0;
            setWatch();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            secs = 0;
            setWatch();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void setWatch()
        {
            label1.Text = (secs / 60).ToString("D2") + ":" + (secs % 60).ToString("D2");
        }
    }
}
