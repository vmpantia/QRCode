using IronBarCode;
using QRCodeReader.Desktop.Common;
using System;
using System.Collections.Generic;
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

        private static string GenerateQRCodeName()
        {
            return string.Format(Constants.QRCODE_NAME_FORMAT,
                                                Globals.EXEC_DATE_YYYYMMDD,
                                                Constants.QRCODE_EXTENSION);
        }
    }
}
