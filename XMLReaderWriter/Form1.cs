using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;


namespace XMLReaderWriter
{
    public partial class Form1 : Form
    {
        CXMLControl _XML = new CXMLControl();

        Dictionary<string, string> _dData = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnConfigSet_Click(object sender, EventArgs e)
        {
            string strEnter = "\r\n";

            string strText = tboxData.Text;
            bool bChecked = cboxData.Checked;
            int iNumber = (int)numData.Value;

            StringBuilder sb = new StringBuilder();
            sb.Append(strText + strEnter);
            sb.Append(bChecked.ToString() + strEnter);
            sb.Append(iNumber.ToString());

            tboxConfigData.Text = sb.ToString();

            _dData.Clear();

            _dData.Add(CXMLControl._TEXT_DATA, strText);
            _dData.Add(CXMLControl._CBOX_DATA, bChecked.ToString());
            _dData.Add(CXMLControl._NUMBER_DATA, iNumber.ToString());
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string strFilePath = string.Empty;

            SFDialog.InitialDirectory = Application.StartupPath;  //프로그램 실행파일 위치
            SFDialog.FileName = "*.xml";
            SFDialog.Filter = "xml files (*.xml)|*.xml|All file (*.*)|*.*";

            if (SFDialog.ShowDialog() == DialogResult.OK)
            {
                strFilePath = SFDialog.FileName;

                //StreamWriter swSFDialog = new StreamWriter(strFilePath);

                //swSFDialog.WriteLine(tboxConfigData.Text);
                //swSFDialog.Close();

                //File.WriteAllText(strFilePath, tboxConfigData.Text);

                _XML.fXML_Writer(strFilePath, _dData);
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            string strFilePath = string.Empty;

            OFDialog.InitialDirectory = Application.StartupPath;  //프로그램 실행파일 위치
            OFDialog.FileName = "*.xml";
            OFDialog.Filter = "xml files (*.xml)|*.xml|All file (*.*)|*.*";

            StringBuilder sb = new StringBuilder();

            if (OFDialog.ShowDialog() == DialogResult.OK)
            {
                strFilePath = OFDialog.FileName;

                //StreamReader srOFDialog = new StreamReader(strFilePath, Encoding.UTF8, true);

                //while(srOFDialog.EndOfStream==false)
                //{
                //    sb.Append(srOFDialog.ReadLine());
                //    sb.Append("\r\n");
                //}

                sb.Append(File.ReadAllText(strFilePath));

                tboxConfigData.Text = sb.ToString();

                _dData.Clear();
                _dData = _XML.FXML_Reader(strFilePath);
            }
        }

        private void BtnConfigRead_Click(object sender, EventArgs e)
        {
            //string[] strConfig = tboxConfigData.Text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            //tboxData.Text = strConfig[0];
            //cboxData.Checked = bool.Parse(strConfig[1]);
            //numData.Value = int.Parse(strConfig[2]);

            tboxData.Text = _dData[CXMLControl._TEXT_DATA];
            cboxData.Checked = bool.Parse(_dData[CXMLControl._CBOX_DATA]);
            numData.Value = int.Parse(_dData[CXMLControl._NUMBER_DATA]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
