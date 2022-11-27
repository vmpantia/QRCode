using IronBarCode;
using QRCodeReader.Desktop.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QRCodeReader.Desktop.Services
{
    public static class QRCodeService
    {
        public static string GenerateQRCode(string qrContent)
        {
            var fileName = Constants.DEFAULT_FILE_LOC + GenerateQRCodeName();

            if(File.Exists(fileName))
                throw new Exception(string.Format(Constants.ERROR_MESSAGE_FILE_EXIST, fileName));

            GeneratedBarcode qr = QRCodeWriter.CreateQrCode(qrContent);
            qr.AddAnnotationTextAboveBarcode(Constants.QRCODE_NOTE);
            qr.AddBarcodeValueTextBelowBarcode();

            if (qr == null)
                throw new Exception(Constants.ERROR_MESSAGE_GENERATE_QR);

            qr.SaveAsPng(fileName);

            return fileName;
        }

        [Obsolete]
        public static string ReadQRByImage(Image qr)
        {
            if (qr == null)
                throw new Exception("QR Code cannot be found.");

            BarcodeResult res = BarcodeReader.QuicklyReadOneBarcode((Bitmap)qr);
            if (res == null)
            {
                throw new Exception("Error in reading your QR Code.");
            }
            return res.ToString();
        }

        private static string GenerateQRCodeName()
        {
            return string.Format(Constants.QRCODE_NAME_FORMAT,
                                                Globals.EXEC_DATE_YYYYMMDD,
                                                Constants.QRCODE_EXTENSION);
        }
    }
}
