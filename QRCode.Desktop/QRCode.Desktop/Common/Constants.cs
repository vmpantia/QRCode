using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QRCodeReader.Desktop.Common
{
    internal class Constants
    {
        public const string QRCODE_NAME_FORMAT = "{0}_QRCode.{1}";
        public const string QRCODE_NOTE = "QR Code by VMP";
        public const string QRCODE_EXTENSION = "png";

        public const string DEFAULT_FILE_LOC = @"C:\Users\vince\OneDrive\Desktop\";

        public const string MBOX_INFO = "Information";
        public const string MBOX_WARN = "Warning";
        public const string MBOX_ERR = "Error";

        public const string ERROR_MESSAGE_QR_CONTENT_EMPTY = "QR Content must have values.";
        public const string ERROR_MESSAGE_GENERATE_QR = "Error in generating QR code.";
        public const string ERROR_MESSAGE_FILE_EXIST = "The file {0} already exist.";

        public const string SUCESS_QR_GENERATED = "QR Generated Successfullly, Please check the file below \n";

    }
}
