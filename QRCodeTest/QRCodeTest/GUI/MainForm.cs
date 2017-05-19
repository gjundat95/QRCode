using QRCodeLibray;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QRCodeTest.GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            string employeeId = txtEmployeeId.Text.ToString();
            if (!employeeId.Equals(""))
            {
                ptbQRCode.BackgroundImage = QRCodeLibrary.GenerateQR(300, 300, employeeId);
                ptbQRCode.Size = new System.Drawing.Size(300, 300);
                ptbQRCode.SizeMode = PictureBoxSizeMode.CenterImage;
                ptbQRCode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else {
                MessageBox.Show("Please enter employeeId", "Warning");
            }
            
        }


    }
}
