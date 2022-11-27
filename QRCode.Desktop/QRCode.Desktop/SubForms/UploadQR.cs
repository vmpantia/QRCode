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
    public partial class UploadQR : Form
    {
        public UploadQR()
        {
            InitializeComponent();
        }

        [Obsolete]
        private void btnUploadQR_Click(object sender, EventArgs e)
        {            
            try
            {

                // open file dialog   
                OpenFileDialog open = new OpenFileDialog();
                // image filters  
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    // display image in picture box  
                    picQR.Image = new Bitmap(open.FileName);

                    var result = QRCodeService.ReadQRByImage(picQR.Image);
                    txtQRContent.Text = result.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),
                                Constants.MBOX_ERR,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                picQR.Image = null;
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
