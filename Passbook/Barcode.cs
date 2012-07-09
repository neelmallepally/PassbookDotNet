using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PKPassbookCSharp
{
    public class Barcode
    {
        public string Message { get; set; }// "message" : "123456789",
        public string Format { get; set; }//"format" : "PKBarcodeFormatPDF417",
        public string MessageEncoding { get; set; }//"messageEncoding" : "iso-8859-1"
    }
}
