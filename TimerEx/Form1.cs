using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer oTimer = new Timer();

            oTimer.Enabled = true;
            oTimer.Interval = 1000;
            oTimer.Tick += OTimer_Tick;
            oTimer.Start();
        }

        private void OTimer_Tick(object sender, EventArgs e)
        {
            string dd = string.Empty;
        }
    }
}
