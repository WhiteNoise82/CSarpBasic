using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm1
{
    class Program : Form
    {
        static void Main(string[] args)
        {
            Button btn1 = new Button();
            btn1.Text = "Click!!";
            btn1.Top = 100;
            btn1.Left = 150;

            Program form1 = new Program();
            form1.Text = "Button & Form";
            form1.Width = 400;
            form1.Height = 300;

            form1.Controls.Add(btn1);

            btn1.Click += (object sender,EventArgs e) =>
            {
                MessageBox.Show("메세지 상자입니다.", "모달", MessageBoxButtons.AbortRetryIgnore);
            };

            Application.Run(form1);
        }
    }
}
