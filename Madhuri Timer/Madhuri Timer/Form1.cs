using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Madhuri_Timer
{
    public partial class Form1 : Form
    {

        private int count = 0;
        private Boolean isTimerStarted = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {            
            timer1.Stop();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Interval = (int)numericUpDown1.Value * 1000;
            numericUpDown1.Enabled = false;
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            isTimerStarted = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            isTimerStarted = false;
            count = 0;
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            numericUpDown1.Enabled = true;
            lblCount.Text = count + "";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!timer1.Enabled && isTimerStarted)
            {
                count++;
            }
            lblCount.Text = count + "";
            timer1.Start();
        }
    }
}
