using QRCodeReader.Desktop.Common;
using QRCodeReader.Desktop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCodeReader.Desktop.SubForms
{
    public partial class GenerateQRForm : Form
    {
        public GenerateQRForm()
        {
            InitializeComponent();
        }

        private void btnGenerateQR_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtQRContent.Text))
                {
                    MessageBox.Show(Constants.ERROR_MESSAGE_QR_CONTENT_EMPTY, 
                                    Constants.MBOX_WARN, 
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Warning);
                    return;
                }

                var file = QRCodeService.GenerateQRCode(txtQRContent.Text);
                MessageBox.Show(Constants.SUCESS_QR_GENERATED + file, 
                                Constants.MBOX_INFO, 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Information);
                return;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), 
                                Constants.MBOX_ERR,
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
                return;
            }
        }
    }
}
