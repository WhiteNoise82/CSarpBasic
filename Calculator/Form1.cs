using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtInput.Text = "0";
            txtInput.SelectAll();
        }

        private void btnAbs_Click(object sender, EventArgs e)
        {
            Button btn=(Button)sender;
            
            if(btn.Text==btnAbs.Text){
}
        }
    }
}
