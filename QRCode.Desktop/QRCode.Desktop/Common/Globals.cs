using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QRCodeReader.Desktop.Common
{
    internal class Globals
    {
        public static DateTime EXEC_DATE = DateTime.Now;
        public static string EXEC_DATE_YYYYMMDD = EXEC_DATE.ToString("yyyyMMdd");
    }
}
