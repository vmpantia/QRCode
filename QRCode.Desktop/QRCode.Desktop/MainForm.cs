using QRCodeReader.Desktop.SubForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace QRCodeReader.Desktop
{
    public partial class MainForm : Form
    {
        private string fileName = string.Empty;
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGenerateQR_Click(object sender, EventArgs e)
        {
            var generateQRForm = new GenerateQRForm();
            generateQRForm.ShowDialog();
        }
    }
}
